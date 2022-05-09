using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Reduce_Parser
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            PrepareItemDragger();
            _process_Timer = new Stopwatch();
        }

        #region Parsing Table

        List<string> terminals = new List<string>();
        List<string> nonTerminals = new List<string>();

        Dictionary<string, int> columns = new Dictionary<string, int>();

        private void GenerateAugmentedGrammar()
        {
            augmented_Grammar_List.Items.Clear();
            string newGrammar = grammar_List.Items[0].Text.Substring(0, 1) + "` -> " + grammar_List.Items[0].Text.Substring(0, 1);
            augmented_Grammar_List.Items.Add(newGrammar);
            for (int i = 0; i < grammar_List.Items.Count; i++)
            {
                augmented_Grammar_List.Items.Add(grammar_List.Items[i].Text);
            }
        }

        private int GetCount(string prediction) //returns the length of the nonterminal/terminal
        {
            var count = 0;
            if (nonTerminals.Contains(prediction.Substring(prediction.IndexOf(".") + 1, 1)) || terminals.Contains(prediction.Substring(prediction.IndexOf(".") + 1, 1))) //Terminal/NonTerminal not including id
            {
                count = 1;
            }
            else if (nonTerminals.Contains(prediction.Substring(prediction.IndexOf(".") + 1, 2)) || terminals.Contains(prediction.Substring(prediction.IndexOf(".") + 1, 2))) //id
            {
                count = 2;
            }
            return count;
        }

        private string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        private string GetTermAfterPeriod(string prediction)
        {
            string output = prediction.Length >= prediction.IndexOf(".") + 2 ? prediction.Substring(prediction.IndexOf(".") + 1, 1) : "NONE";
            if (output.Equals("i"))
            {
                output = prediction.Length >= prediction.IndexOf(".") + 2 ? prediction.Substring(prediction.IndexOf(".") + 1, 2) : "NONE";
            }
            else if (string.IsNullOrWhiteSpace(output))
            {
                output = prediction.Length >= prediction.IndexOf(".") + 2 ? prediction.Substring(prediction.IndexOf(".") + 2, 1) : "NONE";
            }
            return output; //we dont do count, because id is not a nonterminal
        }

        private bool CheckPredictionExists(string prediction)
        {
            bool exists = false;
            for (int i = 0; i < lr0_Collection_Treeview.Nodes.Count; i++)
            {
                var node = lr0_Collection_Treeview.Nodes[i].Nodes[0];
                if (node.Text == prediction)
                {
                    exists = true;
                }

            }
            return exists;
        }

        private string GetPrediction(string prediction)
        {
            string nodeName = "";
            for (int i = 0; i < lr0_Collection_Treeview.Nodes.Count; i++)
            {
                var node = lr0_Collection_Treeview.Nodes[i].Nodes[0];
                if (node.Text == prediction)
                {
                    nodeName = lr0_Collection_Treeview.Nodes[i].Text;
                }

            }
            return nodeName;
        }
        private void GenerateLRCollection()
        {
            GetTerminalsAndNonTerminals();
            GenerateAugmentedGrammar();
            lr0_Collection_Treeview.Nodes.Clear();
            string currentRule = augmented_Grammar_List.Items[0].Text.Insert(6, ".");
            string term = currentRule.Substring(currentRule.IndexOf(".") + 1, 1);
            //Create I_0
            Dictionary<string, List<string>> groupedNonTerminals = new Dictionary<string, List<string>>(); //ex. I0 - { } 
            for (int i = 0; i < grammar_List.Items.Count; i++)
            {
                string nonTerminal = grammar_List.Items[i].Text.Substring(0, 1);
                if (!groupedNonTerminals.ContainsKey(nonTerminal))
                {
                    groupedNonTerminals[nonTerminal] = new List<string>();
                }
                groupedNonTerminals[nonTerminal].Add(grammar_List.Items[i].Text);
            }
            lr0_Collection_Treeview.Nodes.Add("I0").Name = "I0";
            lr0_Collection_Treeview.Nodes["I0"].Nodes.Add(currentRule);
            List<string> alreadyUsedTerms = new List<string>();
            for (int i = 0; i < lr0_Collection_Treeview.Nodes["I0"].Nodes.Count; i++)
            {
                string prediction = lr0_Collection_Treeview.Nodes["I0"].Nodes[i].Text;
                string termAfterPeriod = GetTermAfterPeriod(prediction);

                if (nonTerminals.Contains(termAfterPeriod) && !alreadyUsedTerms.Contains(termAfterPeriod))
                {
                    for (int l = 0; l < groupedNonTerminals[termAfterPeriod].Count; l++)
                    {
                        alreadyUsedTerms.Add(termAfterPeriod);
                        string newPrediction = groupedNonTerminals[termAfterPeriod][l].Insert(5, ".");
                        lr0_Collection_Treeview.Nodes["I0"].Nodes.Add(newPrediction);
                    }
                }
            }

            //Create Remaining Items
            for (int i = 0; i < lr0_Collection_Treeview.Nodes.Count; i++)
            {
                Dictionary<string, List<string>> similarPredictions = new Dictionary<string, List<string>>();
                List<string> ignoreTerms = new List<string>();
                for (int j = 0; j < lr0_Collection_Treeview.Nodes[i].Nodes.Count; j++)
                {
                    string prediction = lr0_Collection_Treeview.Nodes[i].Nodes[j].Text;
                    string termAfterPeriod = GetTermAfterPeriod(prediction);

                    int indexOfPeriod = prediction.IndexOf(".");
                    if (prediction.Length >= prediction.IndexOf(".") + 2)
                    {
                        int count = GetCount(RemoveWhitespace(prediction));
                        string futurePrediction;
                        if (!string.IsNullOrWhiteSpace(prediction.Substring(indexOfPeriod + 1, 1)))
                        {
                            futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".");
                        }
                        else
                        {
                            futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".");
                        }
                        if (!CheckPredictionExists(futurePrediction) && !ignoreTerms.Contains(termAfterPeriod))
                        {
                            if (similarPredictions.ContainsKey(termAfterPeriod))
                            {
                                similarPredictions[termAfterPeriod].Add(futurePrediction);
                            }
                            else
                            {
                                similarPredictions.Add(termAfterPeriod, new List<string>());
                                similarPredictions[termAfterPeriod].Add(futurePrediction);
                            }
                        }
                        else if (CheckPredictionExists(futurePrediction))
                        {
                            ignoreTerms.Add(termAfterPeriod);
                        }
                    }
                }

                for (int j = 0; j < similarPredictions.Count; j++) //for each one, create a new item
                {
                    var lastNode = lr0_Collection_Treeview.Nodes[lr0_Collection_Treeview.Nodes.Count - 1];

                    string newNodeName = "I" + (int.Parse(lastNode.Name.Substring(1)) + 1).ToString();
                    lr0_Collection_Treeview.Nodes.Add(newNodeName).Name = newNodeName;
                    for (int k = 0; k < similarPredictions[similarPredictions.ElementAt(j).Key].Count; k++)
                    {
                        List<string> predictions = similarPredictions[similarPredictions.ElementAt(j).Key];
                        lr0_Collection_Treeview.Nodes[newNodeName].Nodes.Add(predictions[k]);
                    }
                    List<string> usedTerms = new List<string>();
                    for (int k = 0; k < lr0_Collection_Treeview.Nodes[newNodeName].Nodes.Count; k++)
                    {
                        string prediction = lr0_Collection_Treeview.Nodes[newNodeName].Nodes[k].Text;
                        string termAfterPeriod = GetTermAfterPeriod(prediction);
                        if (nonTerminals.Contains(termAfterPeriod) && !usedTerms.Contains(termAfterPeriod))
                        {
                            for (int l = 0; l < groupedNonTerminals[termAfterPeriod].Count; l++)
                            {
                                usedTerms.Add(termAfterPeriod);
                                string newPrediction = groupedNonTerminals[termAfterPeriod][l].Insert(5, ".");
                                lr0_Collection_Treeview.Nodes[newNodeName].Nodes.Add(newPrediction);
                            }
                        }
                    }
                }
            }
            GenerateParseTable();
        }

        private Label CreateLabel(string text)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            return label;
        }

        private int GetGrammarIndex(string grammar)
        {
            int index = 0;
            for (int i = 0; i < grammar_List.Items.Count; i++)
            {
                if (grammar_List.Items[i].Text == grammar)
                {
                    index = i + 1;
                }
            }
            return index;
        }
        private void GenerateParseTable()
        {
            follow_List.Items.Clear();
            Parse_Table.Controls.Clear();
            ClearAllLists();
            Parse_Table.RowCount = lr0_Collection_Treeview.Nodes.Count + 1;
            Parse_Table.ColumnCount = terminals.Count + nonTerminals.Count + 2;
            //Create State, Action, and GoTo Label
            Dictionary<string, int[]> labels = new Dictionary<string, int[]>(){ //Label - column, row, columnSpan
                {"State", new int[] { 0, 1, 1 } },
                { "Action", new int[] { 1, 0, terminals.Count } },
                { "GoTo", new int[] { terminals.Count + 2, 0, nonTerminals.Count } },
            };
            for (int i = 0; i < labels.Count; i++) //Create top_table Labels
            {
                Label tableLabel = CreateLabel(labels.Keys.ElementAt(i));
                Parse_Table.Controls.Add(tableLabel, labels[labels.Keys.ElementAt(i)].ElementAt(0), labels[labels.Keys.ElementAt(i)].ElementAt(1));
                Control control = Parse_Table.GetControlFromPosition(labels[labels.Keys.ElementAt(i)].ElementAt(0), labels[labels.Keys.ElementAt(i)].ElementAt(1));
                Parse_Table.SetColumnSpan(control, labels[labels.Keys.ElementAt(i)].ElementAt(2));
            }
            for (int i = 0; i < Parse_Table.RowCount - 1; i++) //Create labels for each state
            {
                Label statesLabel = CreateLabel(i.ToString());
                Parse_Table.Controls.Add(statesLabel, 0, i + 2);
            }

            for (int i = 0; i < terminals.Count; i++) //create each action label
            {
                Label actionLabel = CreateLabel(terminals[i]);
                Parse_Table.Controls.Add(actionLabel, i + 1, 1);
                AddColumn(terminals[i], i + 1);
            }
            //create last action label - $
            Label label = CreateLabel("$");
            Parse_Table.Controls.Add(label, terminals.Count + 1, 1);
            AddColumn("$", terminals.Count + 1);

            Dictionary<string, List<string>> follows = new Dictionary<string, List<string>>(); //used to determine reduce in table
            for (int i = 0; i < nonTerminals.Count; i++)
            {
                follows.Add(nonTerminals[i], new List<string>());
            }
            for (int i = 0; i < nonTerminals.Count; i++) //create each goto label
            {
                Label gotoLabel = CreateLabel(nonTerminals[i]);
                Parse_Table.Controls.Add(gotoLabel, i + terminals.Count + 2, 1);
                AddColumn(nonTerminals[i], i + terminals.Count + 2);

                StringBuilder followList = new StringBuilder("Follow(" + nonTerminals[i] + ") = {");
                if (grammar_List.Items[0].Text.Substring(0, 1) == nonTerminals[i])
                {
                    follows[nonTerminals[i]].Add("$");
                    followList.Append("$");
                }
                for (int j = 0; j < grammar_List.Items.Count; j++)
                {
                    var key = grammar_List.Items[j].Text.Substring(0, 1);
                    char[] charArray = grammar_List.Items[j].Text.Substring(5).ToCharArray();
                    for (int k = 0; k < charArray.Length; k++)
                    {
                        if (charArray[k].ToString() == nonTerminals[i] && k == charArray.Length - 1) //Nonterminal at the end
                        {
                            for (int l = 0; l < follows[key].Count; l++)
                            {
                                if (!follows[nonTerminals[i]].Contains(follows[key][l]))
                                {
                                    follows[nonTerminals[i]].Add(follows[key][l]);
                                    if (followList.ToString().Substring(followList.Length - 1, 1) == "{")
                                    {
                                        followList.Append(follows[key][l]);
                                    }
                                    else
                                    {
                                        followList.Append(", " + follows[key][l]);
                                    };
                                }
                            }
                        }
                        else if (charArray[k].ToString() == nonTerminals[i]) //NonTerminal is NOT at the end
                        {
                            string predic = RemoveWhitespace(grammar_List.Items[j].Text.Substring(5));
                            string follower = predic.Substring(k + 1, 1);
                            if (terminals.Contains(follower) && !follows[nonTerminals[i]].Contains(follower)) //follower must be a terminal
                            {
                                follows[nonTerminals[i]].Add(follower);
                                followList.Append(", " + follower);
                            }
                        }
                        if (terminals.Contains(charArray[k].ToString()) && !follows[key].Contains(charArray[k].ToString()) && nonTerminals[i] == key) //if the char is a terminal and it hasnt been added to follows
                        {
                            follows[key].Add(charArray[k].ToString());
                            if (followList.ToString().Substring(followList.Length - 1, 1) == "{")
                            {
                                followList.Append(charArray[k]);
                            }
                            else
                            {
                                followList.Append(", " + charArray[k]);
                            };
                        }
                    }
                }
                followList.Append("}");
                follow_List.Items.Add(followList.ToString());
                follow_List.Refresh();
            }

            for (int i = 0; i < lr0_Collection_Treeview.Nodes.Count; i++) //check each item to fill in Shifts
            {
                for (int j = 0; j < lr0_Collection_Treeview.Nodes[i].Nodes.Count; j++)
                {
                    string prediction = lr0_Collection_Treeview.Nodes[i].Nodes[j].Text;
                    string termAfterPeriod = GetTermAfterPeriod(prediction);

                    int indexOfPeriod = prediction.IndexOf(".");
                    if (terminals.Contains(termAfterPeriod))
                    {
                        if (prediction.Length >= prediction.IndexOf(".") + 2)
                        {
                            int count = GetCount(RemoveWhitespace(prediction));
                            string futurePrediction;
                            if (!string.IsNullOrWhiteSpace(prediction.Substring(indexOfPeriod + 1, 1)))
                            {
                                futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".");
                            }
                            else
                            {
                                futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".");
                            }
                            for (int k = 0; k < lr0_Collection_Treeview.Nodes.Count; k++)
                            {
                                for (int l = 0; l < lr0_Collection_Treeview.Nodes[k].Nodes.Count; l++)
                                {
                                    var node = lr0_Collection_Treeview.Nodes[k].Nodes[l];
                                    if (node.Text == futurePrediction)
                                    {
                                        string state = lr0_Collection_Treeview.Nodes[i].Name.Substring(1);
                                        string shiftTo = lr0_Collection_Treeview.Nodes[k].Name.Substring(1);
                                        Label shiftLabel = CreateLabel("S" + shiftTo);
                                        shiftLabel.Font = new Font("Microsoft Sans Serif", 6.7f);
                                        Parse_Table.Controls.Add(shiftLabel, columns[termAfterPeriod], int.Parse(state) + 2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (nonTerminals.Contains(termAfterPeriod))
                    {
                        if (prediction.Length >= prediction.IndexOf(".") + 2)
                        {
                            int count = GetCount(RemoveWhitespace(prediction));
                            string futurePrediction;
                            if (!string.IsNullOrWhiteSpace(prediction.Substring(indexOfPeriod + 1, 1)))
                            {
                                futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count, ".");
                            }
                            else
                            {
                                futurePrediction = indexOfPeriod + count + 2 < prediction.Length ? prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".") : prediction.Remove(indexOfPeriod, 1).Insert(indexOfPeriod + count + 1, ".");
                            }

                            string row = lr0_Collection_Treeview.Nodes[i].Name.Substring(1);
                            string foundIn = GetPrediction(futurePrediction);
                            if (foundIn != "")
                            {
                                foundIn = foundIn.Substring(1);
                                Label goToLabel = CreateLabel(foundIn);
                                Parse_Table.Controls.Add(goToLabel, columns[termAfterPeriod], int.Parse(row) + 2);
                            }
                        }

                    }

                    if (!terminals.Contains(termAfterPeriod) && !nonTerminals.Contains(termAfterPeriod)) //The period is at the end
                    {
                        string terminal = prediction.Substring(0, 1) + "`";
                        if (prediction.Contains(terminal)) //acc
                        {
                            string row = lr0_Collection_Treeview.Nodes[i].Name.Substring(1);
                            Label accLabel = CreateLabel("accept");
                            accLabel.Font = new Font("Microsoft Sans Serif", 6f);
                            Parse_Table.Controls.Add(accLabel, columns["$"], int.Parse(row) + 2);
                        }
                        else //reduce
                        {
                            for (int k = 0; k < follows[prediction.Substring(0, 1)].Count; k++)
                            {
                                string column = follows[prediction.Substring(0, 1)][k];
                                string row = lr0_Collection_Treeview.Nodes[i].Name.Substring(1);
                                int reduceTo = GetGrammarIndex(prediction.Remove(prediction.IndexOf("."), 1));
                                Label reduceLabel = CreateLabel("R" + reduceTo.ToString());
                                reduceLabel.Font = new Font("Microsoft Sans Serif", 6.5f);
                                Parse_Table.Controls.Add(reduceLabel, columns[column], int.Parse(row) + 2);
                            }
                        }
                    }
                }
            }
            parsing_Process_Group.Visible = true;
        }

        private void GetTerminalsAndNonTerminals()
        {
            terminals.Clear();
            nonTerminals.Clear();
            columns.Clear();
            for (int i = 0; i < grammar_List.Items.Count; i++) //get nonTerminals
            {
                char[] charArray = grammar_List.Items[i].Text.ToString().ToCharArray();
                if (!nonTerminals.Contains(charArray[0].ToString()))
                {
                    nonTerminals.Add(charArray[0].ToString());
                }

            }
            for (int i = 0; i < grammar_List.Items.Count; i++) //get Terminals
            {
                char[] charArray = grammar_List.Items[i].Text.Substring(4).ToString().ToCharArray();
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (!terminals.Contains(charArray[j].ToString()) && !nonTerminals.Contains(charArray[j].ToString()) && !char.IsWhiteSpace(charArray[j]))
                    {
                        if (charArray[j] == 'i')
                        {
                            if (charArray[j + 1] == 'd')
                            {
                                terminals.Add(charArray[j].ToString() + charArray[j + 1].ToString());
                                j += 2;
                            }
                        }
                        else
                        {
                            terminals.Add(charArray[j].ToString());
                        }
                    }

                }
            }
        }


        private void insert_Button_Click(object sender, EventArgs e)
        {
            parsing_Process_Group.Visible = false;
            string terminal = grammar_Key_Textbox.Text;
            string rule = grammar_Rule_Textbox.Text;
            if (terminal != "Enter key here" && rule != "Enter rule here")
            {
                string grammar = (terminal + " -> " + rule).Trim();
                bool alreadyPresent = false;
                for (int i = 0; i < grammar_List.Items.Count; i++)
                {
                    if (grammar_List.Items[i].Text == grammar)
                    {
                        alreadyPresent = true;
                    }
                }
                if (!alreadyPresent)
                {
                    if (grammar_Rule_Textbox.Text.Contains("|"))
                    {
                        string[] ruleSplit = rule.Split('|');
                        grammar_List.Items.Add(terminal + " -> " + ruleSplit[0].Trim());
                        grammar_List.Items.Add(terminal + " -> " + ruleSplit[1].Trim());
                    }
                    else
                    {
                        grammar_List.Items.Add(grammar);
                    }
                }
                grammar_List.Refresh();
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            grammar_List.Items.Clear();
            augmented_Grammar_List.Items.Clear();
        }

        private void generate_Table_Button_Click(object sender, EventArgs e)
        {
            GenerateLRCollection();
        }

        #endregion

        #region Parsing Process
        string input;

        int index = 0;
        int lastPushedIndex = 0;

        Stack<string> stack;

        private Stopwatch _process_Timer;

        //Shifting through steps
        int currentActiveStep = 0;
        List<Control> steps = new List<Control>();
        List<Color> stepsColor = new List<Color>();

        private void onFocus(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Enter input here")
            {
                this.textBox1.Text = "";
            }
        }

        private void onFocusLost(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "Enter input here";
            }
        }

        private void onFocusKey(object sender, EventArgs e)
        {
            if (this.grammar_Key_Textbox.Text == "Enter key here")
            {
                this.grammar_Key_Textbox.Text = "";
            }
        }

        private void onFocusLostKey(object sender, EventArgs e)
        {
            if (this.grammar_Key_Textbox.Text == "")
            {
                this.grammar_Key_Textbox.Text = "Enter key here";
            }
        }

        private void onFocusRule(object sender, EventArgs e)
        {
            if (this.grammar_Rule_Textbox.Text == "Enter rule here")
            {
                this.grammar_Rule_Textbox.Text = "";
            }
        }

        private void onFocusLostRule(object sender, EventArgs e)
        {
            if (this.grammar_Rule_Textbox.Text == "")
            {
                this.grammar_Rule_Textbox.Text = "Enter rule here";
            }
        }

        private void shift(string match, string toState)
        {
            stack.Push(match + toState);
            index++;

            stack_List.Items.Add(match + toState);
            action_List.Items.Add("S" + toState);
            steps_List.Items.Add("Shift Input." + " Go to state " + toState);

            stack_List.Refresh();
            action_List.Refresh();
            steps_List.Refresh();
        }

        private void reduce(int productionRule)
        {
            string reduceTo = grammar_List.Items[productionRule - 1].Text.Substring(0, 1); //Get First element in Production Rule
            string process = derivation_Process_List.Items[derivation_Process_List.Items.Count - 1].Text;
            int goToState = 0;
            string grammarListItem = grammar_List.Items[productionRule - 1].Text.Substring(5);
            int numberToPop = 0;
            char[] ruleArray = grammarListItem.Replace(" ", "").ToCharArray();
            for (int i = 0; i < ruleArray.Length; i++) //Calcualate the number of items that need to be popped, based on how many items in a rule are present in the columns
            {
                string match = ruleArray[i].ToString();
                if (columns.ContainsKey(match))
                {
                    numberToPop++;
                }
                else
                {
                    while (!columns.ContainsKey(match))
                    {
                        match = match + ruleArray[i + 1].ToString();
                        i++;
                    }
                    numberToPop++;
                }
            }
            for (int i = 0; i < numberToPop; i++)
            {
                stack.Pop();
                stack_List.Items.RemoveAt(stack_List.Items.Count - 1);
            }
            //Get the goTo row
            char[] charArray = stack.Peek().ToCharArray();
            int firstDigitIndex = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsDigit(charArray[i]) && i != 0)
                {
                    firstDigitIndex = i;
                    break;
                }
            }
            int column = columns[reduceTo];
            int row = Int32.Parse(stack.Peek().Substring(firstDigitIndex)) + 2;
            goToState = Int32.Parse(Parse_Table.GetControlFromPosition(column, row).Text);
            stack.Push(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);
            stack_List.Items.Add(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);

            //Calculate Derivation Process
            string replace = grammar_List.Items[productionRule - 1].Text.Substring(5);
            if (numberToPop > 2)
            {
                lastPushedIndex -= (numberToPop - 1);
            }
            if (lastPushedIndex < 0)
            {
                lastPushedIndex = 0;
            }
            process = process.Remove(lastPushedIndex, replace.Replace(" ", "").Length).Insert(lastPushedIndex, reduceTo);
            Debug.WriteLine(process + ":" + lastPushedIndex);
            //Populate Tables
            derivation_Process_List.Items.Add(process);
            action_List.Items.Add("R" + productionRule);
            production_Rules_List.Items.Add(grammar_List.Items[productionRule - 1].Text);
            steps_List.Items.Add("Reduce using production rule " + productionRule + ". Go to state " + goToState);

            derivation_Process_List.Refresh();
            action_List.Refresh();
            production_Rules_List.Refresh();
            steps_List.Refresh();
        }

        private void AddColumn(string key, int index)
        {
            columns[key] = index;
        }

        private int GetRowFromStack()
        {
            int rowFromStack = -1; //Row can never be negative, so set it as default.
            char[] charArray = stack.ElementAt(0).ToCharArray(); //Look at characters of the last item in the stack
            for (int j = charArray.Count(); j > 0; j--)
            {
                int ind = j - 1;
                if (Char.IsDigit(charArray[ind]))
                {
                    if (charArray.Count() > 1) //if there is more than one character in the element
                    {
                        if (ind != 0)
                        {
                            if (rowFromStack != -1)
                            {
                                rowFromStack = Int32.Parse(charArray[ind].ToString() + rowFromStack);
                            }
                            else
                            {
                                rowFromStack = Int32.Parse(charArray[ind].ToString());
                            }
                        }
                    }
                    else
                    {
                        rowFromStack = Int32.Parse(charArray[ind].ToString());
                        break;
                    }
                }
                else
                {
                    break;
                }

            }
            return rowFromStack;
        }

        private void ClearAllLists()
        {
            derivation_Process_List.Items.Clear();
            production_Rules_List.Items.Clear();
            action_List.Items.Clear();
            stack_List.Items.Clear();
            steps_List.Items.Clear();

            if (steps.Count > 0)
            {
                steps[currentActiveStep].BackColor = DefaultBackColor;
                steps.Clear();
                stepsColor.Clear();
            }

            currentActiveStep = 0;
            steps_Result_Label.Visible = false;
            nav_Back.Visible = false;
            nav_Forward.Visible = false;
            nav_Index.Visible = false;
        }

        
        private void parse_Button_Click(object sender, EventArgs e)
        {
            ClearAllLists();

            input = textBox1.Text;
            input = input.Replace(" ", ""); //Remove whitespaces

            derivation_Process_List.Items.Add(input);
            derivation_Process_List.Refresh();

            _process_Timer.Restart();

            index = 0;

            stack = new Stack<string>(); //Create empty stack
            stack.Push("0"); //Where the stack begins

            stack_List.Items.Add("0");
            stack_List.Refresh();

            bool accepted = false;
            char[] inputChar = input.ToCharArray();
            while (index < inputChar.Length)
            {
                string match = inputChar[index].ToString();
                while (!columns.ContainsKey(match))
                {
                    if (index + 1 < inputChar.Length)
                    {
                        match = match + inputChar[index + 1].ToString();
                        index++;
                    } else
                    {
                        break;
                    }
                }
                Application.DoEvents();
                int rowFromStack = GetRowFromStack();
                int row = rowFromStack + 2; //+2 to compensate for the Action/Goto and variable columns.
                if (columns.ContainsKey(match))
                {
                    Control control = Parse_Table.GetControlFromPosition(columns[match], row);
                    
                    if (control != null)
                    {
                        if (!accepted)
                        {
                            string goal = control.Text.Substring(1);
                            steps.Add(control);
                            stepsColor.Add(Color.LightGreen);
                            if (!nonTerminals.Contains(match))
                            {
                                if (control.Text.StartsWith("S"))
                                {
                                    shift(match, goal);
                                    lastPushedIndex = index - (match.Length) - (input.Length - derivation_Process_List.Items[derivation_Process_List.Items.Count - 1].Text.Length);
                                }
                                //if match == GoToVariable then Shift control.Text
                                else if (control.Text.StartsWith("R"))
                                {
                                    reduce(Int32.Parse(goal));
                                }
                                else if (control.Text.Equals("accept"))
                                {
                                    _process_Timer.Stop();
                                    accepted = true;
                                    index++;
                                }
                            }
                            else
                            {
                                shift(match, control.Text);
                            }
                            Control state = Parse_Table.GetControlFromPosition(0, row);

                            control.BackColor = Color.LightGreen;
                            control.Refresh();

                            Thread.Sleep(500);

                            control.BackColor = DefaultBackColor;
                            control.Refresh();
                        }
                        else //Error
                        {
                            accepted = false;

                            control.BackColor = Color.Red;
                            control.Refresh();
                            Thread.Sleep(500);
                            control.BackColor = DefaultBackColor;
                            control.Refresh();

                            steps.Add(control);
                            stepsColor.Add(Color.Red);
                            steps_Result_Label.Visible = true;
                            steps_List.Items.Add("Syntax Error").ForeColor = Color.Red;
                            _process_Timer.Stop();
                            break;
                        }
                    }
                    else //Error
                    {
                        steps_List.Items.Add("Syntax Error").ForeColor = Color.Red;
                        _process_Timer.Stop();
                        break;
                    }
                }
                else //Error
                {
                    steps_List.Items.Add("Syntax Error").ForeColor = Color.Red;
                    _process_Timer.Stop();
                    break;
                }
            }
            steps_Result_Label.Visible = true;
            nav_Back.Visible = true;
            nav_Forward.Visible = true;
            nav_Index.Visible = true;
            if (accepted)
            {
                steps_Result_Label.ForeColor = Color.Green;
                steps_Result_Label.Text = "Expression has been parsed successfully in " + steps_List.Items.Count + " steps.";
            }
            else
            {
                steps_Result_Label.Text = "Expression has failed to parse due to step " + steps_List.Items.Count;
                steps_Result_Label.ForeColor = Color.Red;
            }
            currentActiveStep = 0;
            nav_Index.Text = currentActiveStep.ToString();
            if (steps.Count > 0)
            {
                steps[0].BackColor = stepsColor[0];
            } else
            {
                steps_List.Items.Add("Syntax Error").ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            process_Timer.Text = string.Format("{0:hh\\:mm\\:ss\\.fffff}", _process_Timer.Elapsed);
        }

        private void nav_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (currentActiveStep <= steps.Count - 1)
                {
                    steps[currentActiveStep].BackColor = DefaultBackColor;
                }
                currentActiveStep = Int32.Parse(nav_Index.Text);
                if (currentActiveStep <= steps.Count - 1)
                {
                    steps[currentActiveStep].BackColor = stepsColor[currentActiveStep];
                }
            }
        }

        private void nav_Back_Click(object sender, EventArgs e)
        {
            if (currentActiveStep <= steps.Count - 1)
            {
                steps[currentActiveStep].BackColor = DefaultBackColor;
            }
            currentActiveStep--;
            if (currentActiveStep < 0)
            {
                currentActiveStep = steps_List.Items.Count;
            }
            nav_Index.Text = currentActiveStep.ToString();
            if (currentActiveStep <= steps.Count - 1)
            {
                steps[currentActiveStep].BackColor = stepsColor[currentActiveStep];
            }
        }

        private void nav_Forward_Click(object sender, EventArgs e)
        {
            if (currentActiveStep <= steps.Count - 1)
            {
                steps[currentActiveStep].BackColor = DefaultBackColor;
            }
            currentActiveStep++;
            if (currentActiveStep > steps_List.Items.Count)
            {
                currentActiveStep = 0;
            }
            nav_Index.Text = currentActiveStep.ToString();
            if (currentActiveStep <= steps.Count - 1)
            {
                steps[currentActiveStep].BackColor = stepsColor[currentActiveStep];
            }
        }

        #endregion

        #region Grammar Reorder
        private void PrepareItemDragger()
        {
            grammar_List.ListViewItemSorter = new ListViewIndexComparer();

            // Initialize the insertion mark.
            grammar_List.InsertionMark.Color = Color.Blue;
            if (OSFeature.Feature.IsPresent(OSFeature.Themes))
            {
                grammar_List.AllowDrop = true;
                grammar_List.KeyDown += new KeyEventHandler(grammarList_KeyDown);
                grammar_List.ItemDrag += new ItemDragEventHandler(grammarList_ItemDrag);
                grammar_List.DragEnter += new DragEventHandler(grammarList_DragEnter);
                grammar_List.DragOver += new DragEventHandler(grammarList_DragOver);
                grammar_List.DragLeave += new EventHandler(grammarList_DragLeave);
                grammar_List.DragDrop += new DragEventHandler(grammarList_DragDrop);
            }
        }

        private void grammarList_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in grammar_List.SelectedItems)
                {
                    listViewItem.Remove();
                }
            }
        }

        // Starts the drag-and-drop operation when an item is dragged.
        private void grammarList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            grammar_List.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        // Sets the target drop effect.
        private void grammarList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        // Moves the insertion mark as the item is dragged.
        private void grammarList_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                grammar_List.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = grammar_List.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = grammar_List.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    grammar_List.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    grammar_List.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            grammar_List.InsertionMark.Index = targetIndex;
        }

        // Removes the insertion mark when the mouse leaves the control.
        private void grammarList_DragLeave(object sender, EventArgs e)
        {
            grammar_List.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void grammarList_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = grammar_List.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (grammar_List.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values.
            grammar_List.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            grammar_List.Items.Remove(draggedItem);
        }

        // Sorts ListViewItem objects by index.
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }
        #endregion
    }



}
