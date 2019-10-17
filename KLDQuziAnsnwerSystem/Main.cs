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
    public partial class Main : Form
    {
        Lucene.Net.Analysis.Analyzer analyzer_simple = new Lucene.Net.Analysis.SimpleAnalyzer();
        public Main()
        {
            InitializeComponent();

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to go back to directoryselect page ?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
            
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            label4.Text = this.GetValue();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            label4.Text = this.GetValue();
        }
        public Func<string> GetValue;

        public Action<string> SendValue;

        public Func<string, string> GetAndSend;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime beforDT = System.DateTime.Now;   
            String path = label4.Text;
            
            Searcher searcher = new Searcher(analyzer_simple);
            searcher.CreateSearcher(path);
            String queryText = Querytext.Text;
            List<String> listResult = searcher.SearchText(queryText);
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
            searcher.CleanUpSearcher();
        }
    }
}
