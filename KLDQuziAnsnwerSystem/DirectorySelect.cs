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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CollectionDirectoryPath.Text = dialog.FileName;
                CollectionPath = dialog.FileName;
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

        public delegate void setTextValue(string textValue);
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
                
                newmain.Show();
            }


        }

        private void DirectorySelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DirectorySelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close ?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void IndexDirectoryPath_Click(object sender, EventArgs e)
        {

        }

        private void SelectSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LabelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
