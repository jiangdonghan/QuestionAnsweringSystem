using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis;
using Syn.WordNet;

namespace KLDQuziAnsnwerSystem
{
    public partial class NewMain : Form
    {
        int TopicID = 0;
        public static float titleBoost = 1;
        public static float passageBoost = 1;

        public static bool IndexCollection = false;

        public static WordNetEngine wordNet = new WordNetEngine();

        public NewMain()
        {
            InitializeComponent();

            TitleBoostBox.Enabled = false;
            PassageBoostBox.Enabled = false;

            TitleBoostBox.Text = "1.0";
            PassageBoostBox.Text = "1.0";

            LoadDatabaseButton.Enabled = false;
        }
        public Func<string> GetValue;

        public Action<string> SendValue;

        public Func<string, string> GetAndSend;

        Main f2 = new Main();
        String IndexPath;
        String CollectionPath;
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;

        Lucene.Net.Analysis.Analyzer analyzer_simple = new Lucene.Net.Analysis.SimpleAnalyzer();
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        Analyzer analyzer_snowball = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English");

        private void NewMain_Load(object sender, EventArgs e)
        {
            //label5.Text = this.GetValue();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to go back to directoryselect page?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            
        }

        private void ButtonNewSearch_Click(object sender, EventArgs e)
        {
            
            DateTime beforDT = System.DateTime.Now;            
            String path = IndexPath;          
            NewSearcher newSearcher = new NewSearcher();

            if (TitleBoostCheckBox.Checked)
                titleBoost = float.Parse(TitleBoostBox.Text);
                titleBoost = float.Parse(TitleBoostBox.Text);

            if (PassageBoostCheckBox.Checked)
                passageBoost = float.Parse(PassageBoostBox.Text);

            // check the flag for re-indexing
            if (!IndexCollection)
                // call indexer
                indexerFunc();

            newSearcher.CreateSearcher(path);
            String queryText = QueryText.Text;
            string[] str = newSearcher.GetFinalqueryAndNumberofDocument(queryText);
            labelDocNumber.Text = str[0];
            labelFinalQuery.Text = str[1];
            List<String> listResult = newSearcher.SearchText(queryText, PhraseFormCheckbox.Checked, QueryExpansionCheckBox.Checked);
            
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
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            labelSearchingTime.Text = ts.TotalSeconds.ToString() + "s";
            newSearcher.CleanUpSearcher();
        }
        private void ButtonOutput_Click(object sender, EventArgs e)
        {
            String path = IndexPath;
            TopicID++;
            String TopicIDString = "00"+TopicID.ToString();
            String queryText = QueryText.Text;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Choose a path to save output";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                NewSearcher newsearcher = new NewSearcher();
                newsearcher.CreateSearcher(path);
                newsearcher.outputResult(TopicIDString, queryText, foldPath);
                MessageBox.Show("Result Successfully Saved");
            }                     
        }

        private void ButtonIndexSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "please choose the file path for lucene index";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                IndexDirectoryPath.Text = dialog.SelectedPath;
                IndexPath = dialog.SelectedPath;

            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCollectionSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CollectionDirectoryPath.Text = dialog.FileName;
                CollectionPath = dialog.FileName;
            }
        }

        public void indexerFunc() {            
            if (SelectSystem.Checked)
            {
                DateTime beforDT = System.DateTime.Now;
                Indexer myIndex = new Indexer(analyzer_simple);
                myIndex.OpenIndex(IndexPath);
                myIndex.IndexJsonFile(CollectionPath);
                myIndex.CleanUpIndexer();
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                labelTime.Text = "Indexing Time: " + ts.TotalSeconds.ToString() + "s";
            }
            else
            {
                DateTime beforDT = System.DateTime.Now;
                NewIndexer myIndex = new NewIndexer();
                myIndex.OpenIndex(IndexPath);
                myIndex.IndexJsonFile(CollectionPath);
                myIndex.CleanUpIndexer();
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                labelTime.Text = "Indexing Time: " + ts.TotalSeconds.ToString() + "s";
            }

            IndexCollection = true;
        }

        private void IndexCreate_Click(object sender, EventArgs e)
        {
            //if (SelectSystem.Checked)
            //{
            //    DateTime beforDT = System.DateTime.Now;
            //    Indexer myIndex = new Indexer(analyzer_simple);
            //    myIndex.OpenIndex(IndexPath);
            //    myIndex.IndexJsonFile(CollectionPath);
            //    myIndex.CleanUpIndexer();
            //    DateTime afterDT = System.DateTime.Now;
            //    TimeSpan ts = afterDT.Subtract(beforDT);
            //    labelTime.Text = "Indexing Time: " + ts.TotalSeconds.ToString() + "s";
            //}
            //else
            //{
            //    DateTime beforDT = System.DateTime.Now;
            //    NewIndexer myIndex = new NewIndexer();
            //    myIndex.OpenIndex(IndexPath);
            //    myIndex.IndexJsonFile(CollectionPath);
            //    myIndex.CleanUpIndexer();
            //    DateTime afterDT = System.DateTime.Now;
            //    TimeSpan ts = afterDT.Subtract(beforDT);
            //    labelTime.Text = "Indexing Time: " + ts.TotalSeconds.ToString() + "s";
            //}
            indexerFunc();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelTime_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxPassage_CheckedChanged(object sender, EventArgs e)
        {
            if (PassageBoostCheckBox.Checked)
            {
                PassageBoostBox.Enabled = true;

                IndexCollection = false;
            }
            else
            {
                PassageBoostBox.Enabled = false;
                passageBoost = 1;
            }
        }

        private void CheckBoxTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleBoostCheckBox.Checked)
            {
                TitleBoostBox.Enabled = true;

                IndexCollection = false;
            }
            else
            {
                TitleBoostBox.Enabled = false;
                titleBoost = 1;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (QueryExpansionCheckBox.Checked && !wordNet.IsLoaded)
            {
                MessageBox.Show("Please load wordnet database");
                LoadDatabaseButton.Enabled = true;
            }
            else
            {
                LoadDatabaseButton.Enabled = false;
            }
        }

        private void LoadDatabaseButton_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"wordnet");
            MessageBox.Show("Loading database");
            wordNet.LoadFromDirectory(directoryPath);
            MessageBox.Show("Load completed");
            LoadDatabaseButton.Text = "Database is loaded.";
            LoadDatabaseButton.Enabled = false;
        }

        private void PhraseFormCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IndexCreate_Click_1(object sender, EventArgs e)
        {
            indexerFunc();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
