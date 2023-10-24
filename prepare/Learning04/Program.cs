using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummery());


        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummery());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Walters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummery());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}