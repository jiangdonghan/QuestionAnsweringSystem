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
            this.richFinalQuery = new System.Windows.Forms.RichTextBox();
            this.LoadDatabaseButton = new System.Windows.Forms.Button();
            this.PhraseFormCheckbox = new System.Windows.Forms.CheckBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.QueryExpansionCheckBox = new System.Windows.Forms.CheckBox();
            this.labelSearchingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNewSearch = new System.Windows.Forms.Button();
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
            this.IndexCreate = new System.Windows.Forms.Button();
            this.textBoxResultCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResultTextBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(756, 346);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(990, 1040);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SearchResult(Default 20 Results)";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(8, 36);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(944, 1058);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(98, 654);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(628, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Similarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Overriding tf to 1";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Similarity:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richFinalQuery);
            this.groupBox3.Controls.Add(this.LoadDatabaseButton);
            this.groupBox3.Controls.Add(this.PhraseFormCheckbox);
            this.groupBox3.Controls.Add(this.labelDocNumber);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonOutput);
            this.groupBox3.Controls.Add(this.QueryExpansionCheckBox);
            this.groupBox3.Controls.Add(this.labelSearchingTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ButtonNewSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.QueryText);
            this.groupBox3.Location = new System.Drawing.Point(98, 826);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(628, 560);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Searching";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // richFinalQuery
            // 
            this.richFinalQuery.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richFinalQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richFinalQuery.Location = new System.Drawing.Point(28, 330);
            this.richFinalQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richFinalQuery.Name = "richFinalQuery";
            this.richFinalQuery.ReadOnly = true;
            this.richFinalQuery.Size = new System.Drawing.Size(576, 114);
            this.richFinalQuery.TabIndex = 13;
            this.richFinalQuery.Text = "";
            // 
            // LoadDatabaseButton
            // 
            this.LoadDatabaseButton.BackColor = System.Drawing.Color.White;
            this.LoadDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadDatabaseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.LoadDatabaseButton.Location = new System.Drawing.Point(356, 234);
            this.LoadDatabaseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadDatabaseButton.Name = "LoadDatabaseButton";
            this.LoadDatabaseButton.Size = new System.Drawing.Size(246, 64);
            this.LoadDatabaseButton.TabIndex = 12;
            this.LoadDatabaseButton.Text = "Load Wordnet";
            this.LoadDatabaseButton.UseVisualStyleBackColor = false;
            this.LoadDatabaseButton.Click += new System.EventHandler(this.LoadDatabaseButton_Click);
            // 
            // PhraseFormCheckbox
            // 
            this.PhraseFormCheckbox.AutoSize = true;
            this.PhraseFormCheckbox.Location = new System.Drawing.Point(24, 190);
            this.PhraseFormCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhraseFormCheckbox.Name = "PhraseFormCheckbox";
            this.PhraseFormCheckbox.Size = new System.Drawing.Size(203, 30);
            this.PhraseFormCheckbox.TabIndex = 11;
            this.PhraseFormCheckbox.Text = "Use Query As Is";
            this.PhraseFormCheckbox.UseVisualStyleBackColor = true;
            this.PhraseFormCheckbox.CheckedChanged += new System.EventHandler(this.PhraseFormCheckbox_CheckedChanged);
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(250, 244);
            this.labelDocNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(0, 26);
            this.labelDocNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Relevant Documents:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.buttonOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutput.ForeColor = System.Drawing.Color.White;
            this.buttonOutput.Location = new System.Drawing.Point(28, 460);
            this.buttonOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(242, 80);
            this.buttonOutput.TabIndex = 8;
            this.buttonOutput.Text = "Output Results";
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // QueryExpansionCheckBox
            // 
            this.QueryExpansionCheckBox.AutoSize = true;
            this.QueryExpansionCheckBox.Location = new System.Drawing.Point(356, 190);
            this.QueryExpansionCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryExpansionCheckBox.Name = "QueryExpansionCheckBox";
            this.QueryExpansionCheckBox.Size = new System.Drawing.Size(256, 30);
            this.QueryExpansionCheckBox.TabIndex = 7;
            this.QueryExpansionCheckBox.Text = "Use Query Expansion";
            this.QueryExpansionCheckBox.UseVisualStyleBackColor = true;
            this.QueryExpansionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // labelSearchingTime
            // 
            this.labelSearchingTime.AutoSize = true;
            this.labelSearchingTime.Location = new System.Drawing.Point(436, 42);
            this.labelSearchingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchingTime.Name = "labelSearchingTime";
            this.labelSearchingTime.Size = new System.Drawing.Size(0, 26);
            this.labelSearchingTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Time:";
            // 
            // ButtonNewSearch
            // 
            this.ButtonNewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.ButtonNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonNewSearch.Location = new System.Drawing.Point(470, 84);
            this.ButtonNewSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNewSearch.Name = "ButtonNewSearch";
            this.ButtonNewSearch.Size = new System.Drawing.Size(150, 90);
            this.ButtonNewSearch.TabIndex = 4;
            this.ButtonNewSearch.Text = "Search";
            this.ButtonNewSearch.UseVisualStyleBackColor = false;
            this.ButtonNewSearch.Click += new System.EventHandler(this.ButtonNewSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Query:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type search query here:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(24, 84);
            this.QueryText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryText.Multiline = true;
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(434, 86);
            this.QueryText.TabIndex = 1;
            this.QueryText.TextChanged += new System.EventHandler(this.QueryText_TextChanged);
            // 
            // buttonIndexSave
            // 
            this.buttonIndexSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonIndexSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIndexSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonIndexSave.Location = new System.Drawing.Point(98, 172);
            this.buttonIndexSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIndexSave.Name = "buttonIndexSave";
            this.buttonIndexSave.Size = new System.Drawing.Size(462, 74);
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
            this.IndexDirectoryPath.Location = new System.Drawing.Point(92, 108);
            this.IndexDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndexDirectoryPath.Name = "IndexDirectoryPath";
            this.IndexDirectoryPath.Size = new System.Drawing.Size(243, 30);
            this.IndexDirectoryPath.TabIndex = 6;
            this.IndexDirectoryPath.Text = "Index Directory Path";
            // 
            // buttonCollectionSave
            // 
            this.buttonCollectionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonCollectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCollectionSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollectionSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonCollectionSave.Location = new System.Drawing.Point(98, 346);
            this.buttonCollectionSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCollectionSave.Name = "buttonCollectionSave";
            this.buttonCollectionSave.Size = new System.Drawing.Size(462, 74);
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
            this.CollectionDirectoryPath.Location = new System.Drawing.Point(92, 280);
            this.CollectionDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollectionDirectoryPath.Name = "CollectionDirectoryPath";
            this.CollectionDirectoryPath.Size = new System.Drawing.Size(185, 30);
            this.CollectionDirectoryPath.TabIndex = 8;
            this.CollectionDirectoryPath.Text = "Collection Path";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PassageBoostBox);
            this.groupBox5.Controls.Add(this.TitleBoostBox);
            this.groupBox5.Controls.Add(this.PassageBoostCheckBox);
            this.groupBox5.Controls.Add(this.TitleBoostCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(98, 494);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(628, 116);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boosting";
            // 
            // PassageBoostBox
            // 
            this.PassageBoostBox.Location = new System.Drawing.Point(472, 44);
            this.PassageBoostBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PassageBoostBox.Name = "PassageBoostBox";
            this.PassageBoostBox.Size = new System.Drawing.Size(80, 32);
            this.PassageBoostBox.TabIndex = 3;
            this.PassageBoostBox.TextChanged += new System.EventHandler(this.PassageBoostBox_TextChanged);
            // 
            // TitleBoostBox
            // 
            this.TitleBoostBox.Location = new System.Drawing.Point(138, 48);
            this.TitleBoostBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TitleBoostBox.Name = "TitleBoostBox";
            this.TitleBoostBox.Size = new System.Drawing.Size(92, 32);
            this.TitleBoostBox.TabIndex = 2;
            this.TitleBoostBox.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // PassageBoostCheckBox
            // 
            this.PassageBoostCheckBox.AutoSize = true;
            this.PassageBoostCheckBox.Location = new System.Drawing.Point(316, 50);
            this.PassageBoostCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PassageBoostCheckBox.Name = "PassageBoostCheckBox";
            this.PassageBoostCheckBox.Size = new System.Drawing.Size(129, 30);
            this.PassageBoostCheckBox.TabIndex = 1;
            this.PassageBoostCheckBox.Text = "Passage";
            this.PassageBoostCheckBox.UseVisualStyleBackColor = true;
            this.PassageBoostCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxPassage_CheckedChanged);
            // 
            // TitleBoostCheckBox
            // 
            this.TitleBoostCheckBox.AutoSize = true;
            this.TitleBoostCheckBox.Location = new System.Drawing.Point(16, 54);
            this.TitleBoostCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TitleBoostCheckBox.Name = "TitleBoostCheckBox";
            this.TitleBoostCheckBox.Size = new System.Drawing.Size(84, 30);
            this.TitleBoostCheckBox.TabIndex = 0;
            this.TitleBoostCheckBox.Text = "Title";
            this.TitleBoostCheckBox.UseVisualStyleBackColor = true;
            this.TitleBoostCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxTitle_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1164, 196);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(154, 26);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Indexing Time:";
            this.labelTime.Click += new System.EventHandler(this.LabelTime_Click);
            // 
            // SelectSystem
            // 
            this.SelectSystem.AutoSize = true;
            this.SelectSystem.Location = new System.Drawing.Point(98, 36);
            this.SelectSystem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectSystem.Name = "SelectSystem";
            this.SelectSystem.Size = new System.Drawing.Size(246, 30);
            this.SelectSystem.TabIndex = 16;
            this.SelectSystem.Text = "Use baseline system";
            this.SelectSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxResultCount);
            this.groupBox1.Controls.Add(this.IndexCreate);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.SelectSystem);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.CollectionDirectoryPath);
            this.groupBox1.Controls.Add(this.buttonCollectionSave);
            this.groupBox1.Controls.Add(this.IndexDirectoryPath);
            this.groupBox1.Controls.Add(this.buttonIndexSave);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1746, 1430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // IndexCreate
            // 
            this.IndexCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.IndexCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndexCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexCreate.ForeColor = System.Drawing.Color.White;
            this.IndexCreate.Location = new System.Drawing.Point(756, 172);
            this.IndexCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IndexCreate.Name = "IndexCreate";
            this.IndexCreate.Size = new System.Drawing.Size(350, 74);
            this.IndexCreate.TabIndex = 8;
            this.IndexCreate.Text = "INDEX NOW";
            this.IndexCreate.UseVisualStyleBackColor = false;
            this.IndexCreate.Click += new System.EventHandler(this.IndexCreate_Click_1);
            // 
            // textBoxResultCount
            // 
            this.textBoxResultCount.Location = new System.Drawing.Point(1652, 324);
            this.textBoxResultCount.Name = "textBoxResultCount";
            this.textBoxResultCount.Size = new System.Drawing.Size(56, 32);
            this.textBoxResultCount.TabIndex = 1;
            this.textBoxResultCount.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1456, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Number of results:";
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1770, 1474);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Documents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMain_FormClosed);
            this.Load += new System.EventHandler(this.NewMain_Load);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox richFinalQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultCount;
    }
}