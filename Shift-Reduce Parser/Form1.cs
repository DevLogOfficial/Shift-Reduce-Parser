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
        string input;
        string identifier;
        Stack<string> stack;
        Dictionary<string, int> columns = new Dictionary<string, int>();

        int index = 0;
        int currentState = 0;
        int prevIdIndex = 0;
        int prevMatchIndex;

        private Stopwatch _process_Timer;

        //Shifting through steps
        int currentActiveStep = 0;
        List<Control> steps = new List<Control>();
        List<Color> stepsColor = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            addColumns();
            _process_Timer = new Stopwatch();
        }

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
            Debug.WriteLine(grammar_List.Items[productionRule - 1].Text);
            int goToState = 0;
            if (grammar_List.Items[productionRule - 1].Text.Split(new char[] { '+', '*', '(', ')' }).Length < 2)
            {
                stack.Pop();
                stack_List.Items.RemoveAt(stack_List.Items.Count - 1);
                int column = columns[reduceTo];
                int rowFromStack = GetRowFromStack();
                int row = rowFromStack + 2;
                stack.Push(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);
                stack_List.Items.Add(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);
                goToState = Int32.Parse(Parse_Table.GetControlFromPosition(column, row).Text);

                //Calculate Derivation Process
                string replace = grammar_List.Items[productionRule - 1].Text.Substring(5);
                if (replace == "id")
                {
                    replace = identifier;
                }
                process = process.Remove(prevMatchIndex, replace.Length).Insert(prevMatchIndex, reduceTo);
            }
            else
            {
                string matches = grammar_List.Items[productionRule - 1].Text.Substring(5).Replace(" ", "");
                int numberToPop = matches.Length;
                Debug.WriteLine("NUMBER TO POP: " + numberToPop + "REPLACING: " + grammar_List.Items[productionRule - 1].Text.Substring(5));
                int currentState = -1;
                for (int i = 0; i < numberToPop; i++)
                {
                    stack.Pop();
                    stack_List.Items.RemoveAt(stack_List.Items.Count - 1);
                    if (stack.Peek().Substring(0, 1) == "+" || stack.Peek().Substring(0, 1) == "*" || stack.Peek().Substring(0, 1) == "(" || stack.Peek().Substring(0, 1) == ")")
                    {
                        currentState = Int32.Parse(stack.Peek().Substring(1));
                    } else if (stack.Peek().Length == 1)
                    {
                        currentState = Int32.Parse(stack.Peek().Substring(0));
                    }
                }
                int column = columns[reduceTo];
                Debug.WriteLine("REDUCETO" + reduceTo + "CURRENTSTATE: " + currentState);
                int row = currentState + 2;
                goToState = Int32.Parse(Parse_Table.GetControlFromPosition(column, row).Text);
                stack.Push(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);
                stack_List.Items.Add(reduceTo + Parse_Table.GetControlFromPosition(column, row).Text);

                //Calculate Derivation Process
                string toReplace = grammar_List.Items[productionRule - 1].Text.Substring(5);
                toReplace = toReplace.Replace(" ", ""); //Remove spaces from rule
                prevMatchIndex -= toReplace.Length - 1;
                process = process.Remove(prevMatchIndex, toReplace.Length).Insert(prevMatchIndex, reduceTo);
                Debug.WriteLine(prevMatchIndex);
            }
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

        private void addColumns()
        {
            columns["id"] = 1;
            columns["+"] = 2;
            columns["*"] = 3;
            columns["("] = 4;
            columns[")"] = 5;
            columns["$"] = 6;
            columns["E"] = 7;
            columns["T"] = 8;
            columns["F"] = 9;
        }

        private int GetStateFromStack()
        {
            int stateFromStack = -1;
            char[] charArray = stack.ElementAt(stack.Count - 1).ToCharArray(); //Look at characters of the last item in the stack
            for (int j = charArray.Count(); j > 0; j--)
            {
                if (Char.IsDigit(charArray[j - 1]))
                {
                    if (stateFromStack != -1)
                    {
                        stateFromStack = Int32.Parse(charArray[j - 1].ToString() + stateFromStack);
                    }
                    else
                    {
                        stateFromStack = Int32.Parse(charArray[j - 1].ToString());
                    }
                }
                else
                {
                    break;
                }
            }
            return stateFromStack;
        }

        private int GetRowFromStack()
        {
            int rowFromStack = -1; //Row can never be negative, so set it as default.
            char[] charArray = stack.ElementAt(0).ToCharArray(); //Look at characters of the last item in the stack
            for (int j = charArray.Count(); j > 0; j--)
            {
                if (Char.IsDigit(charArray[j - 1]))
                {
                    if (rowFromStack != -1)
                    {
                        rowFromStack = Int32.Parse(charArray[j - 1].ToString() + rowFromStack);
                    }
                    else
                    {
                        rowFromStack = Int32.Parse(charArray[j - 1].ToString());
                    }
                }
                else
                {
                    break;
                }
            }
            return rowFromStack;
        }

        private void clearAllLists()
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
            prevMatchIndex = 0;
            steps_Result_Label.Visible = false;
            nav_Back.Visible = false;
            nav_Forward.Visible = false;
            nav_Index.Visible = false;
        }

        private void parse_Button_Click(object sender, EventArgs e)
        {
            clearAllLists();

            input = textBox1.Text;
            input = input.Replace(" ", ""); //Remove whitespaces

            derivation_Process_List.Items.Add(input);
            derivation_Process_List.Refresh();

            _process_Timer.Restart();

            stack = new Stack<string>(); //Create empty stack
            stack.Push("0"); //Where the stack begins

            stack_List.Items.Add("0");
            stack_List.Refresh();

            index = 0;
            prevIdIndex = 0;

            string pattern = @"(\+|\*|\(|\)|\$)";
            string[] matches = Regex.Split(input, pattern, RegexOptions.IgnoreCase);
            bool accepted = false;
            while (index < matches.Length)
            {
                if (matches[index] != "")
                {
                    Application.DoEvents();
                    if (matches[index] != "+" && matches[index] != "*" && matches[index] != "(" && matches[index] != "(" && matches[index] != ")" && matches[index] != "$")
                    {
                        bool acceptable = true;
                        foreach (ListViewItem prodRule in grammar_List.Items)
                        {
                            if ((prodRule.Text.Contains(matches[index]) && prodRule.Index != grammar_List.Items.Count - 1) || !Regex.IsMatch(matches[index], @"^[a-zA-Z]+$"))
                            {
                                acceptable = false;
                                break;
                            }
                        }
                        if (acceptable)
                        {
                            identifier = matches[index];
                            matches[index] = "id";
                        }
                    }
                    int rowFromStack = GetRowFromStack();
                    int row = rowFromStack + 2; //+2 to compensate for the Action/Goto and variable columns.
                    if (columns.ContainsKey(matches[index]))
                    {
                        Control control = Parse_Table.GetControlFromPosition(columns[matches[index]], row);
                        if (control != null)
                        {
                            if (!accepted)
                            {
                                string goal = control.Text.Substring(1);
                                steps.Add(control);
                                stepsColor.Add(Color.LightGreen);
                                if (control.Text.StartsWith("S"))
                                {
                                    if (matches[index] == "id" && index > 0)
                                    {   
                                        int count = 0;
                                        for (int k = prevIdIndex + 1; k < matches.Length; k++)
                                        {
                                            
                                            if (matches[k] == "+" || matches[k] == "*" || matches[k] == "(" || matches[k] == ")" || matches[k] == "$")
                                            {
                                                count++;
                                            }
                                            else if (matches[k] != "" && matches[k] != " ")
                                            {
                                                break;
                                            }
                                        }
                                        prevMatchIndex += count;
                                        prevIdIndex = index;
                                    }
                                    else
                                    {
                                        if (index > 0) 
                                        {
                                            if (matches[index - 1] == "id")
                                            {
                                                prevMatchIndex++;
                                            }
                                        }
                                    }
                                    shift(matches[index], goal);
                                }
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
                                Control state = Parse_Table.GetControlFromPosition(0, row);

                                control.BackColor = Color.LightGreen;
                                control.Refresh();

                                Thread.Sleep(500);

                                control.BackColor = DefaultBackColor;
                                control.Refresh();
                            } else //Error
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
                    }
                    else //Error
                    {
                        steps_List.Items.Add("Syntax Error").ForeColor = Color.Red;
                        _process_Timer.Stop();
                        break;
                    }
                }
                else
                {
                    index++;
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
            } else
            {
                steps_Result_Label.Text = "Expression has failed to parse due to step " + steps_List.Items.Count;
                steps_Result_Label.ForeColor = Color.Red;
            }
            currentActiveStep = 0;
            nav_Index.Text = currentActiveStep.ToString();
            steps[0].BackColor = stepsColor[0];
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
    }
}
