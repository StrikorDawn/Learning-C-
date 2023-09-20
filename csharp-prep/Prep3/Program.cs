using System;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secret_number = randomGenerator.Next(1-21);

        int user_guess = -1;

        while (user_guess != secret_number)
        {
            Console.Write("What is your Guess? ");
            user_guess = int.Parse(Console.ReadLine());

            if (secret_number > user_guess)
            {
                Console.WriteLine("Higher");
            }
            else if (secret_number < user_guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}