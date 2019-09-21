using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Socument
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Newtonsoft.Json;

namespace KLDQuziAnsnwerSystem
{

    class indexing
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        public indexing()
        {
            luceneIndexDirectory = null; // Is set in Create Index
            analyzer = null;  // Is set in CreateAnalyser
            writer = null; // Is set in CreateWriter
        }
        public void OpenIndex(string indexPath)
        {
            /* Make sure to pass a new directory that does not exist */
            String Path = indexPath + "/index";
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(Path);
        }
        public void CreateSimpleAnalyser()//only for the baseline system
        {
            analyzer = new SimpleAnalyzer();
        }
        public void CreateWriter()
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
        }
        public void CleanUp()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }
        //to do : read json files, select correct field,add to writer
        public void IndexJsonFile(String path)
        {
            String jsonPath = path + "/collection.json";
            JsonSerializer serializer = new JsonSerializer();
            using (FileStream s = File.Open(jsonPath, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                while (reader.Read())
                {
                    // deserialize only when there's "{" character in the stream
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        //can't index json file here
                        var p = serializer.Deserialize<object>(reader);
                        Field f1 = new Field("Test", p.ToString(), Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                        Document d1 = new Document();
                        d1.Add(f1);
                        writer.AddDocument(d1);
                    }
                }
            }


            //loop the directory and get the json file
            /*
             *          int count = 0;
                        foreach (System.IO.FileInfo file in files)
                        {
                            count++;
                            if(count > 1)
                            {
                                MessageBox.Show("More than one collection,system will only index the first collection");
                                break;//need to be changed
                            }
                            String jsonPath = file.Name;
                            JsonSerializer serializer = new JsonSerializer();
                            using (FileStream s = File.Open(jsonPath, FileMode.Open))
                            using (StreamReader sr = new StreamReader(s))
                            using (JsonReader reader = new JsonTextReader(sr))
                            {
                                while (reader.Read())
                                {
                                    // deserialize only when there's "{" character in the stream
                                    if (reader.TokenType == JsonToken.StartObject)
                                    {
                                        var p = serializer.Deserialize<object>(reader);
                                        Field f1 = new Field("Test", p.ToString(), Field.Store.NO,             Field.Index.ANALYZED,                               Field.TermVector.WITH_POSITIONS_OFFSETS);
                                        Document d1 = new Document();
                                        d1.Add(f1);
                                        writer.AddDocument(d1);
                                    }
                                }
                            }
                         }
                     */


        
            

        }
    }
    
}
