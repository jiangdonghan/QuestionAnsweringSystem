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

        String IndexPath;
        String CollectionPath;
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
            DateTime beforDT = System.DateTime.Now;
            Indexer myIndex = new Indexer();
            myIndex.OpenIndex(IndexPath);
            myIndex.IndexJsonFile(CollectionPath);
            myIndex.CleanUpIndexer();
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            MessageBox.Show("Indexing Time: "+ ts.TotalMilliseconds.ToString() +"ms");
            Main main = new Main();
            this.Close();
            main.Show();
            

        }
    }
}
