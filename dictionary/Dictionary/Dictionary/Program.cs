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
            Console.WriteLine("Type in a hungarian word: ");
            string hungarianWord = Console.ReadLine();
            Console.WriteLine("Type in the english translation of the word: ");
            string englishWord = Console.ReadLine();
            AddWord(hungarianWord, englishWord);
        }

        public static void AddWord(string hungarianWord, string englishWord)
        {
            foreach 
            Dictionary.Add(hungarianWord, englishWord);
        }

        public static string TranslateToEnglish(string hungarian)
        {
            var key = Console.ReadLine();
            var value = "";
            var dicVal = string.Empty;
            if (Dictionary.TryGetValue(key, out dicVal) && dicVal.Contains(value))
            {
                return value;
            }
        }

    }
}
