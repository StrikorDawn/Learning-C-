using System;

class Program
{
    static void Main(string[] args)
    {
        
        string book = "Proverbs";
        string chapter = "3";
        string verse = "5";
        // string endverse = "6";
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        Console.Clear();
        Reference reference1 = new Reference(book, chapter, verse, text);
        reference1.Practice();


        
    }
}