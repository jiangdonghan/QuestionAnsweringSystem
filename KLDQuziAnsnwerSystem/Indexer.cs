using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for document
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KLDQuziAnsnwerSystem
{
    class collection
    {
        public List<passages> passages { get; set;}
        public JArray answers { get; set; }//也可以用list
        public String query_id { get; set; }
    }
    class passages
    {
        public String url { get; set; }
        public String passage_text { get; set; }
        public String passage_ID { get; set; }

    }
    class Indexer
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        public Indexer()
        {
            luceneIndexDirectory = null; // Is set in Create Index
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();  // Is set in CreateAnalyser
            writer = null; // Is set in CreateWriter
        }
        public void OpenIndex(string indexPath)
        {
            /* Make sure to pass a new directory that does not exist */
            String Path = indexPath + "/index";
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(Path);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
        }
       
        
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }
        public void AddDocument(String queryID,String txt, String url, String answer)
        {
            //Field fId = new Field("passage_txt", p.ToString(), Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Field fQueryID = new Field("Query_ID", queryID, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Field fTxt = new Field("passage_txt",txt, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Field fUrl = new Field("passage_url", url, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Field fAnswer = new Field("Answer", answer, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            
           /* doc.Add(fQueryID);
            doc.Add(fTxt);
            doc.Add(fUrl);
            doc.Add(fAnswer);
            writer.AddDocument(doc);*/
        }
        
        //public void AddQueryID(String queryID)
        //{
        //    Field fQueryID = new Field("Query_ID", queryID, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        //    doc.Add(fQueryID);
        //}
        public void AddTxt(String txt)
        {
            Document doc = new Document();
            Field fTxt = new Field("text", txt, Field.Store.YES, Field.Index.ANALYZED);
            doc.Add(fTxt);
            writer.AddDocument(doc);
        }
        //public void AddUrl(String url)
        //{
        //    Field fUrl = new Field("passage_url", url, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        //    doc.Add(fUrl);
        //}
        //public void AddAnswer(String answer)
        //{
        //    Field fAnswer = new Field("Answer", answer, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        //    doc.Add(fAnswer);
        //}
        //to do : read json files, select correct field,add to writer
        public void IndexJsonFile(String path)
        {
            String jsonPath = path + "/collection.json";
            JsonSerializer serializer = new JsonSerializer();

            StreamReader sr = new StreamReader(jsonPath);
            JsonReader reader = new JsonTextReader(sr);
            
                while (reader.Read())
                {
                    // deserialize only when there's "{" character in the stream
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        collection c = serializer.Deserialize<collection>(reader);
                        var dictionary = new Dictionary<string, string>();
                        foreach (passages p in c.passages)
                        {
                           
                        
                        String text = p.passage_text;
                        text = text + p.url;
                        AddTxt(p.passage_text);
                            
                        
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
