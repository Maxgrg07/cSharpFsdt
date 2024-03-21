using System;

public enum AccountType
{
    Checking,
    Savings
}

public class Account
{
    // Properties
    private readonly int accountNumber;
    private double balance;
    private AccountType accountType;

    // Constructors
    public Account(int accountNumber, double balance = 0, AccountType accountType = AccountType.Checking)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.accountType = accountType;
    }

    public Account(int accountNumber, AccountType accountType, double balance = 0)
        : this(accountNumber, balance, accountType)
    {
    }

    // Methods
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount} into account {accountNumber}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount} from account {accountNumber}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    // Example usage
    public static void Main(string[] args)
    {
        // Creating a checking account
        Account checkingAccount = new Account(889825, AccountType.Checking);

        // Depositing money into the checking account
        checkingAccount.Deposit(1000);

        // Withdrawing money from the checking account
        checkingAccount.Withdraw(50);

        // Creating a savings account
        Account savingsAccount = new Account(889283, AccountType.Savings);

        // Depositing money into the savings account
        savingsAccount.Deposit(200);

        // Withdrawing money from the savings account
        savingsAccount.Withdraw(250);
    }
}
