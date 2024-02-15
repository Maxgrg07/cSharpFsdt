//Max Gurung C0889825
using System;


public class RoseBlanches
{
    
    public static void Main(string[] args)
    {
        // Prompt the user to input the total amount of money received
        Console.Write("How much did you receive money ($)? ");

        // Read and parse the input for the total amount of money received
        int totalMoney = int.Parse(Console.ReadLine());

        // Calculate the amount of money allocated for books and supplies (75% of totalMoney)
        int booksAndSupplies = (int)(0.75 * totalMoney);

        // Calculate the remaining money after purchasing books and supplies
        int remainingMoney = totalMoney - booksAndSupplies;

        // Define the costs of coffee, flash computer, and subway ticket
        int coffeeCost = 2;
        int flashComputerCost = 4;
        int subwayTicketCost = 3;

        // Calculate the remaining money divided into three equal parts
        int remainingMoneyDividedToThreeParts = remainingMoney / 3;

        // Calculate the number of coffees that can be purchased with one-third of the remaining money
        int coffees = remainingMoneyDividedToThreeParts / coffeeCost;

        // Calculate the number of flash computers that can be purchased with one-third of the remaining money
        int flashComputers = remainingMoneyDividedToThreeParts / flashComputerCost;

        // Calculate the number of subway tickets that can be purchased with one-third of the remaining money
        int subwayTickets = remainingMoneyDividedToThreeParts / subwayTicketCost;

        // Calculate the amount of money left for purchasing white roses
        int whiteRoses = remainingMoney - (coffees * coffeeCost + flashComputers * flashComputerCost + subwayTicketCost * subwayTickets);

        // Display the amount of money allocated for books and supplies
        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");

        // Display the available options for purchasing with the remaining money
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");

        // Display the amount of money left for purchasing white roses
        Console.WriteLine($"and you will have {whiteRoses} dollars for the white roses.");
    }
}
