using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Single_Responsibility_Principle
{
    public class WordGenerator
    {

        public string WordSelector()
        {
            var textFile = File.ReadAllText(@"C:\Users\Jerick\Desktop\Project Templates\C#\SOLID Coding\1.S\Single_Responsibility_Principle\Single_Responsibility_Principle\HangManWords.txt");

            string[] words = textFile.Split(Environment.NewLine);

            var output = words[new Random().Next(words.Length)];

            return output;
        }
    }
}
