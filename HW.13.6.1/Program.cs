using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        List<string> listWords = new List<string>();
        LinkedList<string> linkedListWords = new LinkedList<string>();
        string[] words;

        string path = @"C:\Users\repnikov.a\Desktop\Text_13_6_1.txt";
        using (var sr = new StreamReader(path))
        {
            var text = sr.ReadToEnd().ToLower();

            text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            words = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }


        var watch1 = Stopwatch.StartNew();
        foreach (var word in words)
            listWords.Add(word);
        Console.WriteLine($"Вставка в List<T> заняла: {watch1.Elapsed.TotalMilliseconds} мс");


        Console.WriteLine();


        linkedListWords.AddFirst("1");
        var watch2 = Stopwatch.StartNew();
        foreach (var word in words)
            linkedListWords.AddAfter(linkedListWords.First, word);
        Console.WriteLine($"Вставка в LinkedList<T> заняла: {watch2.Elapsed.TotalMilliseconds} мс");

        Console.ReadKey();
    }

}
