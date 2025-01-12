using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //LIST
        List<int> numbers = new List<int>();
        //VARIABLE
        int userNumber = -1;
        //LOOP
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
        //CONDITIONAL ADD IF different than 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // FOR SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // PRINT AVERAGE
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //FOR  MAX
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // IF higher = New MAX
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}