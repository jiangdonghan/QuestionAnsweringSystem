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
            this.SuspendLayout();
            // 
            // buttonIndexSave
            // 
            this.buttonIndexSave.ForeColor = System.Drawing.Color.Coral;
            this.buttonIndexSave.Location = new System.Drawing.Point(195, 61);
            this.buttonIndexSave.Name = "buttonIndexSave";
            this.buttonIndexSave.Size = new System.Drawing.Size(385, 59);
            this.buttonIndexSave.TabIndex = 3;
            this.buttonIndexSave.Text = "Select Index Save Directory";
            this.buttonIndexSave.UseVisualStyleBackColor = true;
            this.buttonIndexSave.Click += new System.EventHandler(this.ButtonIndexSave_Click);
            // 
            // buttonCollectionSave
            // 
            this.buttonCollectionSave.Location = new System.Drawing.Point(195, 222);
            this.buttonCollectionSave.Name = "buttonCollectionSave";
            this.buttonCollectionSave.Size = new System.Drawing.Size(385, 59);
            this.buttonCollectionSave.TabIndex = 4;
            this.buttonCollectionSave.Text = "Select Collection Save Directory";
            this.buttonCollectionSave.UseVisualStyleBackColor = true;
            this.buttonCollectionSave.Click += new System.EventHandler(this.ButtonCollectionSave_Click);
            // 
            // IndexDirectoryPath
            // 
            this.IndexDirectoryPath.AutoSize = true;
            this.IndexDirectoryPath.Location = new System.Drawing.Point(745, 78);
            this.IndexDirectoryPath.Name = "IndexDirectoryPath";
            this.IndexDirectoryPath.Size = new System.Drawing.Size(206, 25);
            this.IndexDirectoryPath.TabIndex = 5;
            this.IndexDirectoryPath.Text = "Index Directory Path";
            // 
            // CollectionDirectoryPath
            // 
            this.CollectionDirectoryPath.AutoSize = true;
            this.CollectionDirectoryPath.Location = new System.Drawing.Point(744, 239);
            this.CollectionDirectoryPath.Name = "CollectionDirectoryPath";
            this.CollectionDirectoryPath.Size = new System.Drawing.Size(249, 25);
            this.CollectionDirectoryPath.TabIndex = 6;
            this.CollectionDirectoryPath.Text = "Collection Directory Path";
            // 
            // IndexCreate
            // 
            this.IndexCreate.Location = new System.Drawing.Point(488, 427);
            this.IndexCreate.Name = "IndexCreate";
            this.IndexCreate.Size = new System.Drawing.Size(243, 76);
            this.IndexCreate.TabIndex = 7;
            this.IndexCreate.Text = "Create Index";
            this.IndexCreate.UseVisualStyleBackColor = true;
            this.IndexCreate.Click += new System.EventHandler(this.IndexCreate_Click);
            // 
            // DirectorySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 602);
            this.Controls.Add(this.IndexCreate);
            this.Controls.Add(this.CollectionDirectoryPath);
            this.Controls.Add(this.IndexDirectoryPath);
            this.Controls.Add(this.buttonCollectionSave);
            this.Controls.Add(this.buttonIndexSave);
            this.Name = "DirectorySelect";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

