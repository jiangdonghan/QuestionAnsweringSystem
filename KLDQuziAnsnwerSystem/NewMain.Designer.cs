namespace KLDQuziAnsnwerSystem
{
    partial class NewMain
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhraseFormCheckbox = new System.Windows.Forms.CheckBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.QueryExpansionCheckBox = new System.Windows.Forms.CheckBox();
            this.labelSearchingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNewSearch = new System.Windows.Forms.Button();
            this.labelFinalQuery = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryText = new System.Windows.Forms.TextBox();
            this.buttonIndexSave = new System.Windows.Forms.Button();
            this.IndexDirectoryPath = new System.Windows.Forms.Label();
            this.buttonCollectionSave = new System.Windows.Forms.Button();
            this.CollectionDirectoryPath = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PassageBoostBox = new System.Windows.Forms.TextBox();
            this.TitleBoostBox = new System.Windows.Forms.TextBox();
            this.PassageBoostCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleBoostCheckBox = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.SelectSystem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadDatabaseButton = new System.Windows.Forms.Button();
            this.IndexCreate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(378, 173);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(495, 553);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SearchResult";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(410, 189);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(474, 531);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(49, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(314, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Similarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Overriding tf to 1";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Similarity:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoadDatabaseButton);
            this.groupBox3.Controls.Add(this.PhraseFormCheckbox);
            this.groupBox3.Controls.Add(this.labelDocNumber);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonOutput);
            this.groupBox3.Controls.Add(this.QueryExpansionCheckBox);
            this.groupBox3.Controls.Add(this.labelSearchingTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labelFinalQuery);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.QueryText);
            this.groupBox3.Location = new System.Drawing.Point(49, 425);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(314, 301);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Searching";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // PhraseFormCheckbox
            // 
            this.PhraseFormCheckbox.AutoSize = true;
            this.PhraseFormCheckbox.Location = new System.Drawing.Point(12, 90);
            this.PhraseFormCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.PhraseFormCheckbox.Name = "PhraseFormCheckbox";
            this.PhraseFormCheckbox.Size = new System.Drawing.Size(105, 17);
            this.PhraseFormCheckbox.TabIndex = 11;
            this.PhraseFormCheckbox.Text = "Use Query As Is";
            this.PhraseFormCheckbox.UseVisualStyleBackColor = true;
            this.PhraseFormCheckbox.CheckedChanged += new System.EventHandler(this.PhraseFormCheckbox_CheckedChanged);
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(125, 122);
            this.labelDocNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(0, 13);
            this.labelDocNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Relevant Documents:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(12, 252);
            this.buttonOutput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(90, 35);
            this.buttonOutput.TabIndex = 8;
            this.buttonOutput.Text = "Output Result";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // QueryExpansionCheckBox
            // 
            this.QueryExpansionCheckBox.AutoSize = true;
            this.QueryExpansionCheckBox.Location = new System.Drawing.Point(178, 90);
            this.QueryExpansionCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryExpansionCheckBox.Name = "QueryExpansionCheckBox";
            this.QueryExpansionCheckBox.Size = new System.Drawing.Size(130, 17);
            this.QueryExpansionCheckBox.TabIndex = 7;
            this.QueryExpansionCheckBox.Text = "Use Query Expansion";
            this.QueryExpansionCheckBox.UseVisualStyleBackColor = true;
            this.QueryExpansionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // labelSearchingTime
            // 
            this.labelSearchingTime.AutoSize = true;
            this.labelSearchingTime.Location = new System.Drawing.Point(218, 21);
            this.labelSearchingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchingTime.Name = "labelSearchingTime";
            this.labelSearchingTime.Size = new System.Drawing.Size(0, 13);
            this.labelSearchingTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Time:";
            // 
            // ButtonNewSearch
            // 
            this.ButtonNewSearch.Location = new System.Drawing.Point(284, 462);
            this.ButtonNewSearch.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNewSearch.Name = "ButtonNewSearch";
            this.ButtonNewSearch.Size = new System.Drawing.Size(75, 45);
            this.ButtonNewSearch.TabIndex = 4;
            this.ButtonNewSearch.Text = "Search";
            this.ButtonNewSearch.UseVisualStyleBackColor = true;
            this.ButtonNewSearch.Click += new System.EventHandler(this.ButtonNewSearch_Click);
            // 
            // labelFinalQuery
            // 
            this.labelFinalQuery.AutoSize = true;
            this.labelFinalQuery.Location = new System.Drawing.Point(84, 192);
            this.labelFinalQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFinalQuery.Name = "labelFinalQuery";
            this.labelFinalQuery.Size = new System.Drawing.Size(63, 13);
            this.labelFinalQuery.TabIndex = 3;
            this.labelFinalQuery.Text = "Final Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Query:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type search query here:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(12, 37);
            this.QueryText.Margin = new System.Windows.Forms.Padding(2);
            this.QueryText.Multiline = true;
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(219, 45);
            this.QueryText.TabIndex = 1;
            this.QueryText.TextChanged += new System.EventHandler(this.QueryText_TextChanged);
            // 
            // buttonIndexSave
            // 
            this.buttonIndexSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonIndexSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIndexSave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonIndexSave.Location = new System.Drawing.Point(49, 86);
            this.buttonIndexSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIndexSave.Name = "buttonIndexSave";
            this.buttonIndexSave.Size = new System.Drawing.Size(231, 37);
            this.buttonIndexSave.TabIndex = 5;
            this.buttonIndexSave.Text = "SELECT LUCENE INDEX DIRECTORY";
            this.buttonIndexSave.UseVisualStyleBackColor = false;
            this.buttonIndexSave.Click += new System.EventHandler(this.ButtonIndexSave_Click);
            // 
            // IndexDirectoryPath
            // 
            this.IndexDirectoryPath.AutoSize = true;
            this.IndexDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IndexDirectoryPath.Location = new System.Drawing.Point(46, 54);
            this.IndexDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndexDirectoryPath.Name = "IndexDirectoryPath";
            this.IndexDirectoryPath.Size = new System.Drawing.Size(127, 16);
            this.IndexDirectoryPath.TabIndex = 6;
            this.IndexDirectoryPath.Text = "Index Directory Path";
            // 
            // buttonCollectionSave
            // 
            this.buttonCollectionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonCollectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCollectionSave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollectionSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonCollectionSave.Location = new System.Drawing.Point(49, 173);
            this.buttonCollectionSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionSave.Name = "buttonCollectionSave";
            this.buttonCollectionSave.Size = new System.Drawing.Size(231, 37);
            this.buttonCollectionSave.TabIndex = 7;
            this.buttonCollectionSave.Text = "SELECT COLLECTION FILE";
            this.buttonCollectionSave.UseVisualStyleBackColor = false;
            this.buttonCollectionSave.Click += new System.EventHandler(this.ButtonCollectionSave_Click);
            // 
            // CollectionDirectoryPath
            // 
            this.CollectionDirectoryPath.AutoSize = true;
            this.CollectionDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CollectionDirectoryPath.Location = new System.Drawing.Point(46, 140);
            this.CollectionDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CollectionDirectoryPath.Name = "CollectionDirectoryPath";
            this.CollectionDirectoryPath.Size = new System.Drawing.Size(97, 16);
            this.CollectionDirectoryPath.TabIndex = 8;
            this.CollectionDirectoryPath.Text = "Collection Path";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PassageBoostBox);
            this.groupBox5.Controls.Add(this.TitleBoostBox);
            this.groupBox5.Controls.Add(this.PassageBoostCheckBox);
            this.groupBox5.Controls.Add(this.TitleBoostCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(49, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 58);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boosting";
            // 
            // PassageBoostBox
            // 
            this.PassageBoostBox.Location = new System.Drawing.Point(236, 22);
            this.PassageBoostBox.Name = "PassageBoostBox";
            this.PassageBoostBox.Size = new System.Drawing.Size(42, 21);
            this.PassageBoostBox.TabIndex = 3;
            // 
            // TitleBoostBox
            // 
            this.TitleBoostBox.Location = new System.Drawing.Point(69, 24);
            this.TitleBoostBox.Name = "TitleBoostBox";
            this.TitleBoostBox.Size = new System.Drawing.Size(48, 21);
            this.TitleBoostBox.TabIndex = 2;
            this.TitleBoostBox.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // PassageBoostCheckBox
            // 
            this.PassageBoostCheckBox.AutoSize = true;
            this.PassageBoostCheckBox.Location = new System.Drawing.Point(158, 25);
            this.PassageBoostCheckBox.Name = "PassageBoostCheckBox";
            this.PassageBoostCheckBox.Size = new System.Drawing.Size(69, 17);
            this.PassageBoostCheckBox.TabIndex = 1;
            this.PassageBoostCheckBox.Text = "Passage";
            this.PassageBoostCheckBox.UseVisualStyleBackColor = true;
            this.PassageBoostCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxPassage_CheckedChanged);
            // 
            // TitleBoostCheckBox
            // 
            this.TitleBoostCheckBox.AutoSize = true;
            this.TitleBoostCheckBox.Location = new System.Drawing.Point(8, 27);
            this.TitleBoostCheckBox.Name = "TitleBoostCheckBox";
            this.TitleBoostCheckBox.Size = new System.Drawing.Size(49, 17);
            this.TitleBoostCheckBox.TabIndex = 0;
            this.TitleBoostCheckBox.Text = "Title";
            this.TitleBoostCheckBox.UseVisualStyleBackColor = true;
            this.TitleBoostCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxTitle_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(582, 98);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(80, 13);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Indexing Time:";
            this.labelTime.Click += new System.EventHandler(this.LabelTime_Click);
            // 
            // SelectSystem
            // 
            this.SelectSystem.AutoSize = true;
            this.SelectSystem.Location = new System.Drawing.Point(49, 18);
            this.SelectSystem.Name = "SelectSystem";
            this.SelectSystem.Size = new System.Drawing.Size(130, 17);
            this.SelectSystem.TabIndex = 16;
            this.SelectSystem.Text = "Use baseline system";
            this.SelectSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IndexCreate);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.SelectSystem);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.CollectionDirectoryPath);
            this.groupBox1.Controls.Add(this.buttonCollectionSave);
            this.groupBox1.Controls.Add(this.IndexDirectoryPath);
            this.groupBox1.Controls.Add(this.ButtonNewSearch);
            this.groupBox1.Controls.Add(this.buttonIndexSave);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(873, 730);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // LoadDatabaseButton
            // 
            this.LoadDatabaseButton.Location = new System.Drawing.Point(178, 112);
            this.LoadDatabaseButton.Name = "LoadDatabaseButton";
            this.LoadDatabaseButton.Size = new System.Drawing.Size(123, 32);
            this.LoadDatabaseButton.TabIndex = 12;
            this.LoadDatabaseButton.Text = "Load Wordnet";
            this.LoadDatabaseButton.UseVisualStyleBackColor = true;
            this.LoadDatabaseButton.Click += new System.EventHandler(this.LoadDatabaseButton_Click);
            // 
            // IndexCreate
            // 
            this.IndexCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.IndexCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndexCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexCreate.ForeColor = System.Drawing.Color.White;
            this.IndexCreate.Location = new System.Drawing.Point(378, 86);
            this.IndexCreate.Margin = new System.Windows.Forms.Padding(2);
            this.IndexCreate.Name = "IndexCreate";
            this.IndexCreate.Size = new System.Drawing.Size(175, 37);
            this.IndexCreate.TabIndex = 8;
            this.IndexCreate.Text = "INDEX NOW";
            this.IndexCreate.UseVisualStyleBackColor = false;
            this.IndexCreate.Click += new System.EventHandler(this.IndexCreate_Click_1);
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(895, 739);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Documents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMain_FormClosed);
            this.Load += new System.EventHandler(this.NewMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox PhraseFormCheckbox;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.CheckBox QueryExpansionCheckBox;
        private System.Windows.Forms.Label labelSearchingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonNewSearch;
        private System.Windows.Forms.Label labelFinalQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QueryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIndexSave;
        private System.Windows.Forms.Label IndexDirectoryPath;
        private System.Windows.Forms.Button buttonCollectionSave;
        private System.Windows.Forms.Label CollectionDirectoryPath;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox PassageBoostBox;
        private System.Windows.Forms.TextBox TitleBoostBox;
        private System.Windows.Forms.CheckBox PassageBoostCheckBox;
        private System.Windows.Forms.CheckBox TitleBoostCheckBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox SelectSystem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadDatabaseButton;
        private System.Windows.Forms.Button IndexCreate;
    }
}