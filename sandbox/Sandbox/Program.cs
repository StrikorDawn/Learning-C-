using System;
using System.ComponentModel;

class Program
{
    
    static void Main(string[] args)
    {
        string password = "Ty is Amazing and Minions are Amazing too";
        bool correct = false;
        int guessNumber = 1;
        while(guessNumber < 5)
        {
            Console.WriteLine("What is the password? ");
            string guess = Console.ReadLine();
            if(guess == password)
            {
                correct = true;
                guessNumber = 5;
            }
            guessNumber = guessNumber + 1;
        }

        if (correct)
        {
            Console.WriteLine("Welcome Ty");
        }
        else{
            Console.WriteLine("INTRUDER GO AWAY!!!!");
        }

    }
}