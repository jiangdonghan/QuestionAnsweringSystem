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

namespace KLDQuziAnsnwerSystem
{
    public class Searcher
    {
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "text";
        
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Store.Directory luceneIndexDirectorySearcher;
        Lucene.Net.Analysis.Analyzer analyzer_simple = new Lucene.Net.Analysis.SimpleAnalyzer();
        Analyzer analyzer_standard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
        Analyzer analyzer_snowball = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English");
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        public Searcher(Analyzer an)
        {
            analyzer = an;
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //newSimilarity = new NewSimilarity(); // Activity 9

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
        public List<string> SearchText(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 100);
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
                listResult.Add("Rank " + rank + " score " + scoreDoc.Score + "\r\n"+" text " + sArray[0] + "\r\n"+ "URL: " + sArray[1] ); // Activity 8
                //listResult.Add("Rank " + rank + " text " + myFieldValue);

                //Explanation e = searcher.Explain(query, scoreDoc.Doc); // Activity 8
                //System.Console.WriteLine(e.ToString());

            }
            return listResult;


        }
    }
}
