﻿using System;
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

namespace KLDQuziAnsnwerSystem
{
    public class NewSearcher
    {
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "passage_txt";
        const string URL_FN = "passage_url";
        const string ANSWER_FN = "Answer";
        const string QUERY_ID_FN = "Query_ID";
        
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Store.Directory luceneIndexDirectorySearcher;
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        MultiFieldQueryParser parser;
        
        public NewSearcher()
        {
            analyzer = analyzer_standard;
            parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30,new string[] {TEXT_FN,ANSWER_FN,URL_FN}, analyzer);
        }
        
        public void CreateSearcher(String path)
        {
            luceneIndexDirectorySearcher = Lucene.Net.Store.FSDirectory.Open(path);
            searcher = new IndexSearcher(luceneIndexDirectorySearcher);
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
            string[] str = new string[] { results.TotalHits.ToString(), finalQuery };
            return str;
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
                listResult.Add("Rank: " + rank + "     Score: " + scoreDoc.Score + "\r\n" + "Title: " + title + "\r\n" +"Answer: "+myFieldValueAnswer + "\r\n" +  "Text: " + myFieldValueText + "\r\n" + "URL: " + myFieldValueURL + "\r\n");
                //listResult.Add("Rank " + rank + " text " + myFieldValue);
            }
            return listResult;
        }
    }
}