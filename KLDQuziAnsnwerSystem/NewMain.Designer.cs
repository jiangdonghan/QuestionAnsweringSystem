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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxQueryAsIs = new System.Windows.Forms.CheckBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelSearchingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNewSearch = new System.Windows.Forms.Button();
            this.labelFinalQuery = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QueryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.buttonIndexSave = new System.Windows.Forms.Button();
            this.IndexDirectoryPath = new System.Windows.Forms.Label();
            this.CollectionDirectoryPath = new System.Windows.Forms.Label();
            this.buttonCollectionSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPassage = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.checkBoxPassage = new System.Windows.Forms.CheckBox();
            this.checkBoxTitle = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.IndexCreate = new System.Windows.Forms.Button();
            this.SelectSystem = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectSystem);
            this.groupBox1.Controls.Add(this.IndexCreate);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.CollectionDirectoryPath);
            this.groupBox1.Controls.Add(this.buttonCollectionSave);
            this.groupBox1.Controls.Add(this.IndexDirectoryPath);
            this.groupBox1.Controls.Add(this.buttonIndexSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1000, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Directory";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Index Directory";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxQueryAsIs);
            this.groupBox3.Controls.Add(this.labelDocNumber);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonOutput);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.labelSearchingTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ButtonNewSearch);
            this.groupBox3.Controls.Add(this.labelFinalQuery);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.QueryText);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(49, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(304, 269);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Searching";
            // 
            // checkBoxQueryAsIs
            // 
            this.checkBoxQueryAsIs.AutoSize = true;
            this.checkBoxQueryAsIs.Location = new System.Drawing.Point(12, 74);
            this.checkBoxQueryAsIs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxQueryAsIs.Name = "checkBoxQueryAsIs";
            this.checkBoxQueryAsIs.Size = new System.Drawing.Size(102, 17);
            this.checkBoxQueryAsIs.TabIndex = 11;
            this.checkBoxQueryAsIs.Text = "Use Query As Is";
            this.checkBoxQueryAsIs.UseVisualStyleBackColor = true;
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(165, 204);
            this.labelDocNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(44, 13);
            this.labelDocNumber.TabIndex = 10;
            this.labelDocNumber.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Relevant document number:";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(103, 230);
            this.buttonOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(90, 35);
            this.buttonOutput.TabIndex = 8;
            this.buttonOutput.Text = "Output Result";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 105);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Load WordNet Database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelSearchingTime
            // 
            this.labelSearchingTime.AutoSize = true;
            this.labelSearchingTime.Location = new System.Drawing.Point(165, 174);
            this.labelSearchingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchingTime.Name = "labelSearchingTime";
            this.labelSearchingTime.Size = new System.Drawing.Size(30, 13);
            this.labelSearchingTime.TabIndex = 6;
            this.labelSearchingTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Time:";
            // 
            // ButtonNewSearch
            // 
            this.ButtonNewSearch.Location = new System.Drawing.Point(175, 74);
            this.ButtonNewSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonNewSearch.Name = "ButtonNewSearch";
            this.ButtonNewSearch.Size = new System.Drawing.Size(90, 32);
            this.ButtonNewSearch.TabIndex = 4;
            this.ButtonNewSearch.Text = "Search";
            this.ButtonNewSearch.UseVisualStyleBackColor = true;
            this.ButtonNewSearch.Click += new System.EventHandler(this.ButtonNewSearch_Click);
            // 
            // labelFinalQuery
            // 
            this.labelFinalQuery.AutoSize = true;
            this.labelFinalQuery.Location = new System.Drawing.Point(165, 150);
            this.labelFinalQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFinalQuery.Name = "labelFinalQuery";
            this.labelFinalQuery.Size = new System.Drawing.Size(60, 13);
            this.labelFinalQuery.TabIndex = 3;
            this.labelFinalQuery.Text = "Final Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Query:";
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(50, 28);
            this.QueryText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(254, 20);
            this.QueryText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(49, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(304, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Similarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Overriding tf to 1";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Similarity:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResultTextBox);
            this.groupBox4.Location = new System.Drawing.Point(412, 122);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(406, 411);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SearchResult";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(3, 25);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(397, 500);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            // 
            // buttonIndexSave
            // 
            this.buttonIndexSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonIndexSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIndexSave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonIndexSave.Location = new System.Drawing.Point(49, 37);
            this.buttonIndexSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIndexSave.Name = "buttonIndexSave";
            this.buttonIndexSave.Size = new System.Drawing.Size(221, 37);
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
            this.IndexDirectoryPath.Location = new System.Drawing.Point(46, 8);
            this.IndexDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndexDirectoryPath.Name = "IndexDirectoryPath";
            this.IndexDirectoryPath.Size = new System.Drawing.Size(127, 16);
            this.IndexDirectoryPath.TabIndex = 6;
            this.IndexDirectoryPath.Text = "Index Directory Path";
            // 
            // CollectionDirectoryPath
            // 
            this.CollectionDirectoryPath.AutoSize = true;
            this.CollectionDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CollectionDirectoryPath.Location = new System.Drawing.Point(330, 8);
            this.CollectionDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CollectionDirectoryPath.Name = "CollectionDirectoryPath";
            this.CollectionDirectoryPath.Size = new System.Drawing.Size(97, 16);
            this.CollectionDirectoryPath.TabIndex = 8;
            this.CollectionDirectoryPath.Text = "Collection Path";
            // 
            // buttonCollectionSave
            // 
            this.buttonCollectionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonCollectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCollectionSave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollectionSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonCollectionSave.Location = new System.Drawing.Point(333, 37);
            this.buttonCollectionSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionSave.Name = "buttonCollectionSave";
            this.buttonCollectionSave.Size = new System.Drawing.Size(231, 37);
            this.buttonCollectionSave.TabIndex = 7;
            this.buttonCollectionSave.Text = "SELECT COLLECTION FILE";
            this.buttonCollectionSave.UseVisualStyleBackColor = false;
            this.buttonCollectionSave.Click += new System.EventHandler(this.ButtonCollectionSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPassage);
            this.groupBox5.Controls.Add(this.textBoxTitle);
            this.groupBox5.Controls.Add(this.checkBoxPassage);
            this.groupBox5.Controls.Add(this.checkBoxTitle);
            this.groupBox5.Location = new System.Drawing.Point(49, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 58);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boosting";
            // 
            // textBoxPassage
            // 
            this.textBoxPassage.Location = new System.Drawing.Point(236, 22);
            this.textBoxPassage.Name = "textBoxPassage";
            this.textBoxPassage.Size = new System.Drawing.Size(29, 20);
            this.textBoxPassage.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(69, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(29, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // checkBoxPassage
            // 
            this.checkBoxPassage.AutoSize = true;
            this.checkBoxPassage.Location = new System.Drawing.Point(158, 25);
            this.checkBoxPassage.Name = "checkBoxPassage";
            this.checkBoxPassage.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPassage.TabIndex = 1;
            this.checkBoxPassage.Text = "Passage";
            this.checkBoxPassage.UseVisualStyleBackColor = true;
            this.checkBoxPassage.CheckedChanged += new System.EventHandler(this.CheckBoxPassage_CheckedChanged);
            // 
            // checkBoxTitle
            // 
            this.checkBoxTitle.AutoSize = true;
            this.checkBoxTitle.Location = new System.Drawing.Point(8, 27);
            this.checkBoxTitle.Name = "checkBoxTitle";
            this.checkBoxTitle.Size = new System.Drawing.Size(46, 17);
            this.checkBoxTitle.TabIndex = 0;
            this.checkBoxTitle.Text = "Title";
            this.checkBoxTitle.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(46, 86);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(76, 13);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Indexing Time:";
            // 
            // IndexCreate
            // 
            this.IndexCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.IndexCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndexCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexCreate.ForeColor = System.Drawing.Color.White;
            this.IndexCreate.Location = new System.Drawing.Point(177, 78);
            this.IndexCreate.Margin = new System.Windows.Forms.Padding(2);
            this.IndexCreate.Name = "IndexCreate";
            this.IndexCreate.Size = new System.Drawing.Size(223, 35);
            this.IndexCreate.TabIndex = 15;
            this.IndexCreate.Text = "START INDEXING";
            this.IndexCreate.UseVisualStyleBackColor = false;
            this.IndexCreate.Click += new System.EventHandler(this.IndexCreate_Click);
            // 
            // SelectSystem
            // 
            this.SelectSystem.AutoSize = true;
            this.SelectSystem.Location = new System.Drawing.Point(550, 86);
            this.SelectSystem.Name = "SelectSystem";
            this.SelectSystem.Size = new System.Drawing.Size(122, 17);
            this.SelectSystem.TabIndex = 16;
            this.SelectSystem.Text = "Use baseline system";
            this.SelectSystem.UseVisualStyleBackColor = true;
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 557);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMain_FormClosed);
            this.Load += new System.EventHandler(this.NewMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelSearchingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonNewSearch;
        private System.Windows.Forms.Label labelFinalQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QueryText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.CheckBox checkBoxQueryAsIs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput;
        private System.Windows.Forms.Button buttonIndexSave;
        private System.Windows.Forms.Label IndexDirectoryPath;
        private System.Windows.Forms.Label CollectionDirectoryPath;
        private System.Windows.Forms.Button buttonCollectionSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPassage;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxPassage;
        private System.Windows.Forms.CheckBox checkBoxTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button IndexCreate;
        private System.Windows.Forms.CheckBox SelectSystem;
    }
}