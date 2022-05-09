namespace Shift_Reduce_Parser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem67 = new System.Windows.Forms.ListViewItem(new string[] {
            "E -> E + T"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem68 = new System.Windows.Forms.ListViewItem(new string[] {
            "E -> T"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem69 = new System.Windows.Forms.ListViewItem(new string[] {
            "T -> T * F"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem70 = new System.Windows.Forms.ListViewItem(new string[] {
            "T -> F"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem71 = new System.Windows.Forms.ListViewItem("F -> (E)");
            System.Windows.Forms.ListViewItem listViewItem72 = new System.Windows.Forms.ListViewItem("F -> id");
            this.stack_List = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parse_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stack_Label = new System.Windows.Forms.Label();
            this.action_Label = new System.Windows.Forms.Label();
            this.action_List = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.production_Rules_Label = new System.Windows.Forms.Label();
            this.production_Rules_List = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.derivation_Process_Label = new System.Windows.Forms.Label();
            this.derivation_Process_List = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.steps_List = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.steps_Label = new System.Windows.Forms.Label();
            this.parse_Table_Label = new System.Windows.Forms.Label();
            this.grammar_Label = new System.Windows.Forms.Label();
            this.grammar_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.process_Timer = new System.Windows.Forms.Label();
            this.process_Time_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.steps_Result_Label = new System.Windows.Forms.Label();
            this.nav_Back = new System.Windows.Forms.Button();
            this.nav_Forward = new System.Windows.Forms.Button();
            this.nav_Index = new System.Windows.Forms.TextBox();
            this.parsing_Process_Group = new System.Windows.Forms.GroupBox();
            this.grammar_Key_Textbox = new System.Windows.Forms.TextBox();
            this.insert_Button = new System.Windows.Forms.Button();
            this.grammar_Rule_Textbox = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.augmented_Grammar_List = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label39 = new System.Windows.Forms.Label();
            this.lr0_Collection_Treeview = new System.Windows.Forms.TreeView();
            this.generate_Table_Button = new System.Windows.Forms.Button();
            this.parse_Table_Action = new System.Windows.Forms.Label();
            this.parse_Table_Goto = new System.Windows.Forms.Label();
            this.parse_Table_State = new System.Windows.Forms.Label();
            this.Parse_Table = new System.Windows.Forms.TableLayoutPanel();
            this.clear_Button = new System.Windows.Forms.Button();
            this.follow_List = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Grammar_Generation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parsing_Process_Group.SuspendLayout();
            this.Parse_Table.SuspendLayout();
            this.Grammar_Generation.SuspendLayout();
            this.SuspendLayout();
            // 
            // stack_List
            // 
            this.stack_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.stack_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.stack_List.HideSelection = false;
            this.stack_List.Location = new System.Drawing.Point(1514, 136);
            this.stack_List.Margin = new System.Windows.Forms.Padding(7);
            this.stack_List.Name = "stack_List";
            this.stack_List.Size = new System.Drawing.Size(310, 368);
            this.stack_List.TabIndex = 0;
            this.stack_List.UseCompatibleStateImageBehavior = false;
            this.stack_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 300;
            // 
            // parse_Button
            // 
            this.parse_Button.Location = new System.Drawing.Point(985, 38);
            this.parse_Button.Margin = new System.Windows.Forms.Padding(7);
            this.parse_Button.Name = "parse_Button";
            this.parse_Button.Size = new System.Drawing.Size(175, 51);
            this.parse_Button.TabIndex = 1;
            this.parse_Button.Text = "Parse";
            this.parse_Button.UseVisualStyleBackColor = true;
            this.parse_Button.Click += new System.EventHandler(this.parse_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(956, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter input here";
            this.textBox1.GotFocus += new System.EventHandler(this.onFocus);
            this.textBox1.LostFocus += new System.EventHandler(this.onFocusLost);
            // 
            // stack_Label
            // 
            this.stack_Label.AutoSize = true;
            this.stack_Label.Location = new System.Drawing.Point(1637, 98);
            this.stack_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.stack_Label.Name = "stack_Label";
            this.stack_Label.Size = new System.Drawing.Size(72, 29);
            this.stack_Label.TabIndex = 4;
            this.stack_Label.Text = "Stack";
            // 
            // action_Label
            // 
            this.action_Label.AutoSize = true;
            this.action_Label.Location = new System.Drawing.Point(1210, 98);
            this.action_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.action_Label.Name = "action_Label";
            this.action_Label.Size = new System.Drawing.Size(79, 29);
            this.action_Label.TabIndex = 6;
            this.action_Label.Text = "Action";
            // 
            // action_List
            // 
            this.action_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.action_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.action_List.HideSelection = false;
            this.action_List.Location = new System.Drawing.Point(1067, 138);
            this.action_List.Margin = new System.Windows.Forms.Padding(7);
            this.action_List.Name = "action_List";
            this.action_List.Size = new System.Drawing.Size(358, 366);
            this.action_List.TabIndex = 5;
            this.action_List.UseCompatibleStateImageBehavior = false;
            this.action_List.View = System.Windows.Forms.View.Details;
            // 
            // production_Rules_Label
            // 
            this.production_Rules_Label.AutoSize = true;
            this.production_Rules_Label.Location = new System.Drawing.Point(685, 98);
            this.production_Rules_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.production_Rules_Label.Name = "production_Rules_Label";
            this.production_Rules_Label.Size = new System.Drawing.Size(197, 29);
            this.production_Rules_Label.TabIndex = 8;
            this.production_Rules_Label.Text = "Production Rules";
            // 
            // production_Rules_List
            // 
            this.production_Rules_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.production_Rules_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.production_Rules_List.HideSelection = false;
            this.production_Rules_List.Location = new System.Drawing.Point(568, 134);
            this.production_Rules_List.Margin = new System.Windows.Forms.Padding(7);
            this.production_Rules_List.Name = "production_Rules_List";
            this.production_Rules_List.Size = new System.Drawing.Size(415, 368);
            this.production_Rules_List.TabIndex = 7;
            this.production_Rules_List.UseCompatibleStateImageBehavior = false;
            this.production_Rules_List.View = System.Windows.Forms.View.Details;
            // 
            // derivation_Process_Label
            // 
            this.derivation_Process_Label.AutoSize = true;
            this.derivation_Process_Label.Location = new System.Drawing.Point(145, 98);
            this.derivation_Process_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.derivation_Process_Label.Name = "derivation_Process_Label";
            this.derivation_Process_Label.Size = new System.Drawing.Size(215, 29);
            this.derivation_Process_Label.TabIndex = 10;
            this.derivation_Process_Label.Text = "Derivation Process";
            // 
            // derivation_Process_List
            // 
            this.derivation_Process_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.derivation_Process_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.derivation_Process_List.HideSelection = false;
            this.derivation_Process_List.Location = new System.Drawing.Point(7, 134);
            this.derivation_Process_List.Margin = new System.Windows.Forms.Padding(7);
            this.derivation_Process_List.Name = "derivation_Process_List";
            this.derivation_Process_List.Size = new System.Drawing.Size(494, 612);
            this.derivation_Process_List.TabIndex = 9;
            this.derivation_Process_List.UseCompatibleStateImageBehavior = false;
            this.derivation_Process_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 300;
            // 
            // steps_List
            // 
            this.steps_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.steps_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.steps_List.HideSelection = false;
            this.steps_List.Location = new System.Drawing.Point(568, 544);
            this.steps_List.Margin = new System.Windows.Forms.Padding(7);
            this.steps_List.Name = "steps_List";
            this.steps_List.Size = new System.Drawing.Size(1256, 202);
            this.steps_List.TabIndex = 11;
            this.steps_List.UseCompatibleStateImageBehavior = false;
            this.steps_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 300;
            // 
            // steps_Label
            // 
            this.steps_Label.AutoSize = true;
            this.steps_Label.Location = new System.Drawing.Point(561, 509);
            this.steps_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.steps_Label.Name = "steps_Label";
            this.steps_Label.Size = new System.Drawing.Size(75, 29);
            this.steps_Label.TabIndex = 12;
            this.steps_Label.Text = "Steps";
            // 
            // parse_Table_Label
            // 
            this.parse_Table_Label.AutoSize = true;
            this.parse_Table_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.parse_Table_Label.Location = new System.Drawing.Point(990, 45);
            this.parse_Table_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Label.Name = "parse_Table_Label";
            this.parse_Table_Label.Size = new System.Drawing.Size(145, 29);
            this.parse_Table_Label.TabIndex = 13;
            this.parse_Table_Label.Text = "Parse Table";
            // 
            // grammar_Label
            // 
            this.grammar_Label.AutoSize = true;
            this.grammar_Label.Location = new System.Drawing.Point(133, 45);
            this.grammar_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.grammar_Label.Name = "grammar_Label";
            this.grammar_Label.Size = new System.Drawing.Size(113, 29);
            this.grammar_Label.TabIndex = 15;
            this.grammar_Label.Text = "Grammar";
            // 
            // grammar_List
            // 
            this.grammar_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.grammar_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammar_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.grammar_List.HideSelection = false;
            this.grammar_List.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem67,
            listViewItem68,
            listViewItem69,
            listViewItem70,
            listViewItem71,
            listViewItem72});
            this.grammar_List.LabelWrap = false;
            this.grammar_List.Location = new System.Drawing.Point(10, 85);
            this.grammar_List.Margin = new System.Windows.Forms.Padding(7);
            this.grammar_List.MaximumSize = new System.Drawing.Size(800, 821);
            this.grammar_List.MinimumSize = new System.Drawing.Size(338, 359);
            this.grammar_List.Name = "grammar_List";
            this.grammar_List.Size = new System.Drawing.Size(338, 482);
            this.grammar_List.TabIndex = 14;
            this.grammar_List.UseCompatibleStateImageBehavior = false;
            this.grammar_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // process_Timer
            // 
            this.process_Timer.AutoSize = true;
            this.process_Timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.process_Timer.Location = new System.Drawing.Point(1624, 49);
            this.process_Timer.Name = "process_Timer";
            this.process_Timer.Size = new System.Drawing.Size(176, 31);
            this.process_Timer.TabIndex = 16;
            this.process_Timer.Text = "00:00:00.00000";
            // 
            // process_Time_Label
            // 
            this.process_Time_Label.AutoSize = true;
            this.process_Time_Label.Location = new System.Drawing.Point(1541, 49);
            this.process_Time_Label.Name = "process_Time_Label";
            this.process_Time_Label.Size = new System.Drawing.Size(69, 29);
            this.process_Time_Label.TabIndex = 17;
            this.process_Time_Label.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // steps_Result_Label
            // 
            this.steps_Result_Label.AutoSize = true;
            this.steps_Result_Label.ForeColor = System.Drawing.Color.Green;
            this.steps_Result_Label.Location = new System.Drawing.Point(753, 509);
            this.steps_Result_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.steps_Result_Label.Name = "steps_Result_Label";
            this.steps_Result_Label.Size = new System.Drawing.Size(129, 29);
            this.steps_Result_Label.TabIndex = 18;
            this.steps_Result_Label.Text = "Step Label";
            this.steps_Result_Label.Visible = false;
            // 
            // nav_Back
            // 
            this.nav_Back.AutoSize = true;
            this.nav_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav_Back.Location = new System.Drawing.Point(1374, 32);
            this.nav_Back.Name = "nav_Back";
            this.nav_Back.Size = new System.Drawing.Size(37, 39);
            this.nav_Back.TabIndex = 19;
            this.nav_Back.Text = "<";
            this.nav_Back.UseVisualStyleBackColor = true;
            this.nav_Back.Visible = false;
            this.nav_Back.Click += new System.EventHandler(this.nav_Back_Click);
            // 
            // nav_Forward
            // 
            this.nav_Forward.AutoSize = true;
            this.nav_Forward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav_Forward.Location = new System.Drawing.Point(1577, 32);
            this.nav_Forward.Name = "nav_Forward";
            this.nav_Forward.Size = new System.Drawing.Size(37, 39);
            this.nav_Forward.TabIndex = 20;
            this.nav_Forward.Text = ">";
            this.nav_Forward.UseVisualStyleBackColor = true;
            this.nav_Forward.Visible = false;
            this.nav_Forward.Click += new System.EventHandler(this.nav_Forward_Click);
            // 
            // nav_Index
            // 
            this.nav_Index.Location = new System.Drawing.Point(1429, 34);
            this.nav_Index.Name = "nav_Index";
            this.nav_Index.Size = new System.Drawing.Size(128, 35);
            this.nav_Index.TabIndex = 21;
            this.nav_Index.Text = "1";
            this.nav_Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_Index.Visible = false;
            this.nav_Index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nav_Enter);
            // 
            // parsing_Process_Group
            // 
            this.parsing_Process_Group.AutoSize = true;
            this.parsing_Process_Group.Controls.Add(this.derivation_Process_Label);
            this.parsing_Process_Group.Controls.Add(this.derivation_Process_List);
            this.parsing_Process_Group.Controls.Add(this.action_List);
            this.parsing_Process_Group.Controls.Add(this.stack_List);
            this.parsing_Process_Group.Controls.Add(this.process_Time_Label);
            this.parsing_Process_Group.Controls.Add(this.steps_Result_Label);
            this.parsing_Process_Group.Controls.Add(this.process_Timer);
            this.parsing_Process_Group.Controls.Add(this.stack_Label);
            this.parsing_Process_Group.Controls.Add(this.action_Label);
            this.parsing_Process_Group.Controls.Add(this.production_Rules_List);
            this.parsing_Process_Group.Controls.Add(this.production_Rules_Label);
            this.parsing_Process_Group.Controls.Add(this.steps_List);
            this.parsing_Process_Group.Controls.Add(this.textBox1);
            this.parsing_Process_Group.Controls.Add(this.parse_Button);
            this.parsing_Process_Group.Controls.Add(this.steps_Label);
            this.parsing_Process_Group.Location = new System.Drawing.Point(12, 714);
            this.parsing_Process_Group.Name = "parsing_Process_Group";
            this.parsing_Process_Group.Size = new System.Drawing.Size(1874, 784);
            this.parsing_Process_Group.TabIndex = 22;
            this.parsing_Process_Group.TabStop = false;
            this.parsing_Process_Group.Text = "Parsing Process";
            this.parsing_Process_Group.Visible = false;
            // 
            // grammar_Key_Textbox
            // 
            this.grammar_Key_Textbox.Location = new System.Drawing.Point(16, 37);
            this.grammar_Key_Textbox.Margin = new System.Windows.Forms.Padding(7);
            this.grammar_Key_Textbox.Name = "grammar_Key_Textbox";
            this.grammar_Key_Textbox.Size = new System.Drawing.Size(170, 35);
            this.grammar_Key_Textbox.TabIndex = 20;
            this.grammar_Key_Textbox.Text = "Enter key here";
            this.grammar_Key_Textbox.GotFocus += new System.EventHandler(this.onFocusKey);
            this.grammar_Key_Textbox.LostFocus += new System.EventHandler(this.onFocusLostKey);
            // 
            // insert_Button
            // 
            this.insert_Button.Location = new System.Drawing.Point(536, 35);
            this.insert_Button.Margin = new System.Windows.Forms.Padding(7);
            this.insert_Button.Name = "insert_Button";
            this.insert_Button.Size = new System.Drawing.Size(173, 50);
            this.insert_Button.TabIndex = 19;
            this.insert_Button.Text = "Insert";
            this.insert_Button.UseVisualStyleBackColor = true;
            this.insert_Button.Click += new System.EventHandler(this.insert_Button_Click);
            // 
            // grammar_Rule_Textbox
            // 
            this.grammar_Rule_Textbox.Location = new System.Drawing.Point(228, 37);
            this.grammar_Rule_Textbox.Margin = new System.Windows.Forms.Padding(7);
            this.grammar_Rule_Textbox.Name = "grammar_Rule_Textbox";
            this.grammar_Rule_Textbox.Size = new System.Drawing.Size(287, 35);
            this.grammar_Rule_Textbox.TabIndex = 23;
            this.grammar_Rule_Textbox.Text = "Enter rule here";
            this.grammar_Rule_Textbox.GotFocus += new System.EventHandler(this.onFocusRule);
            this.grammar_Rule_Textbox.LostFocus += new System.EventHandler(this.onFocusLostRule);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(191, 45);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 29);
            this.label37.TabIndex = 24;
            this.label37.Text = "->";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(720, 45);
            this.label38.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(186, 29);
            this.label38.TabIndex = 20;
            this.label38.Text = "LR(0) Collection";
            // 
            // augmented_Grammar_List
            // 
            this.augmented_Grammar_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.augmented_Grammar_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.augmented_Grammar_List.HideSelection = false;
            this.augmented_Grammar_List.Location = new System.Drawing.Point(356, 85);
            this.augmented_Grammar_List.Margin = new System.Windows.Forms.Padding(7);
            this.augmented_Grammar_List.Name = "augmented_Grammar_List";
            this.augmented_Grammar_List.Size = new System.Drawing.Size(270, 326);
            this.augmented_Grammar_List.TabIndex = 21;
            this.augmented_Grammar_List.UseCompatibleStateImageBehavior = false;
            this.augmented_Grammar_List.View = System.Windows.Forms.View.Details;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(384, 45);
            this.label39.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(242, 29);
            this.label39.TabIndex = 22;
            this.label39.Text = "Augmented Grammar";
            // 
            // lr0_Collection_Treeview
            // 
            this.lr0_Collection_Treeview.Location = new System.Drawing.Point(641, 85);
            this.lr0_Collection_Treeview.Name = "lr0_Collection_Treeview";
            this.lr0_Collection_Treeview.Size = new System.Drawing.Size(318, 326);
            this.lr0_Collection_Treeview.TabIndex = 25;
            // 
            // generate_Table_Button
            // 
            this.generate_Table_Button.AutoSize = true;
            this.generate_Table_Button.Location = new System.Drawing.Point(1507, 15);
            this.generate_Table_Button.Margin = new System.Windows.Forms.Padding(7);
            this.generate_Table_Button.Name = "generate_Table_Button";
            this.generate_Table_Button.Size = new System.Drawing.Size(305, 78);
            this.generate_Table_Button.TabIndex = 26;
            this.generate_Table_Button.Text = "Generate Parse Table";
            this.generate_Table_Button.UseVisualStyleBackColor = true;
            this.generate_Table_Button.Click += new System.EventHandler(this.generate_Table_Button_Click);
            // 
            // parse_Table_Action
            // 
            this.parse_Table_Action.AutoSize = true;
            this.Parse_Table.SetColumnSpan(this.parse_Table_Action, 6);
            this.parse_Table_Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Action.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parse_Table_Action.Location = new System.Drawing.Point(111, 1);
            this.parse_Table_Action.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Action.Name = "parse_Table_Action";
            this.parse_Table_Action.Size = new System.Drawing.Size(501, 33);
            this.parse_Table_Action.TabIndex = 0;
            this.parse_Table_Action.Text = "Action";
            this.parse_Table_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Goto
            // 
            this.parse_Table_Goto.AutoSize = true;
            this.Parse_Table.SetColumnSpan(this.parse_Table_Goto, 3);
            this.parse_Table_Goto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Goto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Goto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parse_Table_Goto.Location = new System.Drawing.Point(627, 1);
            this.parse_Table_Goto.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Goto.Name = "parse_Table_Goto";
            this.parse_Table_Goto.Size = new System.Drawing.Size(247, 33);
            this.parse_Table_Goto.TabIndex = 1;
            this.parse_Table_Goto.Text = "Goto";
            this.parse_Table_Goto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State
            // 
            this.parse_Table_State.AutoSize = true;
            this.parse_Table_State.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State.Location = new System.Drawing.Point(8, 35);
            this.parse_Table_State.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State.Name = "parse_Table_State";
            this.parse_Table_State.Size = new System.Drawing.Size(88, 33);
            this.parse_Table_State.TabIndex = 2;
            this.parse_Table_State.Text = "State";
            this.parse_Table_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table
            // 
            this.Parse_Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Parse_Table.ColumnCount = 10;
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.Parse_Table.Controls.Add(this.parse_Table_State, 0, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Goto, 7, 0);
            this.Parse_Table.Controls.Add(this.parse_Table_Action, 1, 0);
            this.Parse_Table.Location = new System.Drawing.Point(982, 85);
            this.Parse_Table.Margin = new System.Windows.Forms.Padding(7);
            this.Parse_Table.Name = "Parse_Table";
            this.Parse_Table.RowCount = 14;
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.Parse_Table.Size = new System.Drawing.Size(882, 486);
            this.Parse_Table.TabIndex = 3;
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(723, 35);
            this.clear_Button.Margin = new System.Windows.Forms.Padding(7);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(164, 50);
            this.clear_Button.TabIndex = 27;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // follow_List
            // 
            this.follow_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.follow_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.follow_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.follow_List.HideSelection = false;
            this.follow_List.LabelWrap = false;
            this.follow_List.Location = new System.Drawing.Point(356, 453);
            this.follow_List.Margin = new System.Windows.Forms.Padding(7);
            this.follow_List.Name = "follow_List";
            this.follow_List.Size = new System.Drawing.Size(603, 113);
            this.follow_List.TabIndex = 28;
            this.follow_List.UseCompatibleStateImageBehavior = false;
            this.follow_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Follow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grammar_Generation
            // 
            this.Grammar_Generation.AutoSize = true;
            this.Grammar_Generation.Controls.Add(this.follow_List);
            this.Grammar_Generation.Controls.Add(this.lr0_Collection_Treeview);
            this.Grammar_Generation.Controls.Add(this.label1);
            this.Grammar_Generation.Controls.Add(this.Parse_Table);
            this.Grammar_Generation.Controls.Add(this.parse_Table_Label);
            this.Grammar_Generation.Controls.Add(this.grammar_List);
            this.Grammar_Generation.Controls.Add(this.grammar_Label);
            this.Grammar_Generation.Controls.Add(this.label38);
            this.Grammar_Generation.Controls.Add(this.nav_Back);
            this.Grammar_Generation.Controls.Add(this.nav_Forward);
            this.Grammar_Generation.Controls.Add(this.augmented_Grammar_List);
            this.Grammar_Generation.Controls.Add(this.nav_Index);
            this.Grammar_Generation.Controls.Add(this.label39);
            this.Grammar_Generation.Location = new System.Drawing.Point(12, 103);
            this.Grammar_Generation.Name = "Grammar_Generation";
            this.Grammar_Generation.Size = new System.Drawing.Size(1874, 609);
            this.Grammar_Generation.TabIndex = 30;
            this.Grammar_Generation.TabStop = false;
            this.Grammar_Generation.Text = "Grammar Generation";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 1503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1892, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "created by Logan Reid";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1892, 1538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grammar_Generation);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.generate_Table_Button);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.grammar_Rule_Textbox);
            this.Controls.Add(this.grammar_Key_Textbox);
            this.Controls.Add(this.insert_Button);
            this.Controls.Add(this.parsing_Process_Group);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shift-Reduce Parser (Logan Reid)";
            this.parsing_Process_Group.ResumeLayout(false);
            this.parsing_Process_Group.PerformLayout();
            this.Parse_Table.ResumeLayout(false);
            this.Parse_Table.PerformLayout();
            this.Grammar_Generation.ResumeLayout(false);
            this.Grammar_Generation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView stack_List;
        private System.Windows.Forms.Button parse_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label stack_Label;
        private System.Windows.Forms.Label action_Label;
        private System.Windows.Forms.ListView action_List;
        private System.Windows.Forms.Label production_Rules_Label;
        private System.Windows.Forms.ListView production_Rules_List;
        private System.Windows.Forms.Label derivation_Process_Label;
        private System.Windows.Forms.ListView derivation_Process_List;
        private System.Windows.Forms.ListView steps_List;
        private System.Windows.Forms.Label steps_Label;
        private System.Windows.Forms.Label parse_Table_Label;
        private System.Windows.Forms.Label grammar_Label;
        private System.Windows.Forms.ListView grammar_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label process_Timer;
        private System.Windows.Forms.Label process_Time_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label steps_Result_Label;
        private System.Windows.Forms.Button nav_Back;
        private System.Windows.Forms.Button nav_Forward;
        private System.Windows.Forms.TextBox nav_Index;
        private System.Windows.Forms.GroupBox parsing_Process_Group;
        private System.Windows.Forms.TextBox grammar_Key_Textbox;
        private System.Windows.Forms.Button insert_Button;
        private System.Windows.Forms.TextBox grammar_Rule_Textbox;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ListView augmented_Grammar_List;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TreeView lr0_Collection_Treeview;
        private System.Windows.Forms.Button generate_Table_Button;
        private System.Windows.Forms.Label parse_Table_Action;
        private System.Windows.Forms.TableLayoutPanel Parse_Table;
        private System.Windows.Forms.Label parse_Table_State;
        private System.Windows.Forms.Label parse_Table_Goto;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.ListView follow_List;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grammar_Generation;
        private System.Windows.Forms.Label label2;
    }
}

