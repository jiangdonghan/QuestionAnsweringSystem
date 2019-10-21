namespace KLDQuziAnsnwerSystem
{
    partial class DirectorySelect
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
            this.buttonIndexSave = new System.Windows.Forms.Button();
            this.buttonCollectionSave = new System.Windows.Forms.Button();
            this.saveCollectionDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveIndexDialog = new System.Windows.Forms.SaveFileDialog();
            this.IndexDirectoryPath = new System.Windows.Forms.Label();
            this.CollectionDirectoryPath = new System.Windows.Forms.Label();
            this.IndexCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSystem = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonGoSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassage = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.checkBoxPassage = new System.Windows.Forms.CheckBox();
            this.checkBoxTitle = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIndexSave
            // 
            this.buttonIndexSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonIndexSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIndexSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonIndexSave.Location = new System.Drawing.Point(50, 143);
            this.buttonIndexSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIndexSave.Name = "buttonIndexSave";
            this.buttonIndexSave.Size = new System.Drawing.Size(334, 63);
            this.buttonIndexSave.TabIndex = 3;
            this.buttonIndexSave.Text = "SELECT LUCENE INDEX DIRECTORY";
            this.buttonIndexSave.UseVisualStyleBackColor = false;
            this.buttonIndexSave.Click += new System.EventHandler(this.ButtonIndexSave_Click);
            // 
            // buttonCollectionSave
            // 
            this.buttonCollectionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonCollectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCollectionSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollectionSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(204)))), ((int)(((byte)(133)))));
            this.buttonCollectionSave.Location = new System.Drawing.Point(50, 286);
            this.buttonCollectionSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionSave.Name = "buttonCollectionSave";
            this.buttonCollectionSave.Size = new System.Drawing.Size(334, 62);
            this.buttonCollectionSave.TabIndex = 4;
            this.buttonCollectionSave.Text = "SELECT COLLECTION FILE";
            this.buttonCollectionSave.UseVisualStyleBackColor = false;
            this.buttonCollectionSave.Click += new System.EventHandler(this.ButtonCollectionSave_Click);
            // 
            // IndexDirectoryPath
            // 
            this.IndexDirectoryPath.AutoSize = true;
            this.IndexDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IndexDirectoryPath.Location = new System.Drawing.Point(48, 111);
            this.IndexDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndexDirectoryPath.Name = "IndexDirectoryPath";
            this.IndexDirectoryPath.Size = new System.Drawing.Size(127, 16);
            this.IndexDirectoryPath.TabIndex = 5;
            this.IndexDirectoryPath.Text = "Index Directory Path";
            this.IndexDirectoryPath.Click += new System.EventHandler(this.IndexDirectoryPath_Click);
            // 
            // CollectionDirectoryPath
            // 
            this.CollectionDirectoryPath.AutoSize = true;
            this.CollectionDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CollectionDirectoryPath.Location = new System.Drawing.Point(47, 257);
            this.CollectionDirectoryPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CollectionDirectoryPath.Name = "CollectionDirectoryPath";
            this.CollectionDirectoryPath.Size = new System.Drawing.Size(154, 16);
            this.CollectionDirectoryPath.TabIndex = 6;
            this.CollectionDirectoryPath.Text = "Collection Directory Path";
            // 
            // IndexCreate
            // 
            this.IndexCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(105)))), ((int)(((byte)(232)))));
            this.IndexCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndexCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexCreate.ForeColor = System.Drawing.Color.White;
            this.IndexCreate.Location = new System.Drawing.Point(55, 428);
            this.IndexCreate.Margin = new System.Windows.Forms.Padding(2);
            this.IndexCreate.Name = "IndexCreate";
            this.IndexCreate.Size = new System.Drawing.Size(184, 56);
            this.IndexCreate.TabIndex = 7;
            this.IndexCreate.Text = "START INDEXING";
            this.IndexCreate.UseVisualStyleBackColor = false;
            this.IndexCreate.Click += new System.EventHandler(this.IndexCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Step 1: Selecting paths";
            // 
            // SelectSystem
            // 
            this.SelectSystem.AutoSize = true;
            this.SelectSystem.Location = new System.Drawing.Point(829, 49);
            this.SelectSystem.Name = "SelectSystem";
            this.SelectSystem.Size = new System.Drawing.Size(153, 20);
            this.SelectSystem.TabIndex = 9;
            this.SelectSystem.Text = "Use baseline system";
            this.SelectSystem.UseVisualStyleBackColor = true;
            this.SelectSystem.CheckedChanged += new System.EventHandler(this.SelectSystem_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(557, 442);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(95, 16);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Indexing Time:";
            this.labelTime.Click += new System.EventHandler(this.LabelTime_Click);
            // 
            // buttonGoSearch
            // 
            this.buttonGoSearch.Location = new System.Drawing.Point(40, 605);
            this.buttonGoSearch.Name = "buttonGoSearch";
            this.buttonGoSearch.Size = new System.Drawing.Size(349, 98);
            this.buttonGoSearch.TabIndex = 11;
            this.buttonGoSearch.Text = "Go to Search Page";
            this.buttonGoSearch.UseVisualStyleBackColor = true;
            this.buttonGoSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPassage);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Controls.Add(this.checkBoxPassage);
            this.groupBox2.Controls.Add(this.checkBoxTitle);
            this.groupBox2.Location = new System.Drawing.Point(592, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 223);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boosting";
            // 
            // textBoxPassage
            // 
            this.textBoxPassage.Location = new System.Drawing.Point(267, 117);
            this.textBoxPassage.Name = "textBoxPassage";
            this.textBoxPassage.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassage.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(267, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 2;
            // 
            // checkBoxPassage
            // 
            this.checkBoxPassage.AutoSize = true;
            this.checkBoxPassage.Location = new System.Drawing.Point(27, 119);
            this.checkBoxPassage.Name = "checkBoxPassage";
            this.checkBoxPassage.Size = new System.Drawing.Size(82, 20);
            this.checkBoxPassage.TabIndex = 1;
            this.checkBoxPassage.Text = "Passage";
            this.checkBoxPassage.UseVisualStyleBackColor = true;
            // 
            // checkBoxTitle
            // 
            this.checkBoxTitle.AutoSize = true;
            this.checkBoxTitle.Location = new System.Drawing.Point(27, 54);
            this.checkBoxTitle.Name = "checkBoxTitle";
            this.checkBoxTitle.Size = new System.Drawing.Size(53, 20);
            this.checkBoxTitle.TabIndex = 0;
            this.checkBoxTitle.Text = "Title";
            this.checkBoxTitle.UseVisualStyleBackColor = true;
            // 
            // DirectorySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonGoSearch);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.SelectSystem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndexCreate);
            this.Controls.Add(this.CollectionDirectoryPath);
            this.Controls.Add(this.IndexDirectoryPath);
            this.Controls.Add(this.buttonCollectionSave);
            this.Controls.Add(this.buttonIndexSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DirectorySelect";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorySelect_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectorySelect_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIndexSave;
        private System.Windows.Forms.Button buttonCollectionSave;
        private System.Windows.Forms.SaveFileDialog saveCollectionDialog;
        private System.Windows.Forms.SaveFileDialog saveIndexDialog;
        private System.Windows.Forms.Label IndexDirectoryPath;
        private System.Windows.Forms.Label CollectionDirectoryPath;
        private System.Windows.Forms.Button IndexCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SelectSystem;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonGoSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassage;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxPassage;
        private System.Windows.Forms.CheckBox checkBoxTitle;
    }
}

