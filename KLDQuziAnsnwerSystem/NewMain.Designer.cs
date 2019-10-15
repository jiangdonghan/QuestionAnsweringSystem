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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1333, 741);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Directory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Index Directory";
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(65, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 372);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Searching";
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(220, 282);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(61, 18);
            this.labelDocNumber.TabIndex = 10;
            this.labelDocNumber.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Relevant document number:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(137, 318);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(120, 48);
            this.buttonOutput.TabIndex = 8;
            this.buttonOutput.Text = "Output Result";
            this.buttonOutput.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Load WordNet Database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelSearchingTime
            // 
            this.labelSearchingTime.AutoSize = true;
            this.labelSearchingTime.Location = new System.Drawing.Point(220, 241);
            this.labelSearchingTime.Name = "labelSearchingTime";
            this.labelSearchingTime.Size = new System.Drawing.Size(42, 18);
            this.labelSearchingTime.TabIndex = 6;
            this.labelSearchingTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Time:";
            // 
            // ButtonNewSearch
            // 
            this.ButtonNewSearch.Location = new System.Drawing.Point(137, 148);
            this.ButtonNewSearch.Name = "ButtonNewSearch";
            this.ButtonNewSearch.Size = new System.Drawing.Size(120, 44);
            this.ButtonNewSearch.TabIndex = 4;
            this.ButtonNewSearch.Text = "Search";
            this.ButtonNewSearch.UseVisualStyleBackColor = true;
            this.ButtonNewSearch.Click += new System.EventHandler(this.ButtonNewSearch_Click);
            // 
            // labelFinalQuery
            // 
            this.labelFinalQuery.AutoSize = true;
            this.labelFinalQuery.Location = new System.Drawing.Point(220, 208);
            this.labelFinalQuery.Name = "labelFinalQuery";
            this.labelFinalQuery.Size = new System.Drawing.Size(82, 18);
            this.labelFinalQuery.TabIndex = 3;
            this.labelFinalQuery.Text = "Final Query";
            this.labelFinalQuery.Click += new System.EventHandler(this.LabelFinalQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Query:";
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(137, 42);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(153, 26);
            this.QueryText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(65, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boosting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResultTextBox);
            this.groupBox4.Location = new System.Drawing.Point(549, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 730);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SearchResult";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(4, 28);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(528, 698);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(913, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox4.ResumeLayout(false);
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
    }
}