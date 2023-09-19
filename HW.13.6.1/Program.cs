using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Project_13._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listWords = new List<string>();
            string[] words;

            string path = @"C:\Users\repnikov.a\Desktop\Text_13_6_1.txt";
            using (var sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().ToLower();

                text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

                words = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            }

            var watch = Stopwatch.StartNew();
            foreach(var word in words)
                listWords.Add(word);
            Console.WriteLine($"Вставка в List<T> заняла: {watch.Elapsed.TotalMilliseconds} мс");

            Console.ReadKey();
        }
               
    }
}