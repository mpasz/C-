using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\test1.txt";
            //EX1
            Console.WriteLine("Ilość słów w pliku tekstowym to : " + ReadFile(path));
            //Ex2
            DisplaytheLongestWord(path);




        }

        static int ReadFile(string path)
        {
            var content = File.ReadAllText(path);
            var wordsCount = 0;
            foreach (var word in content.Split(' '))
                wordsCount++;

            return wordsCount;
        }

        static void DisplaytheLongestWord(string Path)
        {
            var content = File.ReadAllText(Path);
            var wordsLength = 0;
            var word1 = "";
            foreach (var word in content.Split(' '))
            {
                if (word.Length > wordsLength)
                    word1 = word;
            }
            Console.WriteLine(word1);
        }


    }
}
