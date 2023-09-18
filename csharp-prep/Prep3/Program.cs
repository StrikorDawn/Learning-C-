using System;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        int min_number = 1;
        int max_number = 11;
        string user_response = "";
        int user_guess = -1;
        do{
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(min_number,max_number);
        Console.WriteLine($"Guess the magic number between {min_number} and {max_number}.");
            do{
                Console.Write("What is the magic number? ");
            } while (user_guess != magic_number);
        Console.Write("Would you like to play again? ");
        user_response = Console.ReadLine();
        } while (user_response == "yes");
        
    }
}