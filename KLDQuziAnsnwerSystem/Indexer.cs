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
        public JArray answers { get; set; }
        public String query_id { get; set; }
        public String query { get; set; }
    }
    class passages
    {
        public String url { get; set; }
        public String passage_text { get; set; }
        public String passage_ID { get; set; }

    }
    public class Indexer
    {
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Store.Directory luceneIndexDirectory;
        
        Lucene.Net.Index.IndexWriter writer;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        public Indexer(Analyzer an)
        {
            luceneIndexDirectory = null; // Is set in Create Index
            analyzer = an;  // Is set in CreateAnalyser
            writer = null; // Is set in CreateWriter
        }
        public void OpenIndex(string indexPath)
        {
            /* Make sure to pass a new directory that does not exist */
            String Path = indexPath;
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
        public void AddTxt(String txt)
        {
            Document doc = new Document();
            Field fTxt = new Field("text", txt, Field.Store.YES, Field.Index.ANALYZED);
            doc.Add(fTxt);
            writer.AddDocument(doc);
        }
        public void IndexJsonFile(String path)
        {
            String jsonPath = path + "/sample_collection.json";
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
                        text = text + "URL: " +  p.url;
                        AddTxt(text);                     
                        }
                    }
                }
        }
    }
    
}
