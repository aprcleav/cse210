using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int newNumber = -1;

        // Gets a number from the user and adds it to the list. Stops when user enters 0.
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            
        }

        // Calculates sum of numbers in list
        float total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        // Computes average of the numbers in list
        float average = total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finds the largest number in the list
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");



    }
}