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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "E -> E + T"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "E -> T"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "T -> T * F"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "T -> F"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("F -> (E)");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("F -> id");
            this.stack_List = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parse_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Parse_Table = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parse_Table_State9_Plus_R1 = new System.Windows.Forms.Label();
            this.parse_Table_State8_Plus_S6 = new System.Windows.Forms.Label();
            this.parse_Table_State5_Plus_R6 = new System.Windows.Forms.Label();
            this.parse_Table_State3_Plus_R4 = new System.Windows.Forms.Label();
            this.parse_Table_State2_Plus_R2 = new System.Windows.Forms.Label();
            this.parse_Table_State1_Plus_S6 = new System.Windows.Forms.Label();
            this.parse_Table_State2 = new System.Windows.Forms.Label();
            this.parse_Table_State7_id_S5 = new System.Windows.Forms.Label();
            this.parse_Table_State6_id_S5 = new System.Windows.Forms.Label();
            this.parse_Table_State4_id_S5 = new System.Windows.Forms.Label();
            this.parse_Table_State0_id_S5 = new System.Windows.Forms.Label();
            this.parse_Table_F = new System.Windows.Forms.Label();
            this.parse_Table_T = new System.Windows.Forms.Label();
            this.parse_Table_E = new System.Windows.Forms.Label();
            this.parse_Table_Dol = new System.Windows.Forms.Label();
            this.parse_Table_CPar = new System.Windows.Forms.Label();
            this.parse_Table_OPar = new System.Windows.Forms.Label();
            this.parse_Table_Mult = new System.Windows.Forms.Label();
            this.parse_Table_Plus = new System.Windows.Forms.Label();
            this.parse_Table_Id = new System.Windows.Forms.Label();
            this.Parse_Table_State11 = new System.Windows.Forms.Label();
            this.Parse_Table_State10 = new System.Windows.Forms.Label();
            this.Parse_Table_State9 = new System.Windows.Forms.Label();
            this.Parse_Table_State8 = new System.Windows.Forms.Label();
            this.Parse_Table_State7 = new System.Windows.Forms.Label();
            this.Parse_Table_State6 = new System.Windows.Forms.Label();
            this.Parse_Table_State5 = new System.Windows.Forms.Label();
            this.Parse_Table_State4 = new System.Windows.Forms.Label();
            this.Parse_Table_State3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Parse_Table_State0 = new System.Windows.Forms.Label();
            this.parse_Table_State = new System.Windows.Forms.Label();
            this.parse_Table_Goto = new System.Windows.Forms.Label();
            this.parse_Table_Action = new System.Windows.Forms.Label();
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
            this.Parse_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // stack_List
            // 
            this.stack_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.stack_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.stack_List.HideSelection = false;
            this.stack_List.Location = new System.Drawing.Point(1386, 163);
            this.stack_List.Margin = new System.Windows.Forms.Padding(7);
            this.stack_List.Name = "stack_List";
            this.stack_List.Size = new System.Drawing.Size(277, 359);
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
            this.parse_Button.Location = new System.Drawing.Point(1003, 51);
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
            this.textBox1.Location = new System.Drawing.Point(28, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(956, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter input here";
            this.textBox1.GotFocus += new System.EventHandler(this.onFocus);
            this.textBox1.LostFocus += new System.EventHandler(this.onFocusLost);
            // 
            // Parse_Table
            // 
            this.Parse_Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Parse_Table.ColumnCount = 10;
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Parse_Table.Controls.Add(this.label36, 9, 9);
            this.Parse_Table.Controls.Add(this.label35, 8, 8);
            this.Parse_Table.Controls.Add(this.label34, 9, 8);
            this.Parse_Table.Controls.Add(this.label33, 9, 6);
            this.Parse_Table.Controls.Add(this.label32, 8, 6);
            this.Parse_Table.Controls.Add(this.label31, 9, 2);
            this.Parse_Table.Controls.Add(this.label30, 8, 2);
            this.Parse_Table.Controls.Add(this.label29, 7, 6);
            this.Parse_Table.Controls.Add(this.label28, 7, 2);
            this.Parse_Table.Controls.Add(this.label27, 6, 3);
            this.Parse_Table.Controls.Add(this.label26, 6, 4);
            this.Parse_Table.Controls.Add(this.label25, 6, 5);
            this.Parse_Table.Controls.Add(this.label24, 6, 7);
            this.Parse_Table.Controls.Add(this.label23, 3, 13);
            this.Parse_Table.Controls.Add(this.label22, 3, 12);
            this.Parse_Table.Controls.Add(this.label21, 3, 11);
            this.Parse_Table.Controls.Add(this.label20, 6, 13);
            this.Parse_Table.Controls.Add(this.label19, 6, 12);
            this.Parse_Table.Controls.Add(this.label18, 6, 11);
            this.Parse_Table.Controls.Add(this.label17, 5, 13);
            this.Parse_Table.Controls.Add(this.label16, 5, 12);
            this.Parse_Table.Controls.Add(this.label15, 5, 11);
            this.Parse_Table.Controls.Add(this.label14, 5, 10);
            this.Parse_Table.Controls.Add(this.label13, 5, 7);
            this.Parse_Table.Controls.Add(this.label12, 5, 5);
            this.Parse_Table.Controls.Add(this.label11, 5, 4);
            this.Parse_Table.Controls.Add(this.label10, 4, 9);
            this.Parse_Table.Controls.Add(this.label9, 4, 8);
            this.Parse_Table.Controls.Add(this.label8, 4, 6);
            this.Parse_Table.Controls.Add(this.label7, 4, 2);
            this.Parse_Table.Controls.Add(this.label6, 3, 7);
            this.Parse_Table.Controls.Add(this.label5, 3, 5);
            this.Parse_Table.Controls.Add(this.label4, 3, 4);
            this.Parse_Table.Controls.Add(this.label3, 2, 13);
            this.Parse_Table.Controls.Add(this.label1, 2, 12);
            this.Parse_Table.Controls.Add(this.parse_Table_State9_Plus_R1, 2, 11);
            this.Parse_Table.Controls.Add(this.parse_Table_State8_Plus_S6, 2, 10);
            this.Parse_Table.Controls.Add(this.parse_Table_State5_Plus_R6, 2, 7);
            this.Parse_Table.Controls.Add(this.parse_Table_State3_Plus_R4, 2, 5);
            this.Parse_Table.Controls.Add(this.parse_Table_State2_Plus_R2, 2, 4);
            this.Parse_Table.Controls.Add(this.parse_Table_State1_Plus_S6, 2, 3);
            this.Parse_Table.Controls.Add(this.parse_Table_State2, 0, 4);
            this.Parse_Table.Controls.Add(this.parse_Table_State7_id_S5, 1, 9);
            this.Parse_Table.Controls.Add(this.parse_Table_State6_id_S5, 1, 8);
            this.Parse_Table.Controls.Add(this.parse_Table_State4_id_S5, 1, 6);
            this.Parse_Table.Controls.Add(this.parse_Table_State0_id_S5, 1, 2);
            this.Parse_Table.Controls.Add(this.parse_Table_F, 9, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_T, 8, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_E, 7, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Dol, 6, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_CPar, 5, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_OPar, 4, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Mult, 3, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Plus, 2, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Id, 1, 1);
            this.Parse_Table.Controls.Add(this.Parse_Table_State11, 0, 13);
            this.Parse_Table.Controls.Add(this.Parse_Table_State10, 0, 12);
            this.Parse_Table.Controls.Add(this.Parse_Table_State9, 0, 11);
            this.Parse_Table.Controls.Add(this.Parse_Table_State8, 0, 10);
            this.Parse_Table.Controls.Add(this.Parse_Table_State7, 0, 9);
            this.Parse_Table.Controls.Add(this.Parse_Table_State6, 0, 8);
            this.Parse_Table.Controls.Add(this.Parse_Table_State5, 0, 7);
            this.Parse_Table.Controls.Add(this.Parse_Table_State4, 0, 6);
            this.Parse_Table.Controls.Add(this.Parse_Table_State3, 0, 5);
            this.Parse_Table.Controls.Add(this.label2, 0, 3);
            this.Parse_Table.Controls.Add(this.Parse_Table_State0, 0, 2);
            this.Parse_Table.Controls.Add(this.parse_Table_State, 0, 1);
            this.Parse_Table.Controls.Add(this.parse_Table_Goto, 7, 0);
            this.Parse_Table.Controls.Add(this.parse_Table_Action, 1, 0);
            this.Parse_Table.Location = new System.Drawing.Point(740, 825);
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
            this.Parse_Table.Size = new System.Drawing.Size(912, 431);
            this.Parse_Table.TabIndex = 3;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(827, 271);
            this.label36.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 29);
            this.label36.TabIndex = 68;
            this.label36.Text = "10";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(736, 241);
            this.label35.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(76, 29);
            this.label35.TabIndex = 67;
            this.label35.Text = "9";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(827, 241);
            this.label34.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(77, 29);
            this.label34.TabIndex = 66;
            this.label34.Text = "3";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(827, 181);
            this.label33.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 29);
            this.label33.TabIndex = 65;
            this.label33.Text = "3";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(736, 181);
            this.label32.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 29);
            this.label32.TabIndex = 64;
            this.label32.Text = "2";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(827, 61);
            this.label31.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 29);
            this.label31.TabIndex = 63;
            this.label31.Text = "3";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(736, 61);
            this.label30.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 29);
            this.label30.TabIndex = 62;
            this.label30.Text = "2";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(645, 181);
            this.label29.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 29);
            this.label29.TabIndex = 61;
            this.label29.Text = "8";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(645, 61);
            this.label28.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 29);
            this.label28.TabIndex = 60;
            this.label28.Text = "1";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(554, 91);
            this.label27.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 29);
            this.label27.TabIndex = 59;
            this.label27.Text = "accept";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(554, 121);
            this.label26.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 29);
            this.label26.TabIndex = 58;
            this.label26.Text = "R2";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(554, 151);
            this.label25.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 29);
            this.label25.TabIndex = 57;
            this.label25.Text = "R4";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(554, 211);
            this.label24.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 29);
            this.label24.TabIndex = 56;
            this.label24.Text = "R6";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(281, 391);
            this.label23.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 39);
            this.label23.TabIndex = 55;
            this.label23.Text = "R5";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(281, 361);
            this.label22.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 29);
            this.label22.TabIndex = 54;
            this.label22.Text = "R3";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(281, 331);
            this.label21.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 29);
            this.label21.TabIndex = 53;
            this.label21.Text = "S7";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(554, 391);
            this.label20.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 39);
            this.label20.TabIndex = 52;
            this.label20.Text = "R5";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(554, 361);
            this.label19.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 29);
            this.label19.TabIndex = 51;
            this.label19.Text = "R3";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(554, 331);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 29);
            this.label18.TabIndex = 50;
            this.label18.Text = "R1";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(463, 391);
            this.label17.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 39);
            this.label17.TabIndex = 49;
            this.label17.Text = "R5";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(463, 361);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 29);
            this.label16.TabIndex = 48;
            this.label16.Text = "R3";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(463, 331);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 29);
            this.label15.TabIndex = 47;
            this.label15.Text = "R1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(463, 301);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 29);
            this.label14.TabIndex = 46;
            this.label14.Text = "S11";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(463, 211);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 29);
            this.label13.TabIndex = 45;
            this.label13.Text = "R6";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(463, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 29);
            this.label12.TabIndex = 44;
            this.label12.Text = "R4";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 29);
            this.label11.TabIndex = 43;
            this.label11.Text = "R2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "S4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "S4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "S4";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "S4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "R6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "R4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "S7";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 39);
            this.label3.TabIndex = 35;
            this.label3.Text = "R5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "R3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State9_Plus_R1
            // 
            this.parse_Table_State9_Plus_R1.AutoSize = true;
            this.parse_Table_State9_Plus_R1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State9_Plus_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State9_Plus_R1.Location = new System.Drawing.Point(190, 331);
            this.parse_Table_State9_Plus_R1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State9_Plus_R1.Name = "parse_Table_State9_Plus_R1";
            this.parse_Table_State9_Plus_R1.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State9_Plus_R1.TabIndex = 33;
            this.parse_Table_State9_Plus_R1.Text = "R1";
            this.parse_Table_State9_Plus_R1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State8_Plus_S6
            // 
            this.parse_Table_State8_Plus_S6.AutoSize = true;
            this.parse_Table_State8_Plus_S6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State8_Plus_S6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State8_Plus_S6.Location = new System.Drawing.Point(190, 301);
            this.parse_Table_State8_Plus_S6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State8_Plus_S6.Name = "parse_Table_State8_Plus_S6";
            this.parse_Table_State8_Plus_S6.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State8_Plus_S6.TabIndex = 32;
            this.parse_Table_State8_Plus_S6.Text = "S6";
            this.parse_Table_State8_Plus_S6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State5_Plus_R6
            // 
            this.parse_Table_State5_Plus_R6.AutoSize = true;
            this.parse_Table_State5_Plus_R6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State5_Plus_R6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State5_Plus_R6.Location = new System.Drawing.Point(190, 211);
            this.parse_Table_State5_Plus_R6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State5_Plus_R6.Name = "parse_Table_State5_Plus_R6";
            this.parse_Table_State5_Plus_R6.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State5_Plus_R6.TabIndex = 31;
            this.parse_Table_State5_Plus_R6.Text = "R6";
            this.parse_Table_State5_Plus_R6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State3_Plus_R4
            // 
            this.parse_Table_State3_Plus_R4.AutoSize = true;
            this.parse_Table_State3_Plus_R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State3_Plus_R4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State3_Plus_R4.Location = new System.Drawing.Point(190, 151);
            this.parse_Table_State3_Plus_R4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State3_Plus_R4.Name = "parse_Table_State3_Plus_R4";
            this.parse_Table_State3_Plus_R4.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State3_Plus_R4.TabIndex = 30;
            this.parse_Table_State3_Plus_R4.Text = "R4";
            this.parse_Table_State3_Plus_R4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State2_Plus_R2
            // 
            this.parse_Table_State2_Plus_R2.AutoSize = true;
            this.parse_Table_State2_Plus_R2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State2_Plus_R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State2_Plus_R2.Location = new System.Drawing.Point(190, 121);
            this.parse_Table_State2_Plus_R2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State2_Plus_R2.Name = "parse_Table_State2_Plus_R2";
            this.parse_Table_State2_Plus_R2.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State2_Plus_R2.TabIndex = 29;
            this.parse_Table_State2_Plus_R2.Text = "R2";
            this.parse_Table_State2_Plus_R2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State1_Plus_S6
            // 
            this.parse_Table_State1_Plus_S6.AutoSize = true;
            this.parse_Table_State1_Plus_S6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State1_Plus_S6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State1_Plus_S6.Location = new System.Drawing.Point(190, 91);
            this.parse_Table_State1_Plus_S6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State1_Plus_S6.Name = "parse_Table_State1_Plus_S6";
            this.parse_Table_State1_Plus_S6.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State1_Plus_S6.TabIndex = 28;
            this.parse_Table_State1_Plus_S6.Text = "S6";
            this.parse_Table_State1_Plus_S6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State2
            // 
            this.parse_Table_State2.AutoSize = true;
            this.parse_Table_State2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State2.Location = new System.Drawing.Point(8, 121);
            this.parse_Table_State2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State2.Name = "parse_Table_State2";
            this.parse_Table_State2.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State2.TabIndex = 27;
            this.parse_Table_State2.Text = "2";
            this.parse_Table_State2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State7_id_S5
            // 
            this.parse_Table_State7_id_S5.AutoSize = true;
            this.parse_Table_State7_id_S5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State7_id_S5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State7_id_S5.Location = new System.Drawing.Point(99, 271);
            this.parse_Table_State7_id_S5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State7_id_S5.Name = "parse_Table_State7_id_S5";
            this.parse_Table_State7_id_S5.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State7_id_S5.TabIndex = 26;
            this.parse_Table_State7_id_S5.Text = "S5";
            this.parse_Table_State7_id_S5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State6_id_S5
            // 
            this.parse_Table_State6_id_S5.AutoSize = true;
            this.parse_Table_State6_id_S5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State6_id_S5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State6_id_S5.Location = new System.Drawing.Point(99, 241);
            this.parse_Table_State6_id_S5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State6_id_S5.Name = "parse_Table_State6_id_S5";
            this.parse_Table_State6_id_S5.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State6_id_S5.TabIndex = 25;
            this.parse_Table_State6_id_S5.Text = "S5";
            this.parse_Table_State6_id_S5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State4_id_S5
            // 
            this.parse_Table_State4_id_S5.AutoSize = true;
            this.parse_Table_State4_id_S5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State4_id_S5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State4_id_S5.Location = new System.Drawing.Point(99, 181);
            this.parse_Table_State4_id_S5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State4_id_S5.Name = "parse_Table_State4_id_S5";
            this.parse_Table_State4_id_S5.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State4_id_S5.TabIndex = 24;
            this.parse_Table_State4_id_S5.Text = "S5";
            this.parse_Table_State4_id_S5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State0_id_S5
            // 
            this.parse_Table_State0_id_S5.AutoSize = true;
            this.parse_Table_State0_id_S5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State0_id_S5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State0_id_S5.Location = new System.Drawing.Point(99, 61);
            this.parse_Table_State0_id_S5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State0_id_S5.Name = "parse_Table_State0_id_S5";
            this.parse_Table_State0_id_S5.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State0_id_S5.TabIndex = 23;
            this.parse_Table_State0_id_S5.Text = "S5";
            this.parse_Table_State0_id_S5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_F
            // 
            this.parse_Table_F.AutoSize = true;
            this.parse_Table_F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_F.Location = new System.Drawing.Point(827, 31);
            this.parse_Table_F.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_F.Name = "parse_Table_F";
            this.parse_Table_F.Size = new System.Drawing.Size(77, 29);
            this.parse_Table_F.TabIndex = 22;
            this.parse_Table_F.Text = "F";
            this.parse_Table_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_T
            // 
            this.parse_Table_T.AutoSize = true;
            this.parse_Table_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_T.Location = new System.Drawing.Point(736, 31);
            this.parse_Table_T.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_T.Name = "parse_Table_T";
            this.parse_Table_T.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_T.TabIndex = 21;
            this.parse_Table_T.Text = "T";
            this.parse_Table_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_E
            // 
            this.parse_Table_E.AutoSize = true;
            this.parse_Table_E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_E.Location = new System.Drawing.Point(645, 31);
            this.parse_Table_E.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_E.Name = "parse_Table_E";
            this.parse_Table_E.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_E.TabIndex = 20;
            this.parse_Table_E.Text = "E";
            this.parse_Table_E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Dol
            // 
            this.parse_Table_Dol.AutoSize = true;
            this.parse_Table_Dol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Dol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Dol.Location = new System.Drawing.Point(554, 31);
            this.parse_Table_Dol.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Dol.Name = "parse_Table_Dol";
            this.parse_Table_Dol.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_Dol.TabIndex = 19;
            this.parse_Table_Dol.Text = "$";
            this.parse_Table_Dol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_CPar
            // 
            this.parse_Table_CPar.AutoSize = true;
            this.parse_Table_CPar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_CPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_CPar.Location = new System.Drawing.Point(463, 31);
            this.parse_Table_CPar.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_CPar.Name = "parse_Table_CPar";
            this.parse_Table_CPar.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_CPar.TabIndex = 18;
            this.parse_Table_CPar.Text = ")";
            this.parse_Table_CPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_OPar
            // 
            this.parse_Table_OPar.AutoSize = true;
            this.parse_Table_OPar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_OPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_OPar.Location = new System.Drawing.Point(372, 31);
            this.parse_Table_OPar.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_OPar.Name = "parse_Table_OPar";
            this.parse_Table_OPar.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_OPar.TabIndex = 17;
            this.parse_Table_OPar.Text = "(";
            this.parse_Table_OPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Mult
            // 
            this.parse_Table_Mult.AutoSize = true;
            this.parse_Table_Mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Mult.Location = new System.Drawing.Point(281, 31);
            this.parse_Table_Mult.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Mult.Name = "parse_Table_Mult";
            this.parse_Table_Mult.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_Mult.TabIndex = 16;
            this.parse_Table_Mult.Text = "*";
            this.parse_Table_Mult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Plus
            // 
            this.parse_Table_Plus.AutoSize = true;
            this.parse_Table_Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Plus.Location = new System.Drawing.Point(190, 31);
            this.parse_Table_Plus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Plus.Name = "parse_Table_Plus";
            this.parse_Table_Plus.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_Plus.TabIndex = 15;
            this.parse_Table_Plus.Text = "+";
            this.parse_Table_Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Id
            // 
            this.parse_Table_Id.AutoSize = true;
            this.parse_Table_Id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Id.Location = new System.Drawing.Point(99, 31);
            this.parse_Table_Id.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Id.Name = "parse_Table_Id";
            this.parse_Table_Id.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_Id.TabIndex = 14;
            this.parse_Table_Id.Text = "id";
            this.parse_Table_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State11
            // 
            this.Parse_Table_State11.AutoSize = true;
            this.Parse_Table_State11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State11.Location = new System.Drawing.Point(8, 391);
            this.Parse_Table_State11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State11.Name = "Parse_Table_State11";
            this.Parse_Table_State11.Size = new System.Drawing.Size(76, 39);
            this.Parse_Table_State11.TabIndex = 13;
            this.Parse_Table_State11.Text = "11";
            this.Parse_Table_State11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State10
            // 
            this.Parse_Table_State10.AutoSize = true;
            this.Parse_Table_State10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State10.Location = new System.Drawing.Point(8, 361);
            this.Parse_Table_State10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State10.Name = "Parse_Table_State10";
            this.Parse_Table_State10.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State10.TabIndex = 12;
            this.Parse_Table_State10.Text = "10";
            this.Parse_Table_State10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State9
            // 
            this.Parse_Table_State9.AutoSize = true;
            this.Parse_Table_State9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State9.Location = new System.Drawing.Point(8, 331);
            this.Parse_Table_State9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State9.Name = "Parse_Table_State9";
            this.Parse_Table_State9.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State9.TabIndex = 11;
            this.Parse_Table_State9.Text = "9";
            this.Parse_Table_State9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State8
            // 
            this.Parse_Table_State8.AutoSize = true;
            this.Parse_Table_State8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State8.Location = new System.Drawing.Point(8, 301);
            this.Parse_Table_State8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State8.Name = "Parse_Table_State8";
            this.Parse_Table_State8.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State8.TabIndex = 10;
            this.Parse_Table_State8.Text = "8";
            this.Parse_Table_State8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State7
            // 
            this.Parse_Table_State7.AutoSize = true;
            this.Parse_Table_State7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State7.Location = new System.Drawing.Point(8, 271);
            this.Parse_Table_State7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State7.Name = "Parse_Table_State7";
            this.Parse_Table_State7.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State7.TabIndex = 9;
            this.Parse_Table_State7.Text = "7";
            this.Parse_Table_State7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State6
            // 
            this.Parse_Table_State6.AutoSize = true;
            this.Parse_Table_State6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State6.Location = new System.Drawing.Point(8, 241);
            this.Parse_Table_State6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State6.Name = "Parse_Table_State6";
            this.Parse_Table_State6.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State6.TabIndex = 8;
            this.Parse_Table_State6.Text = "6";
            this.Parse_Table_State6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State5
            // 
            this.Parse_Table_State5.AutoSize = true;
            this.Parse_Table_State5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State5.Location = new System.Drawing.Point(8, 211);
            this.Parse_Table_State5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State5.Name = "Parse_Table_State5";
            this.Parse_Table_State5.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State5.TabIndex = 7;
            this.Parse_Table_State5.Text = "5";
            this.Parse_Table_State5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State4
            // 
            this.Parse_Table_State4.AutoSize = true;
            this.Parse_Table_State4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State4.Location = new System.Drawing.Point(8, 181);
            this.Parse_Table_State4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State4.Name = "Parse_Table_State4";
            this.Parse_Table_State4.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State4.TabIndex = 6;
            this.Parse_Table_State4.Text = "4";
            this.Parse_Table_State4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State3
            // 
            this.Parse_Table_State3.AutoSize = true;
            this.Parse_Table_State3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State3.Location = new System.Drawing.Point(8, 151);
            this.Parse_Table_State3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State3.Name = "Parse_Table_State3";
            this.Parse_Table_State3.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State3.TabIndex = 5;
            this.Parse_Table_State3.Text = "3";
            this.Parse_Table_State3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parse_Table_State0
            // 
            this.Parse_Table_State0.AutoSize = true;
            this.Parse_Table_State0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parse_Table_State0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse_Table_State0.Location = new System.Drawing.Point(8, 61);
            this.Parse_Table_State0.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Parse_Table_State0.Name = "Parse_Table_State0";
            this.Parse_Table_State0.Size = new System.Drawing.Size(76, 29);
            this.Parse_Table_State0.TabIndex = 3;
            this.Parse_Table_State0.Text = "0";
            this.Parse_Table_State0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_State
            // 
            this.parse_Table_State.AutoSize = true;
            this.parse_Table_State.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_State.Location = new System.Drawing.Point(8, 31);
            this.parse_Table_State.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_State.Name = "parse_Table_State";
            this.parse_Table_State.Size = new System.Drawing.Size(76, 29);
            this.parse_Table_State.TabIndex = 2;
            this.parse_Table_State.Text = "State";
            this.parse_Table_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Goto
            // 
            this.parse_Table_Goto.AutoSize = true;
            this.Parse_Table.SetColumnSpan(this.parse_Table_Goto, 3);
            this.parse_Table_Goto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Goto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Goto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parse_Table_Goto.Location = new System.Drawing.Point(645, 1);
            this.parse_Table_Goto.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Goto.Name = "parse_Table_Goto";
            this.parse_Table_Goto.Size = new System.Drawing.Size(259, 29);
            this.parse_Table_Goto.TabIndex = 1;
            this.parse_Table_Goto.Text = "Goto";
            this.parse_Table_Goto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parse_Table_Action
            // 
            this.parse_Table_Action.AutoSize = true;
            this.Parse_Table.SetColumnSpan(this.parse_Table_Action, 6);
            this.parse_Table_Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parse_Table_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_Table_Action.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parse_Table_Action.Location = new System.Drawing.Point(99, 1);
            this.parse_Table_Action.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Action.Name = "parse_Table_Action";
            this.parse_Table_Action.Size = new System.Drawing.Size(531, 29);
            this.parse_Table_Action.TabIndex = 0;
            this.parse_Table_Action.Text = "Action";
            this.parse_Table_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stack_Label
            // 
            this.stack_Label.AutoSize = true;
            this.stack_Label.Location = new System.Drawing.Point(1484, 127);
            this.stack_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.stack_Label.Name = "stack_Label";
            this.stack_Label.Size = new System.Drawing.Size(72, 29);
            this.stack_Label.TabIndex = 4;
            this.stack_Label.Text = "Stack";
            // 
            // action_Label
            // 
            this.action_Label.AutoSize = true;
            this.action_Label.Location = new System.Drawing.Point(1101, 127);
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
            this.action_List.Location = new System.Drawing.Point(1003, 163);
            this.action_List.Margin = new System.Windows.Forms.Padding(7);
            this.action_List.Name = "action_List";
            this.action_List.Size = new System.Drawing.Size(277, 359);
            this.action_List.TabIndex = 5;
            this.action_List.UseCompatibleStateImageBehavior = false;
            this.action_List.View = System.Windows.Forms.View.Details;
            // 
            // production_Rules_Label
            // 
            this.production_Rules_Label.AutoSize = true;
            this.production_Rules_Label.Location = new System.Drawing.Point(646, 127);
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
            this.production_Rules_List.Location = new System.Drawing.Point(583, 163);
            this.production_Rules_List.Margin = new System.Windows.Forms.Padding(7);
            this.production_Rules_List.Name = "production_Rules_List";
            this.production_Rules_List.Size = new System.Drawing.Size(319, 359);
            this.production_Rules_List.TabIndex = 7;
            this.production_Rules_List.UseCompatibleStateImageBehavior = false;
            this.production_Rules_List.View = System.Windows.Forms.View.Details;
            // 
            // derivation_Process_Label
            // 
            this.derivation_Process_Label.AutoSize = true;
            this.derivation_Process_Label.Location = new System.Drawing.Point(166, 127);
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
            this.derivation_Process_List.Location = new System.Drawing.Point(28, 163);
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
            this.steps_List.Location = new System.Drawing.Point(583, 573);
            this.steps_List.Margin = new System.Windows.Forms.Padding(7);
            this.steps_List.Name = "steps_List";
            this.steps_List.Size = new System.Drawing.Size(1080, 202);
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
            this.steps_Label.Location = new System.Drawing.Point(576, 538);
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
            this.parse_Table_Label.Location = new System.Drawing.Point(1136, 790);
            this.parse_Table_Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.parse_Table_Label.Name = "parse_Table_Label";
            this.parse_Table_Label.Size = new System.Drawing.Size(145, 29);
            this.parse_Table_Label.TabIndex = 13;
            this.parse_Table_Label.Text = "Parse Table";
            // 
            // grammar_Label
            // 
            this.grammar_Label.AutoSize = true;
            this.grammar_Label.Location = new System.Drawing.Point(275, 861);
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
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.grammar_List.LabelWrap = false;
            this.grammar_List.Location = new System.Drawing.Point(26, 897);
            this.grammar_List.Margin = new System.Windows.Forms.Padding(7);
            this.grammar_List.Name = "grammar_List";
            this.grammar_List.Size = new System.Drawing.Size(622, 359);
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
            this.process_Timer.Location = new System.Drawing.Point(1464, 62);
            this.process_Timer.Name = "process_Timer";
            this.process_Timer.Size = new System.Drawing.Size(176, 31);
            this.process_Timer.TabIndex = 16;
            this.process_Timer.Text = "00:00:00.00000";
            // 
            // process_Time_Label
            // 
            this.process_Time_Label.AutoSize = true;
            this.process_Time_Label.Location = new System.Drawing.Point(1381, 62);
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
            this.steps_Result_Label.Location = new System.Drawing.Point(768, 538);
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
            this.nav_Back.Location = new System.Drawing.Point(1337, 780);
            this.nav_Back.Name = "nav_Back";
            this.nav_Back.Size = new System.Drawing.Size(54, 39);
            this.nav_Back.TabIndex = 19;
            this.nav_Back.Text = "<";
            this.nav_Back.UseVisualStyleBackColor = true;
            this.nav_Back.Visible = false;
            this.nav_Back.Click += new System.EventHandler(this.nav_Back_Click);
            // 
            // nav_Forward
            // 
            this.nav_Forward.AutoSize = true;
            this.nav_Forward.Location = new System.Drawing.Point(1540, 780);
            this.nav_Forward.Name = "nav_Forward";
            this.nav_Forward.Size = new System.Drawing.Size(54, 39);
            this.nav_Forward.TabIndex = 20;
            this.nav_Forward.Text = ">";
            this.nav_Forward.UseVisualStyleBackColor = true;
            this.nav_Forward.Visible = false;
            this.nav_Forward.Click += new System.EventHandler(this.nav_Forward_Click);
            // 
            // nav_Index
            // 
            this.nav_Index.Location = new System.Drawing.Point(1417, 782);
            this.nav_Index.Name = "nav_Index";
            this.nav_Index.Size = new System.Drawing.Size(100, 35);
            this.nav_Index.TabIndex = 21;
            this.nav_Index.Text = "1";
            this.nav_Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_Index.Visible = false;
            this.nav_Index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nav_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1696, 1289);
            this.Controls.Add(this.nav_Index);
            this.Controls.Add(this.nav_Forward);
            this.Controls.Add(this.nav_Back);
            this.Controls.Add(this.steps_Result_Label);
            this.Controls.Add(this.process_Time_Label);
            this.Controls.Add(this.process_Timer);
            this.Controls.Add(this.grammar_Label);
            this.Controls.Add(this.grammar_List);
            this.Controls.Add(this.parse_Table_Label);
            this.Controls.Add(this.steps_Label);
            this.Controls.Add(this.steps_List);
            this.Controls.Add(this.derivation_Process_Label);
            this.Controls.Add(this.derivation_Process_List);
            this.Controls.Add(this.production_Rules_Label);
            this.Controls.Add(this.production_Rules_List);
            this.Controls.Add(this.action_Label);
            this.Controls.Add(this.action_List);
            this.Controls.Add(this.stack_Label);
            this.Controls.Add(this.Parse_Table);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parse_Button);
            this.Controls.Add(this.stack_List);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Shift-Reduce Parser";
            this.Parse_Table.ResumeLayout(false);
            this.Parse_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView stack_List;
        private System.Windows.Forms.Button parse_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel Parse_Table;
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
        private System.Windows.Forms.Label parse_Table_Action;
        private System.Windows.Forms.Label parse_Table_State;
        private System.Windows.Forms.Label parse_Table_Goto;
        private System.Windows.Forms.Label Parse_Table_State0;
        private System.Windows.Forms.Label Parse_Table_State3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Parse_Table_State9;
        private System.Windows.Forms.Label Parse_Table_State8;
        private System.Windows.Forms.Label Parse_Table_State7;
        private System.Windows.Forms.Label Parse_Table_State6;
        private System.Windows.Forms.Label Parse_Table_State5;
        private System.Windows.Forms.Label Parse_Table_State4;
        private System.Windows.Forms.Label Parse_Table_State11;
        private System.Windows.Forms.Label Parse_Table_State10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label parse_Table_Id;
        private System.Windows.Forms.Label parse_Table_Plus;
        private System.Windows.Forms.Label parse_Table_Mult;
        private System.Windows.Forms.Label parse_Table_CPar;
        private System.Windows.Forms.Label parse_Table_OPar;
        private System.Windows.Forms.Label parse_Table_E;
        private System.Windows.Forms.Label parse_Table_Dol;
        private System.Windows.Forms.Label parse_Table_F;
        private System.Windows.Forms.Label parse_Table_T;
        private System.Windows.Forms.Label parse_Table_State7_id_S5;
        private System.Windows.Forms.Label parse_Table_State6_id_S5;
        private System.Windows.Forms.Label parse_Table_State4_id_S5;
        private System.Windows.Forms.Label parse_Table_State0_id_S5;
        private System.Windows.Forms.Label parse_Table_State2;
        private System.Windows.Forms.Label parse_Table_State2_Plus_R2;
        private System.Windows.Forms.Label parse_Table_State1_Plus_S6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label parse_Table_State9_Plus_R1;
        private System.Windows.Forms.Label parse_Table_State8_Plus_S6;
        private System.Windows.Forms.Label parse_Table_State5_Plus_R6;
        private System.Windows.Forms.Label parse_Table_State3_Plus_R4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
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
    }
}

