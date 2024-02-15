// Max Gurung C0889825
using System;

class Program
{
    static void Main(string[] args)
    {
        double x;
        Console.Write("Enter a real number: "); // Prompt the user to enter a real number
        while (!double.TryParse(Console.ReadLine(), out x)) // Repeat until valid input is received
        {
            Console.WriteLine("Invalid input. Please enter a valid real number."); // Display error message for invalid input
            Console.Write("Enter a real number(x): "); // Prompt the user again for input
        }

        // Check  x in the set I: [2, 3[ U [0, 1[ U [-10, -2]
        if ((x >= 2 && x < 3) || (x > 0 && x <= 1) || (x >= -10 && x <= -2))
        {
            Console.WriteLine("x belongs to I"); // Display message if x belongs to I
        }
        else
        {
            Console.WriteLine("x does not belong to I"); // Display message if x does not belong to I
        }
    }
}

