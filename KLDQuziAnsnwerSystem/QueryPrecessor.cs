using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

public class QueryPrecessor
{
    
        private static string[] stopWordsArrary = new string[] { "a", "about", "actually", "after", "also", "am", "an", "and", "any", "are", "as", "at", "be", "because", "but", "by", 
                                                "could", "do", "each", "either", "en", "for", "from", "has", "have", "how", 
                                                "i", "if", "in", "is", "it", "its", "just", "of", "or", "so", "some", "such", "that", 
                                                "the", "their", "these", "thing", "this", "to", "too", "very", "was", "we", "well", "what", "when", "where",
                                                "who", "will", "with", "you", "your" 
                                            };

        /// <summary>
		/// Removes stop words from the specified search string.
		/// </summary>
		public static string CleanSearchedWords(string searchedWords)
		{

			searchedWords = searchedWords
											.Replace("\\", string.Empty)
											.Replace("|", string.Empty)
											.Replace("(", string.Empty)
											.Replace(")", string.Empty)
											.Replace("[", string.Empty)
											.Replace("]", string.Empty)
											.Replace("*", string.Empty)
											.Replace("?", string.Empty)
											.Replace("}", string.Empty)
											.Replace("{", string.Empty)
											.Replace("^", string.Empty)
											.Replace("+", string.Empty);

            // transform search string into array of words
            char[] wordSeparators = new char[] { ' ', '\n', '\r', ',', ';', '.', '!', '?', '-', ' ', '"', '\'' };
            string[] words = searchedWords.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

            // Create and initializes a new StringCollection.
             StringCollection myStopWordsCol = new StringCollection();
            // Add a range of elements from an array to the end of the StringCollection.
             myStopWordsCol.AddRange(stopWordsArrary);

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i].ToLowerInvariant().Trim();
                if (word.Length > 1 && !myStopWordsCol.Contains(word))
					sb.Append(word + " ");
			}

			return sb.ToString();
		}
}
