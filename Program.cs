using System;
using System.IO;
using System.Linq;

namespace MostCommonWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\sanie\\Desktop\\Text1.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
