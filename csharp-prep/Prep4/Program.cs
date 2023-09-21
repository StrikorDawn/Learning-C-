using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_input = -1;
        int list_sum = 0;
        int largest_number = 0;
        int smallest_positive_number = 999999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (user_input != 0)
        {
            Console.Write("Enter number (0 to end): ");
            user_input = int.Parse(Console.ReadLine());
            if (user_input != 0)
            {
                numbers.Add(user_input);
            }   
        }
        foreach (int number in numbers)
        {
            list_sum += number;
            if (number > largest_number)
                {
                    largest_number = number;
                }

            if (number > 0)
            {
                if (number < smallest_positive_number)
                {
                    smallest_positive_number = number;
                }
            }
        }
        float list_avg = ((float)list_sum) / numbers.Count;
        Console.WriteLine($"The sum is: {list_sum}");
        Console.WriteLine($"The average is: {list_avg}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive_number}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}