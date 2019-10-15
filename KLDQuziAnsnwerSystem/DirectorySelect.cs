using Lucene.Net.Analysis;
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
    
    public partial class DirectorySelect : Form
    {
        Main f2= new Main();
        String IndexPath;
        String CollectionPath;
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        
        Lucene.Net.Analysis.Analyzer analyzer_simple = new Lucene.Net.Analysis.SimpleAnalyzer();
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        Analyzer analyzer_snowball = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English");
        public DirectorySelect()
        {
            InitializeComponent();
            
        }        
        private void ButtonCollectionSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please choose the file path for collection";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CollectionDirectoryPath.Text = dialog.SelectedPath;
                CollectionPath = dialog.SelectedPath;
            }         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
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
        private void IndexCreate_Click(object sender, EventArgs e)
        {
            if (SelectSystem.Checked) {
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
                labelTime.Text = "Indexing Time: "+ts.TotalSeconds.ToString() + "s";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DirectorySelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public delegate void setTextValue(string textValue);
        public event setTextValue setFormTextValue;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (SelectSystem.Checked)
            {
                string inputValue = IndexDirectoryPath.Text.Trim();
                Main main = new Main();
                main.GetValue = delegate () {
                    return inputValue;
                };
                main.SendValue = delegate (string a) {
                    this.IndexDirectoryPath.Text = a;
                };
                main.GetAndSend = delegate (string a) {
                    string formValue = this.IndexDirectoryPath.Text;
                    this.IndexDirectoryPath.Text = a;
                    return formValue;
                };                
                this.Close();
                main.Show();              
            }
            else
            {
                string inputValue = IndexDirectoryPath.Text.Trim();
                NewMain newmain = new NewMain();
                newmain.GetValue = delegate () {
                    return inputValue;
                };
                newmain.SendValue = delegate (string a) {
                    this.IndexDirectoryPath.Text = a;
                };
                newmain.GetAndSend = delegate (string a) {
                    string formValue = this.IndexDirectoryPath.Text;
                    this.IndexDirectoryPath.Text = a;
                    return formValue;
                };
                this.Close();
                newmain.Show();
            }


        }
    }
}
