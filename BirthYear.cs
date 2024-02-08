//Max Gurung C0889825
using System;


public class BirthYear
{
   
    public static void Main(string[] args)
    {
        // Prompt the user to input their age
        Console.WriteLine("Provide your age:");

        // Read the age input from the user and parse it to an integer
        int age = int.Parse(Console.ReadLine());

        // Calculate the birth year by subtracting the age from the current year
        int yearOfBirth = DateTime.Now.Year - age;

        // Display the calculated birth year to the user
        Console.WriteLine("Your year of birth is: " + yearOfBirth);
    }
}
