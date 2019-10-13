﻿using System;
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

    public class NewIndexer
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        public NewIndexer()
        {
            luceneIndexDirectory = null; // Is set in Create Index
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);  // Is set in CreateAnalyser
            writer = null; // Is set in CreateWriter
        }
        public void OpenIndex(string indexPath)
        {
            /* Make sure to pass a new directory that does not exist */
            String Path = indexPath + "/index_non_base";
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
        public void AddDocument(String queryID, String txt, String url, String answer, String query)
        {
            Document doc = new Document();
            
            //Field fQueryID = new Field("Query_ID", queryID, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            //doc.Add(fQueryID);

            Field fTxt = new Field("passage_txt", txt, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            doc.Add(fTxt);
            
            //Field fUrl = new Field("passage_url", url, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            //doc.Add(fUrl);

            Field fAnswer = new Field("Answer", answer, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            doc.Add(fAnswer);


            Field fQuery = new Field("query", query, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            doc.Add(fQuery);


            writer.AddDocument(doc);
        }

        //public void AddQueryID(String queryID)
        //{
        //    Field fQueryID = new Field("Query_ID", queryID, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        //    doc.Add(fQueryID);
        //}
        public void AddTxt(String txt)
        {
            Document doc = new Document();
            Field fTxt = new Field("text", txt, Field.Store.NO, Field.Index.ANALYZED);
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
                    foreach (passages p in c.passages)
                    {
                        AddDocument(c.query_id, p.passage_text, p.url, c.answers.ToString(), c.query);
                    }
                }
            }
        }
    }

}