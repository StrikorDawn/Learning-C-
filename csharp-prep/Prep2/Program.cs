using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string user_input = Console.ReadLine();
        int user_percentage = int.Parse(user_input);
        int last_diget = user_percentage % 10;
        string grade_symbole = "";
        string user_grade;
        if (user_percentage <= 100)
        {
            if (last_diget >= 7)
            {
                grade_symbole = "+";
            }
            else if (last_diget <= 3)
            {
                grade_symbole = "-";
            }

            if (user_percentage >= 97)
            {
                user_grade = "A";
                grade_symbole = "";
            }
            else if (user_percentage >= 90 )
            {
                user_grade = "A";
            }
            else if (user_percentage >= 80)
            {
                user_grade = "B";
            }
            else if (user_percentage >= 70)
            {
                user_grade = "C";
            }
            else if (user_percentage >= 60)
            {
                user_grade = "D";
            }
            else 
            {
                user_grade = "F";
                grade_symbole = "";

            }

            if (user_percentage >= 70)
            {
            Console.WriteLine($"Your letter grade is {grade_symbole}{user_grade}, Congrats you passed!");
            }
            else{
            Console.WriteLine($"Your letter grade is {grade_symbole}{user_grade}, looks like I'll be seeing you again next semester.");
            }
        }
        else{
            Console.WriteLine("The percentage you entered was in valid, please try agian.");
        }
    }
}