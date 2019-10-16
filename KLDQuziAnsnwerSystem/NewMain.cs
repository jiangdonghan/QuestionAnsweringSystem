using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDQuziAnsnwerSystem
{
    public partial class NewMain : Form
    {
        public NewMain()
        {
            InitializeComponent();
        }
        public Func<string> GetValue;

        public Action<string> SendValue;

        public Func<string, string> GetAndSend;
        private void NewMain_Load(object sender, EventArgs e)
        {
            label5.Text = this.GetValue();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Continue to close the application?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void NewMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonNewSearch_Click(object sender, EventArgs e)
        {
            DateTime beforDT = System.DateTime.Now;
            
            String path = label5.Text;
            
            NewSearcher newSearcher = new NewSearcher();
            newSearcher.CreateSearcher(path);
            String queryText = QueryText.Text;
            string[] str = newSearcher.GetFinalqueryAndNumberofDocument(queryText);
            labelDocNumber.Text = str[0];
            List<String> listResult = newSearcher.SearchText(queryText);
            
            ResultTextBox.Lines = listResult.ToArray();
            int len = ResultTextBox.TextLength;
            int index = 0;
            int lastIndex = ResultTextBox.Text.LastIndexOf(queryText);
            while (index < lastIndex)
            {
                ResultTextBox.Find(queryText, index, len, RichTextBoxFinds.None);
                ResultTextBox.SelectionBackColor = Color.Red;
                index = ResultTextBox.Text.IndexOf(queryText, index) + 1;
            }
            labelFinalQuery.Text = queryText;
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            labelSearchingTime.Text = ts.TotalSeconds.ToString() + "s";
            newSearcher.CleanUpSearcher();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelFinalQuery_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
