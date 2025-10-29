using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determines the sign of the grade
        string sign;
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }

        // Removes possibility of an A+, F+, or F- grade
        if (grade >= 97)
        {
            sign = "";
        }
        if (grade < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, but keep studying and try again. You got this!");
        }
    }
}