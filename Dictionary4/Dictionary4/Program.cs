using System;
using System.Collections.Generic;
using System.Text;
namespace Dictionary4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<string, string> translateWords = new Dictionary<string, string>()
            {
                {"Easy", "آسان"},
                {"Hard", "مشکل"},
                {"Good ", "اچھا"},
                {"Bad", "برا"},
                {"Near", "نزدیک"},
                {"Yes", "ہاں"},
                {"No", "نہیں"},
                {"Have", "رکھنا"},
                {"Use", "میں استعمال کرتا ہوں"},
                {"Go", "جانا"}
            };
            Console.Write("Enter English Word : ");
            string word = Console.ReadLine(); 

            if (translateWords.ContainsKey(word))
            {
                var dd = translateWords[word]; 
                Console.WriteLine($"{word} meaning in urdu is: {dd}");
            }
            else
            {
                Console.WriteLine("Vocabulary Not Found.");
            }
        }
    }
}
