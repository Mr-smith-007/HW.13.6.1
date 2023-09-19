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
            LinkedList<string> linkedListWords = new LinkedList<string>();
            string[] words;

            string path = @"C:\Users\repnikov.a\Desktop\Text_13_6_1.txt";
            using (var sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().ToLower();

                text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

                words = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            }
            linkedListWords.AddFirst("1");
            var watch = Stopwatch.StartNew();
            foreach (var word in words)
                linkedListWords.AddAfter(linkedListWords.First, word);
            Console.WriteLine($"Вставка в LinkedList<T> заняла: {watch.Elapsed.TotalMilliseconds} мс");

            Console.ReadKey();
        }

    }
}