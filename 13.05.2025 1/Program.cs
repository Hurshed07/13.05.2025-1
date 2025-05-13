using System;

public class BankAccount
{
    private string accountNumber;
    private string owner;
    private double balance;

    public BankAccount(string accountNumber, string owner, double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Начальный баланс не может быть отрицательным.");

        this.accountNumber = accountNumber;
        this.owner = owner;
        this.balance = initialBalance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма депозита должна быть положительной.");

    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной.");

        if (balance >= amount)
        {
            
            return true; 
        }
        else
        {
            return false; 
        }
    }
}
class Program
{
    static void Main()
    {
        var account = new BankAccount("1234567890", "Иван Иванов", 1000.0);

        Console.WriteLine($"Номер счета: {account.AccountNumber}");
        Console.WriteLine($"Владелец: {account.Owner}");
        Console.WriteLine($"Баланс: {account.Balance}");

        account.Deposit(500);
        Console.WriteLine($"После депозита: {account.Balance}");

        bool success = account.Withdraw(200);
        if (success)
            Console.WriteLine($"После снятия: {account.Balance}");
        else
            Console.WriteLine("Недостаточно средств для снятия.");
    }
}
