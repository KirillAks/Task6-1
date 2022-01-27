using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        // Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
        // Знаки препинания не используются. Найти самое длинное слово в строке.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, слова разделены пробелом");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();
            string word = "";
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (sentenceArray[i].Length >= word.Length)
                {
                    word = sentenceArray[i];
                }
            }
            foreach (string longWord in sentenceArray)
            {
                int buffer = Convert.ToInt32(longWord.Length);
                int maxBuffer = Convert.ToInt32(word.Length);
                if (buffer == maxBuffer)                
                {
                    Console.WriteLine("Самое длинное слово в строке: {0}", longWord);                    
                }                
            }
            Console.ReadKey();
        }
    }
}
