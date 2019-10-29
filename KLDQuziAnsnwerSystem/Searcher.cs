using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using Lucene.Net.Analysis.Snowball; // for snowball analyser 
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace KLDQuziAnsnwerSystem
{
    public class Searcher
    {
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "text";
        const string PASSAGE_ID = "passage_ID";
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Store.Directory luceneIndexDirectorySearcher;
        Lucene.Net.Analysis.Analyzer analyzer_simple = new Lucene.Net.Analysis.SimpleAnalyzer();
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        Analyzer analyzer_snowball = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English");
        IndexSearcher searcher;
        QueryParser parser;
        public Searcher()
        {
            analyzer = analyzer_simple;
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //newSimilarity = new NewSimilarity(); // Activity 9
            parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, new string[] { "text",PASSAGE_ID }, analyzer);

        }
        public string[] GetFinalqueryAndNumberofDocument(string querytext)
        {
            querytext = querytext.ToLower();
            parser.AllowLeadingWildcard = true;
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query,NewMain.resultCount);
            
 
            string[] str = new string[] { results.TotalHits.ToString(), querytext };
            return str;
        }
        public void CreateSearcher(String path)
        {
            luceneIndexDirectorySearcher = Lucene.Net.Store.FSDirectory.Open(path);
            searcher = new IndexSearcher(luceneIndexDirectorySearcher);
            //searcher.Similarity = newSimilarity; // Activity 9
        }
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }
        public void outputResult(string TopicID, string querytext, string filePath)
        {
            string textPath = filePath + @"\" + TopicID + ".txt";
            FileStream fs1 = new FileStream(textPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, NewMain.resultCount);
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValuePID = doc.Get(PASSAGE_ID).ToString();
                sw.WriteLine("{0,-4} {1,-4} {2,-7} {3,-5} {4,-11} {5}", TopicID, "Q0", myFieldValuePID, rank, scoreDoc.Score, "N10273077-N10075615-N10359613-N10130039-ATeam");
            }
            sw.Close();
            fs1.Close();
        }
        public List<string> SearchText(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            Console.WriteLine(query.ToString());
            TopDocs results = searcher.Search(query, 20);
            System.Console.WriteLine("Number of results is " + results.TotalHits);
            int rank = 0;
            List<string> listResult = new List<string>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {                
                //create a list to store the results
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                string[] sArray = myFieldValue.Split(new string[] { "URL:"}, StringSplitOptions.RemoveEmptyEntries);
                //get title from url 
                string[] words = sArray[1].Split('/');
                string title = words[words.Length - 1];
                Regex rex = new Regex(@"^\d+$");
                Regex rex1 = new Regex(@"[a-z]+\?+[a-zA-Z0-9+&@#\/%=~_|$]*");
                if (title == "")
                {
                    title = words[words.Length - 2];
                    title = title.Replace('-', ' ');
                    title = title.Replace('_', ' ');
                    int indexDot = title.IndexOf(".");
                    int indexIndex = title.IndexOf("index");
                    if (indexIndex > 0) { title = title.Remove(indexIndex); }
                    if (indexDot > 0) { title = title.Remove(indexDot); }                 
                    if (rex.IsMatch(title) || rex1.IsMatch(title))
                    {
                        title = words[words.Length - 3];
                        title = title.Replace('-', ' ');
                        title = title.Replace('_', ' ');
                    }
                }
                else
                {
                    title = title.Replace('-', ' ');
                    title = title.Replace('_', ' ');
                    int indexDot = title.IndexOf(".");
                    int indexIndex = title.IndexOf("index");
                    if (indexIndex > 0) { title = title.Remove(indexIndex); }
                    if (indexDot > 0) { title = title.Remove(indexDot);}                   
                    if (rex.IsMatch(title) || rex1.IsMatch(title))
                    {
                        title = words[words.Length - 2];
                        title = title.Replace('-', ' ');
                        title = title.Replace('_', ' ');
                    }
                }
                listResult.Add("Rank: " + rank + " Score: " + scoreDoc.Score + "\r\n"+" Title: " + title + "\r\n" + "Text: "+ sArray[0] + "\r\n"+ "URL: " + sArray[1] + "\r\n");
                //listResult.Add("Rank " + rank + " text " + myFieldValue);
                //Explanation e = searcher.Explain(query, scoreDoc.Doc); // 
            }
            return listResult;
        }
    }
}
