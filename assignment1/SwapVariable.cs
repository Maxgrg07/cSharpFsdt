//Max Gurung C0889825
using System;


public class SwapVariable
{

    public static void Main(string[] args)
    {
        // Declare variables to store values of x and y
        int x, y;

        // Prompt the user to input the value of x
        Console.Write("Enter x: ");
        // Read and parse the input for the value of x
        x = int.Parse(Console.ReadLine());

        // Prompt the user to input the value of y
        Console.Write("Enter y: ");
        // Read and parse the input for the value of y
        y = int.Parse(Console.ReadLine());

        // Display the values of x and y before swapping
        Console.WriteLine("Before swapping: x: " + x + "; y: " + y + ";");

        // Swapping values of x and y using a temporary variable
        int temp = x;
        x = y;
        y = temp;

        // Display the values of x and y after swapping
        Console.WriteLine("After swapping: x: " + x + "; y: " + y + ";");
    }
}
