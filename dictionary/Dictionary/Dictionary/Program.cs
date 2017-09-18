using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };
        }

        public static void AddWord(string hungarianWord, string englishWord)
        {
            Dictionary.Add(hungarianWord, englishWord);
        }

        public static string TranslateToEnglish(string hungarian)
        {
            
        }

    }
}
