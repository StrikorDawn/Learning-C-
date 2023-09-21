using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared_number = SquareNumbers(number);
        DisplayResults(name, squared_number);
    }
        
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcom to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int user_number = int.Parse(Console.ReadLine());
        return user_number;
    }
    static int SquareNumbers(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResults(string name, int squared_number)
    {
        Console.WriteLine($"{name}, the square of your number is {squared_number}");
    }
}