namespace Saaristo_Asg9
{
    partial class FormAsg9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsg9));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxNoDupes = new System.Windows.Forms.CheckBox();
            this.buttonAscending = new System.Windows.Forms.Button();
            this.buttonDescending = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonNoQuotes = new System.Windows.Forms.Button();
            this.buttonWQuotes = new System.Windows.Forms.Button();
            this.textBoxMultiLineInput = new System.Windows.Forms.TextBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAddFind = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonFine = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBeginning = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.tabPageSearchReplace = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonTAB = new System.Windows.Forms.Button();
            this.buttonCRLF = new System.Windows.Forms.Button();
            this.tabPageSortSQL = new System.Windows.Forms.TabPage();
            this.tabPageReplaceSpecial = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxReplaceSpecialDBM = new System.Windows.Forms.CheckBox();
            this.buttonReplaceSpecialDelete = new System.Windows.Forms.Button();
            this.textBoxReplaceSpecialSearch = new System.Windows.Forms.TextBox();
            this.buttonCopyAllData = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageAddFind.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPageSearchReplace.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPageSortSQL.SuspendLayout();
            this.tabPageReplaceSpecial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUndo);
            this.groupBox4.Controls.Add(this.buttonRedo);
            this.groupBox4.Controls.Add(this.buttonClear);
            this.groupBox4.Location = new System.Drawing.Point(963, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Undo / Redo";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(6, 35);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(71, 22);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(6, 60);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(71, 23);
            this.buttonRedo.TabIndex = 10;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 92);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(71, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxNoDupes);
            this.groupBox5.Controls.Add(this.buttonAscending);
            this.groupBox5.Controls.Add(this.buttonDescending);
            this.groupBox5.Location = new System.Drawing.Point(15, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 66);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort Results";
            // 
            // checkBoxNoDupes
            // 
            this.checkBoxNoDupes.AutoSize = true;
            this.checkBoxNoDupes.Location = new System.Drawing.Point(198, 28);
            this.checkBoxNoDupes.Name = "checkBoxNoDupes";
            this.checkBoxNoDupes.Size = new System.Drawing.Size(88, 20);
            this.checkBoxNoDupes.TabIndex = 5;
            this.checkBoxNoDupes.Text = "No dupes";
            this.checkBoxNoDupes.UseVisualStyleBackColor = true;
            // 
            // buttonAscending
            // 
            this.buttonAscending.Location = new System.Drawing.Point(6, 21);
            this.buttonAscending.Name = "buttonAscending";
            this.buttonAscending.Size = new System.Drawing.Size(90, 33);
            this.buttonAscending.TabIndex = 12;
            this.buttonAscending.Text = "Ascending";
            this.buttonAscending.UseVisualStyleBackColor = true;
            this.buttonAscending.Click += new System.EventHandler(this.buttonAscending_Click);
            // 
            // buttonDescending
            // 
            this.buttonDescending.Location = new System.Drawing.Point(102, 21);
            this.buttonDescending.Name = "buttonDescending";
            this.buttonDescending.Size = new System.Drawing.Size(90, 34);
            this.buttonDescending.TabIndex = 13;
            this.buttonDescending.Text = "Descending";
            this.buttonDescending.UseVisualStyleBackColor = true;
            this.buttonDescending.Click += new System.EventHandler(this.buttonDescending_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonNoQuotes);
            this.groupBox6.Controls.Add(this.buttonWQuotes);
            this.groupBox6.Location = new System.Drawing.Point(339, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 67);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Make Sql in";
            // 
            // buttonNoQuotes
            // 
            this.buttonNoQuotes.Location = new System.Drawing.Point(96, 22);
            this.buttonNoQuotes.Name = "buttonNoQuotes";
            this.buttonNoQuotes.Size = new System.Drawing.Size(84, 32);
            this.buttonNoQuotes.TabIndex = 15;
            this.buttonNoQuotes.Text = "No Quotes";
            this.buttonNoQuotes.UseVisualStyleBackColor = true;
            this.buttonNoQuotes.Click += new System.EventHandler(this.buttonNoQuotes_Click);
            // 
            // buttonWQuotes
            // 
            this.buttonWQuotes.Location = new System.Drawing.Point(6, 21);
            this.buttonWQuotes.Name = "buttonWQuotes";
            this.buttonWQuotes.Size = new System.Drawing.Size(84, 34);
            this.buttonWQuotes.TabIndex = 14;
            this.buttonWQuotes.Text = "W/Quotes:";
            this.buttonWQuotes.UseVisualStyleBackColor = true;
            this.buttonWQuotes.Click += new System.EventHandler(this.buttonWQuotes_Click);
            // 
            // textBoxMultiLineInput
            // 
            this.textBoxMultiLineInput.Location = new System.Drawing.Point(12, 160);
            this.textBoxMultiLineInput.Multiline = true;
            this.textBoxMultiLineInput.Name = "textBoxMultiLineInput";
            this.textBoxMultiLineInput.Size = new System.Drawing.Size(943, 333);
            this.textBoxMultiLineInput.TabIndex = 4;
            this.textBoxMultiLineInput.Text = "aaa\r\nbbb\r\nccc\r\nddd\r\naabb\r\naacc\r\nccdd\r\nline 1\r\nline 2\r\nline 3\r\nlast line";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(962, 451);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(94, 42);
            this.buttonClearAll.TabIndex = 12;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAddFind);
            this.tabControlMain.Controls.Add(this.tabPageSearchReplace);
            this.tabControlMain.Controls.Add(this.tabPageSortSQL);
            this.tabControlMain.Controls.Add(this.tabPageReplaceSpecial);
            this.tabControlMain.Location = new System.Drawing.Point(6, 14);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(951, 140);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabPageAddFind
            // 
            this.tabPageAddFind.Controls.Add(this.groupBox1);
            this.tabPageAddFind.Controls.Add(this.groupBox8);
            this.tabPageAddFind.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddFind.Name = "tabPageAddFind";
            this.tabPageAddFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddFind.Size = new System.Drawing.Size(943, 111);
            this.tabPageAddFind.TabIndex = 0;
            this.tabPageAddFind.Text = "Add / Find";
            this.tabPageAddFind.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonFine);
            this.groupBox1.Controls.Add(this.textBoxFind);
            this.groupBox1.Location = new System.Drawing.Point(513, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find lines matching or Not matching";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Exclude Matching";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonFine
            // 
            this.buttonFine.Location = new System.Drawing.Point(369, 46);
            this.buttonFine.Name = "buttonFine";
            this.buttonFine.Size = new System.Drawing.Size(59, 25);
            this.buttonFine.TabIndex = 6;
            this.buttonFine.Text = "Find";
            this.buttonFine.UseVisualStyleBackColor = true;
            this.buttonFine.Click += new System.EventHandler(this.buttonFine_Click_1);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(82, 21);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(275, 22);
            this.textBoxFind.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.textBoxBeginning);
            this.groupBox8.Controls.Add(this.textBoxEnd);
            this.groupBox8.Controls.Add(this.buttonAddText);
            this.groupBox8.Location = new System.Drawing.Point(7, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(500, 84);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Add to beginning / end of line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Beginning:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "End:";
            // 
            // textBoxBeginning
            // 
            this.textBoxBeginning.Location = new System.Drawing.Point(82, 15);
            this.textBoxBeginning.Name = "textBoxBeginning";
            this.textBoxBeginning.Size = new System.Drawing.Size(275, 22);
            this.textBoxBeginning.TabIndex = 4;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(82, 39);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(275, 22);
            this.textBoxEnd.TabIndex = 5;
            // 
            // buttonAddText
            // 
            this.buttonAddText.Location = new System.Drawing.Point(395, 18);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(86, 29);
            this.buttonAddText.TabIndex = 4;
            this.buttonAddText.Text = "Add Text";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.buttonAddText_Click_1);
            // 
            // tabPageSearchReplace
            // 
            this.tabPageSearchReplace.Controls.Add(this.groupBox3);
            this.tabPageSearchReplace.Controls.Add(this.groupBox7);
            this.tabPageSearchReplace.Location = new System.Drawing.Point(4, 25);
            this.tabPageSearchReplace.Name = "tabPageSearchReplace";
            this.tabPageSearchReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReplace.Size = new System.Drawing.Size(943, 111);
            this.tabPageSearchReplace.TabIndex = 1;
            this.tabPageSearchReplace.Text = "Search / Replace";
            this.tabPageSearchReplace.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxReplace);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonReplace);
            this.groupBox3.Location = new System.Drawing.Point(15, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search and replace";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(74, 39);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(252, 22);
            this.textBoxReplace.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Replace:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(74, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 22);
            this.textBoxSearch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search:";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(332, 21);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(86, 38);
            this.buttonReplace.TabIndex = 5;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonTAB);
            this.groupBox7.Controls.Add(this.buttonCRLF);
            this.groupBox7.Location = new System.Drawing.Point(459, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(349, 55);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Copy these special chars to the clipboard to copy / paste";
            // 
            // buttonTAB
            // 
            this.buttonTAB.Location = new System.Drawing.Point(58, 21);
            this.buttonTAB.Name = "buttonTAB";
            this.buttonTAB.Size = new System.Drawing.Size(86, 31);
            this.buttonTAB.TabIndex = 7;
            this.buttonTAB.Text = "[TAB]";
            this.buttonTAB.UseVisualStyleBackColor = true;
            this.buttonTAB.Click += new System.EventHandler(this.buttonTAB_Click_1);
            // 
            // buttonCRLF
            // 
            this.buttonCRLF.Location = new System.Drawing.Point(166, 21);
            this.buttonCRLF.Name = "buttonCRLF";
            this.buttonCRLF.Size = new System.Drawing.Size(86, 31);
            this.buttonCRLF.TabIndex = 8;
            this.buttonCRLF.Text = "[CRLF]";
            this.buttonCRLF.UseVisualStyleBackColor = true;
            this.buttonCRLF.Click += new System.EventHandler(this.buttonCRLF_Click_1);
            // 
            // tabPageSortSQL
            // 
            this.tabPageSortSQL.Controls.Add(this.groupBox5);
            this.tabPageSortSQL.Controls.Add(this.groupBox6);
            this.tabPageSortSQL.Location = new System.Drawing.Point(4, 25);
            this.tabPageSortSQL.Name = "tabPageSortSQL";
            this.tabPageSortSQL.Size = new System.Drawing.Size(943, 111);
            this.tabPageSortSQL.TabIndex = 2;
            this.tabPageSortSQL.Text = "tabPageSortSQL";
            this.tabPageSortSQL.UseVisualStyleBackColor = true;
            // 
            // tabPageReplaceSpecial
            // 
            this.tabPageReplaceSpecial.Controls.Add(this.groupBox2);
            this.tabPageReplaceSpecial.Location = new System.Drawing.Point(4, 25);
            this.tabPageReplaceSpecial.Name = "tabPageReplaceSpecial";
            this.tabPageReplaceSpecial.Size = new System.Drawing.Size(943, 111);
            this.tabPageReplaceSpecial.TabIndex = 3;
            this.tabPageReplaceSpecial.Text = "Replace / Special";
            this.tabPageReplaceSpecial.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBoxReplaceSpecialDBM);
            this.groupBox2.Controls.Add(this.buttonReplaceSpecialDelete);
            this.groupBox2.Controls.Add(this.textBoxReplaceSpecialSearch);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Before / After";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search;";
            // 
            // checkBoxReplaceSpecialDBM
            // 
            this.checkBoxReplaceSpecialDBM.AutoSize = true;
            this.checkBoxReplaceSpecialDBM.Location = new System.Drawing.Point(223, 49);
            this.checkBoxReplaceSpecialDBM.Name = "checkBoxReplaceSpecialDBM";
            this.checkBoxReplaceSpecialDBM.Size = new System.Drawing.Size(151, 20);
            this.checkBoxReplaceSpecialDBM.TabIndex = 4;
            this.checkBoxReplaceSpecialDBM.Text = "Delete Before Match";
            this.checkBoxReplaceSpecialDBM.UseVisualStyleBackColor = true;
            // 
            // buttonReplaceSpecialDelete
            // 
            this.buttonReplaceSpecialDelete.Location = new System.Drawing.Point(381, 21);
            this.buttonReplaceSpecialDelete.Name = "buttonReplaceSpecialDelete";
            this.buttonReplaceSpecialDelete.Size = new System.Drawing.Size(67, 48);
            this.buttonReplaceSpecialDelete.TabIndex = 6;
            this.buttonReplaceSpecialDelete.Text = "Delete";
            this.buttonReplaceSpecialDelete.UseVisualStyleBackColor = true;
            this.buttonReplaceSpecialDelete.Click += new System.EventHandler(this.buttonReplaceSpecialDelete_Click);
            // 
            // textBoxReplaceSpecialSearch
            // 
            this.textBoxReplaceSpecialSearch.Location = new System.Drawing.Point(99, 21);
            this.textBoxReplaceSpecialSearch.Name = "textBoxReplaceSpecialSearch";
            this.textBoxReplaceSpecialSearch.Size = new System.Drawing.Size(275, 22);
            this.textBoxReplaceSpecialSearch.TabIndex = 6;
            // 
            // buttonCopyAllData
            // 
            this.buttonCopyAllData.Location = new System.Drawing.Point(966, 185);
            this.buttonCopyAllData.Name = "buttonCopyAllData";
            this.buttonCopyAllData.Size = new System.Drawing.Size(92, 61);
            this.buttonCopyAllData.TabIndex = 8;
            this.buttonCopyAllData.Text = "Copy All";
            this.buttonCopyAllData.UseVisualStyleBackColor = true;
            this.buttonCopyAllData.Click += new System.EventHandler(this.buttonCopyAllData_Click);
            // 
            // FormAsg9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.buttonCopyAllData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.textBoxMultiLineInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAsg9";
            this.Text = "Saaristo Asg 9";
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAddFind.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPageSearchReplace.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabPageSortSQL.ResumeLayout(false);
            this.tabPageReplaceSpecial.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxNoDupes;
        private System.Windows.Forms.Button buttonAscending;
        private System.Windows.Forms.Button buttonDescending;
        private System.Windows.Forms.Button buttonNoQuotes;
        private System.Windows.Forms.Button buttonWQuotes;
        private System.Windows.Forms.TextBox textBoxMultiLineInput;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAddFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFine;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBeginning;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.TabPage tabPageSearchReplace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonTAB;
        private System.Windows.Forms.Button buttonCRLF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TabPage tabPageSortSQL;
        private System.Windows.Forms.TabPage tabPageReplaceSpecial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReplaceSpecialDBM;
        private System.Windows.Forms.Button buttonReplaceSpecialDelete;
        private System.Windows.Forms.TextBox textBoxReplaceSpecialSearch;
        private System.Windows.Forms.Button buttonCopyAllData;
    }
}

