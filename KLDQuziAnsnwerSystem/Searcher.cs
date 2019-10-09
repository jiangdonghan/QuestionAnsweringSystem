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
    class Searcher
    {
        Lucene.Net.Store.Directory luceneIndexDirectorySearcher;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "text";

        public Searcher()
        {
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer(); // Activity 5
            //analyzer = new Lucene.Net.Analysis.StopAnalyzer(); // Activity 5
            //analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30); // Activity 5
            //analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English"); // Activity 7

            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //newSimilarity = new NewSimilarity(); // Activity 9

        }
        public void CreateSearcher(String path)
        {
            luceneIndexDirectorySearcher = Lucene.Net.Store.FSDirectory.Open(path);
            searcher = new IndexSearcher(luceneIndexDirectorySearcher);
            //searcher.Similarity = newSimilarity; // Activity 9
        }
        public void SearchText(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 100);
            System.Console.WriteLine("Number of results is " + results.TotalHits);
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                // Console.WriteLine("Rank " + rank + " score " + scoreDoc.Score + " text " + myFieldValue); // Activity 8
                Console.WriteLine("Rank " + rank + " text " + myFieldValue);

                //Explanation e = searcher.Explain(query, scoreDoc.Doc); // Activity 8
                //System.Console.WriteLine(e.ToString());

            }


        }
    }
}
