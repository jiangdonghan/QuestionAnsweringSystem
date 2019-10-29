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
        public static string expandedQueryConcatenation;
        public static WordNetEngine wordNet = new WordNetEngine();
        public static int resultCount = 20;
        public NewMain()
        {
            InitializeComponent();
            
            TitleBoostBox.Enabled = false;
            PassageBoostBox.Enabled = false;
            textBoxResultCount.Text = "20";
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
            if (MessageBox.Show("Do you want to close the application ?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (SelectSystem.Checked)
            {
                DateTime beforDT = System.DateTime.Now;
                String path = IndexPath;
                Searcher Searcher = new Searcher();
                string intString = textBoxResultCount.Text;
                int i = 0;
                if (!Int32.TryParse(intString, out i))
                {
                    i = -1;
                }
                if (i > 0) { resultCount = i; }
                else
                {
                    MessageBox.Show("please enter integer");
                }


                if (TitleBoostCheckBox.Checked)
                    titleBoost = float.Parse(TitleBoostBox.Text);
                titleBoost = float.Parse(TitleBoostBox.Text);

                if (PassageBoostCheckBox.Checked)
                    passageBoost = float.Parse(PassageBoostBox.Text);

                // check the flag for re-indexing
                if (!IndexCollection)
                    // call indexer
                    indexerFunc();

               Searcher.CreateSearcher(path);
                String queryText = QueryText.Text;
                queryText = QueryPrecessor.CleanSearchedWords(queryText);
                string[] str = Searcher.GetFinalqueryAndNumberofDocument(queryText);
                labelDocNumber.Text = str[0];
                richFinalQuery.Text = str[1];
                
                List<String> listResult = Searcher.SearchText(queryText);
                
                ResultTextBox.Lines = listResult.ToArray();
                int len = ResultTextBox.TextLength;
                int index = 0;
                int lastIndex = ResultTextBox.Text.LastIndexOf(queryText);
                while (index < lastIndex)
                {
                    ResultTextBox.Find(queryText, index, len, RichTextBoxFinds.None);
                    ResultTextBox.SelectionBackColor = Color.Turquoise;
                    index = ResultTextBox.Text.IndexOf(queryText, index) + 1;
                }
                var querySplit = TokeniseString(queryText);

                if (querySplit.Count() > 0)
                {
                    foreach (string s in querySplit)
                    {
                        int index_split = 0;
                        int lastIndex_Split = ResultTextBox.Text.LastIndexOf(s);
                        while (index_split < lastIndex_Split)
                        {
                            ResultTextBox.Find(s, index_split, len, RichTextBoxFinds.None);
                            ResultTextBox.SelectionBackColor = Color.Turquoise;
                            index_split = ResultTextBox.Text.IndexOf(s, index_split) + 1;
                        }
                    }
                }

                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                labelSearchingTime.Text = ts.TotalSeconds.ToString() + "s";
                Searcher.CleanUpSearcher();
            }
            else
            {
                DateTime beforDT = System.DateTime.Now;
                String path = IndexPath;
                NewSearcher newSearcher = new NewSearcher();
                string intString = textBoxResultCount.Text;
                int i = 0;
                if (!Int32.TryParse(intString, out i))
                {
                    i = -1;
                }
                if (i > 0) { resultCount = i; }
                else
                {
                    MessageBox.Show("please enter integer");
                }


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
                if (!PhraseFormCheckbox.Checked)
                {
                    queryText = QueryPrecessor.CleanSearchedWords(queryText);
                }
                
                string[] str = newSearcher.GetFinalqueryAndNumberofDocument(queryText);
                labelDocNumber.Text = str[0];
                richFinalQuery.Text = str[1];

                List<String> listResult = newSearcher.SearchText(queryText, PhraseFormCheckbox.Checked, QueryExpansionCheckBox.Checked);
                if (QueryExpansionCheckBox.Checked)
                {
                    richFinalQuery.Text = expandedQueryConcatenation;
                }
                if (PhraseFormCheckbox.Checked)
                {
                    richFinalQuery.Text = queryText;
                }
                ResultTextBox.Lines = listResult.ToArray();
                int len = ResultTextBox.TextLength;
                int index = 0;
                int lastIndex = ResultTextBox.Text.LastIndexOf(queryText);
                while (index < lastIndex)
                {
                    ResultTextBox.Find(queryText, index, len, RichTextBoxFinds.None);
                    ResultTextBox.SelectionBackColor = Color.Turquoise;
                    index = ResultTextBox.Text.IndexOf(queryText, index) + 1;
                }
                var querySplit = TokeniseString(queryText);

                if (querySplit.Count() > 0)
                {
                    foreach (string s in querySplit)
                    {
                        int index_split = 0;
                        int lastIndex_Split = ResultTextBox.Text.LastIndexOf(s);
                        while (index_split < lastIndex_Split)
                        {
                            ResultTextBox.Find(s, index_split, len, RichTextBoxFinds.None);
                            ResultTextBox.SelectionBackColor = Color.Turquoise;
                            index_split = ResultTextBox.Text.IndexOf(s, index_split) + 1;
                        }
                    }
                }

                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                labelSearchingTime.Text = ts.TotalSeconds.ToString() + "s";
                newSearcher.CleanUpSearcher();
            }
            
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
                if (SelectSystem.Checked)
                {
                    Searcher searcher = new Searcher();
                    searcher.CreateSearcher(path);
                    searcher.outputResult(TopicIDString, queryText, foldPath);
                    MessageBox.Show("Result Successfully Saved");
                }
                else
                {
                    NewSearcher newsearcher = new NewSearcher();
                    newsearcher.CreateSearcher(path);
                    newsearcher.outputResult(TopicIDString, queryText, foldPath);
                    MessageBox.Show("Result Successfully Saved");
                }
                
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
            MessageBox.Show("Indexing of the colection has started!");
            
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

            MessageBox.Show("Indexing of the colection is Complete!");
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

                PhraseFormCheckbox.Checked = false;
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
            if (PhraseFormCheckbox.Checked)
            {
                QueryExpansionCheckBox.Checked = false;
            }
            
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

        public List<string> TokeniseString(String text)
        {
            char[] delimeters = { ' ', '\'', '!', '.', '-', ',' ,'\t',':','\n','\r'};
            List<string> stopWordList = new List<string>()
            {
                "a",
                "able",
                "about",
                "above",
                "according",
                "accordingly",
                "across",
                "actually",
                "after",
                "afterwards",
                "again",
                "against",
                "ain't",
                "all",
                "allow",
                "allows",
                "almost",
                "alone",
                "along",
                "already",
                "also",
                "although",
                "always",
                "am",
                "among",
                "amongst",
                "an",
                "and",
                "another",
                "any",
                "anybody",
                "anyhow",
                "anyone",
                "anything",
                "anyway",
                "anyways",
                "anywhere",
                "apart",
                "appear",
                "appreciate",
                "appropriate",
                "are",
                "aren't",
                "around",
                "as",
                "a's",
                "aside",
                "ask",
                "asking",
                "associated",
                "at",
                "available",
                "away",
                "awfully",
                "be",
                "became",
                "because",
                "become",
                "becomes",
                "becoming",
                "been",
                "before",
                "beforehand",
                "behind",
                "being",
                "believe",
                "below",
                "beside",
                "besides",
                "best",
                "better",
                "between",
                "beyond",
                "both",
                "brief",
                "but",
                "by",
                "came",
                "can",
                "cannot",
                "cant",
                "can't",
                "cause",
                "causes",
                "certain",
                "certainly",
                "changes",
                "clearly",
                "c'mon",
                "co",
                "com",
                "come",
                "comes",
                "concerning",
                "consequently",
                "consider",
                "considering",
                "contain",
                "containing",
                "contains",
                "corresponding",
                "could",
                "couldn't",
                "course",
                "c's",
                "currently",
                "definitely",
                "described",
                "despite",
                "did",
                "didn't",
                "different",
                "do",
                "does",
                "doesn't",
                "doing",
                "done",
                "don't",
                "down",
                "downwards",
                "during",
                "each",
                "edu",
                "eg",
                "eight",
                "either",
                "else",
                "elsewhere",
                "enough",
                "entirely",
                "especially",
                "et",
                "etc",
                "even",
                "ever",
                "every",
                "everybody",
                "everyone",
                "everything",
                "everywhere",
                "ex",
                "exactly",
                "example",
                "except",
                "far",
                "few",
                "fifth",
                "first",
                "five",
                "followed",
                "following",
                "follows",
                "for",
                "former",
                "formerly",
                "forth",
                "four",
                "from",
                "further",
                "furthermore",
                "get",
                "gets",
                "getting",
                "given",
                "gives",
                "go",
                "goes",
                "going",
                "gone",
                "got",
                "gotten",
                "greetings",
                "had",
                "hadn't",
                "happens",
                "hardly",
                "has",
                "hasn't",
                "have",
                "haven't",
                "having",
                "he",
                "he'd",
                "he'll",
                "hello",
                "help",
                "hence",
                "her",
                "here",
                "hereafter",
                "hereby",
                "herein",
                "here's",
                "hereupon",
                "hers",
                "herself",
                "he's",
                "hi",
                "him",
                "himself",
                "his",
                "hither",
                "hopefully",
                "how",
                "howbeit",
                "however",
                "how's",
                "i",
                "i'd",
                "ie",
                "if",
                "ignored",
                "i'll",
                "i'm",
                "immediate",
                "in",
                "inasmuch",
                "inc",
                "indeed",
                "indicate",
                "indicated",
                "indicates",
                "inner",
                "insofar",
                "instead",
                "into",
                "inward",
                "is",
                "isn't",
                "it",
                "it'd",
                "it'll",
                "its",
                "it's",
                "itself",
                "i've",
                "just",
                "keep",
                "keeps",
                "kept",
                "know",
                "known",
                "knows",
                "last",
                "lately",
                "later",
                "latter",
                "latterly",
                "least",
                "less",
                "lest",
                "let",
                "let's",
                "like",
                "liked",
                "likely",
                "little",
                "look",
                "looking",
                "looks",
                "ltd",
                "mainly",
                "many",
                "may",
                "maybe",
                "me",
                "mean",
                "meanwhile",
                "merely",
                "might",
                "more",
                "moreover",
                "most",
                "mostly",
                "much",
                "must",
                "mustn't",
                "my",
                "myself",
                "name",
                "namely",
                "nd",
                "near",
                "nearly",
                "necessary",
                "need",
                "needs",
                "neither",
                "never",
                "nevertheless",
                "new",
                "next",
                "nine",
                "no",
                "nobody",
                "non",
                "none",
                "noone",
                "nor",
                "normally",
                "not",
                "nothing",
                "novel",
                "now",
                "nowhere",
                "obviously",
                "of",
                "off",
                "often",
                "oh",
                "ok",
                "okay",
                "old",
                "on",
                "once",
                "one",
                "ones",
                "only",
                "onto",
                "or",
                "other",
                "others",
                "otherwise",
                "ought",
                "our",
                "ours",
                "ourselves",
                "out",
                "outside",
                "over",
                "overall",
                "own",
                "particular",
                "particularly",
                "per",
                "perhaps",
                "placed",
                "please",
                "plus",
                "possible",
                "presumably",
                "probably",
                "provides",
                "que",
                "quite",
                "qv",
                "rather",
                "rd",
                "re",
                "really",
                "reasonably",
                "regarding",
                "regardless",
                "regards",
                "relatively",
                "respectively",
                "right",
                "said",
                "same",
                "saw",
                "say",
                "saying",
                "says",
                "second",
                "secondly",
                "see",
                "seeing",
                "seem",
                "seemed",
                "seeming",
                "seems",
                "seen",
                "self",
                "selves",
                "sensible",
                "sent",
                "serious",
                "seriously",
                "seven",
                "several",
                "shall",
                "shan't",
                "she",
                "she'd",
                "she'll",
                "she's",
                "should",
                "shouldn't",
                "since",
                "six",
                "so",
                "some",
                "somebody",
                "somehow",
                "someone",
                "something",
                "sometime",
                "sometimes",
                "somewhat",
                "somewhere",
                "soon",
                "sorry",
                "specified",
                "specify",
                "specifying",
                "still",
                "sub",
                "such",
                "sup",
                "sure",
                "take",
                "taken",
                "tell",
                "tends",
                "th",
                "than",
                "thank",
                "thanks",
                "thanx",
                "that",
                "thats",
                "that's",
                "the",
                "their",
                "theirs",
                "them",
                "themselves",
                "then",
                "thence",
                "there",
                "thereafter",
                "thereby",
                "therefore",
                "therein",
                "theres",
                "there's",
                "thereupon",
                "these",
                "they",
                "they'd",
                "they'll",
                "they're",
                "they've",
                "think",
                "third",
                "this",
                "thorough",
                "thoroughly",
                "those",
                "though",
                "three",
                "through",
                "throughout",
                "thru",
                "thus",
                "to",
                "together",
                "too",
                "took",
                "toward",
                "towards",
                "tried",
                "tries",
                "truly",
                "try",
                "trying",
                "t's",
                "twice",
                "two",
                "un",
                "under",
                "unfortunately",
                "unless",
                "unlikely",
                "until",
                "unto",
                "up",
                "upon",
                "us",
                "use",
                "used",
                "useful",
                "uses",
                "using",
                "usually",
                "value",
                "various",
                "very",
                "via",
                "viz",
                "vs",
                "want",
                "wants",
                "was",
                "wasn't",
                "way",
                "we",
                "we'd",
                "welcome",
                "well",
                "we'll",
                "went",
                "were",
                "we're",
                "weren't",
                "we've",
                "what",
                "whatever",
                "what's",
                "when",
                "whence",
                "whenever",
                "when's",
                "where",
                "whereafter",
                "whereas",
                "whereby",
                "wherein",
                "where's",
                "whereupon",
                "wherever",
                "whether",
                "which",
                "while",
                "whither",
                "who",
                "whoever",
                "whole",
                "whom",
                "who's",
                "whose",
                "why",
                "why's",
                "will",
                "willing",
                "wish",
                "with",
                "within",
                "without",
                "wonder",
                "won't",
                "would",
                "wouldn't",
                "yes",
                "yet",
                "you",
                "you'd",
                "you'll",
                "your",
                "you're",
                "yours",
                "yourself",
                "yourselves",
                "you've",
                "zero"
            };

            var tokens = text.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            List<string> tokenlist = new List<string>(tokens);

            foreach (string s in tokens)
            {
                if (stopWordList.Contains(s))
                {
                    tokenlist.Remove(s);
                }
            }

            return tokenlist;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassageBoostBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
