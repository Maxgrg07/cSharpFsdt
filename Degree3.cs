//Max Gurung C0889825
using System;


public class Degree3
{
   
    public static void Main(string[] args)
    {
        // Declare variables to store coefficients and value of x
        int a, b, c;
        double x;
        
        // Prompt the user to input coefficients a, b, and c
        Console.Write("Enter a (int) :");
        // Read and parse the input for coefficient a
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter b (int) :");
        // Read and parse the input for coefficient b
        b = int.Parse(Console.ReadLine());

        Console.Write("Enter c (int) :");
        // Read and parse the input for coefficient c
        c = int.Parse(Console.ReadLine());

        // Prompt the user to input the value of x
        Console.Write("Enter x (int) :");
        // Read and parse the input for the value of x
        x = double.Parse(Console.ReadLine());

        // Calculate the value of the polynomial expression
        double result = ((a + b) / 2.0) * Math.Pow(x, 3) + Math.Pow((a + b), 2) * Math.Pow(x, 2) + a + b + c;

        // Display the calculated value of the polynomial to the user
        Console.WriteLine("The value of polynomial is : " + result);
    }
}
