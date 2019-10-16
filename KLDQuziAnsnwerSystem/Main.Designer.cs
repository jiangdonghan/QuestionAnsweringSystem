namespace KLDQuziAnsnwerSystem
{
    partial class Main
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.Querytext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFinalQuery = new System.Windows.Forms.Label();
            this.lableRunTime = new System.Windows.Forms.Label();
            this.labelSearchingTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1066, 69);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(194, 88);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(165, 243);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(1237, 608);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.Text = "";
            // 
            // Querytext
            // 
            this.Querytext.Location = new System.Drawing.Point(539, 69);
            this.Querytext.Name = "Querytext";
            this.Querytext.Size = new System.Drawing.Size(411, 31);
            this.Querytext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Query:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Final Query:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(647, 902);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(237, 119);
            this.buttonOutput.TabIndex = 6;
            this.buttonOutput.Text = "Output Result";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Directory";
            // 
            // labelFinalQuery
            // 
            this.labelFinalQuery.AutoSize = true;
            this.labelFinalQuery.Location = new System.Drawing.Point(669, 132);
            this.labelFinalQuery.Name = "labelFinalQuery";
            this.labelFinalQuery.Size = new System.Drawing.Size(0, 25);
            this.labelFinalQuery.TabIndex = 8;
            // 
            // lableRunTime
            // 
            this.lableRunTime.AutoSize = true;
            this.lableRunTime.Location = new System.Drawing.Point(340, 178);
            this.lableRunTime.Name = "lableRunTime";
            this.lableRunTime.Size = new System.Drawing.Size(168, 25);
            this.lableRunTime.TabIndex = 9;
            this.lableRunTime.Text = "Searching Time:";
            // 
            // labelSearchingTime
            // 
            this.labelSearchingTime.AutoSize = true;
            this.labelSearchingTime.Location = new System.Drawing.Point(660, 178);
            this.labelSearchingTime.Name = "labelSearchingTime";
            this.labelSearchingTime.Size = new System.Drawing.Size(59, 25);
            this.labelSearchingTime.TabIndex = 10;
            this.labelSearchingTime.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "IndexDirectory:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1074);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSearchingTime);
            this.Controls.Add(this.lableRunTime);
            this.Controls.Add(this.labelFinalQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Querytext);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.TextBox Querytext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFinalQuery;
        private System.Windows.Forms.Label lableRunTime;
        private System.Windows.Forms.Label labelSearchingTime;
        private System.Windows.Forms.Label label5;
    }
}