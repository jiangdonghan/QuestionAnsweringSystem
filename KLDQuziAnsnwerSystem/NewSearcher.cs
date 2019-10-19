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
    public class NewSearcher
    {
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "passage_txt";
        const string URL_FN = "passage_url";
        const string ANSWER_FN = "Answer";
        const string PASSAGE_ID = "passage_ID";
        
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Store.Directory luceneIndexDirectorySearcher;
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        IndexSearcher searcher;
        MultiFieldQueryParser parser;
        
        public NewSearcher()
        {
            analyzer = analyzer_standard;
            parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30,new string[] {TEXT_FN,ANSWER_FN,URL_FN,PASSAGE_ID}, analyzer);
        }
        
        public void CreateSearcher(String path)
        {
            luceneIndexDirectorySearcher = Lucene.Net.Store.FSDirectory.Open(path);
            searcher = new IndexSearcher(luceneIndexDirectorySearcher);
            searcher.Similarity = new NewSimilarity();
        }
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }
        public string[] GetFinalqueryAndNumberofDocument(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 20);
            string finalQuery = query.ToString();
            string[] querySplit = finalQuery.Split(')');
    
            for(int i = 0; i < querySplit.Length; i++)
            {
                querySplit[i] = querySplit[i].Replace("(", string.Empty).Replace("passage_txt", string.Empty).Replace("passage_url", string.Empty).Replace("passage_ID", string.Empty).Replace("Answer", string.Empty).Replace(":", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty);
            }
            finalQuery = "";
            for (int i = 0; i < querySplit.Length; i++)
            {
                finalQuery += querySplit[i];
            }
            string[] ss = finalQuery.Split(' ');
            finalQuery = "";
            for(int i = 0; i < ss.Length; i += 4)
            {
                finalQuery += (ss[i]+" ");
            }
            string[] str = new string[] { results.TotalHits.ToString(), finalQuery };
            return str;
        }
        public void outputResult(string TopicID,string querytext,string filePath)
        {
            string textPath = filePath + @"\" + TopicID + ".txt";
            FileStream fs1 = new FileStream(textPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 20);
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValuePID = doc.Get(PASSAGE_ID).ToString();                
                sw.WriteLine("{0,-4} {1,-4} {2,-7} {3,-5} {4,-11} {5}", TopicID, "Q0", myFieldValuePID, rank, scoreDoc.Score, "n10075615_n_n_Team");
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
            int rank = 0;
            List<string> listResult = new List<string>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                //create a list to store the results
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValuePID = doc.Get(PASSAGE_ID).ToString();
                string myFieldValueText = doc.Get(TEXT_FN).ToString();
                string myFieldValueAnswer = doc.Get(ANSWER_FN).ToString();
                myFieldValueAnswer = myFieldValueAnswer.Replace("[", string.Empty).Replace("]", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty);
                string myFieldValueURL = doc.Get(URL_FN).ToString();               
                //get title from url 
                string[] words = myFieldValueURL.Split('/');
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
                    if (indexDot > 0) { title = title.Remove(indexDot); }

                    if (rex.IsMatch(title) || rex1.IsMatch(title))
                    {
                        title = words[words.Length - 2];
                        title = title.Replace('-', ' ');
                        title = title.Replace('_', ' ');
                    }
                }
                listResult.Add("Rank: " + rank + "     Score: " + scoreDoc.Score +"      passage_id: "+myFieldValuePID+ "\r\n" + "Title: " + title + "\r\n" +"Answer: "+myFieldValueAnswer + "\r\n" +  "Text: " + myFieldValueText + "\r\n" + "URL: " + myFieldValueURL + "\r\n");
                //listResult.Add("Rank " + rank + " text " + myFieldValue);
            }
            return listResult;
        }
    }
}
