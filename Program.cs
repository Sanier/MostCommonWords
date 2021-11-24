using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MostCommonWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<string>();

            string text = File.ReadAllText("C:\\Users\\sanie\\Desktop\\Text1.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            list.AddRange(words);
            list.Sort();

            var ted = new List<Part>();

            foreach (string val in list.Distinct().OrderBy(x => x))
            {
                int count = list.Count(x => x == val);
                ted.Add(new Part { Word = val, Val = count });
            }

            ted.Sort();
            ted.Reverse();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ted[i]);
            }
        }
    }
}
