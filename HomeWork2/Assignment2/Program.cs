using System;

public class BankAccount
{
   
    private int balance;

   
    public BankAccount(int initialBalance)
    {
        balance = initialBalance;
    }

   
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += (int)amount;
            Console.WriteLine($"{amount} Deposited");
        }
        else
        {
            Console.WriteLine("The deposit amount must be positive.");
        }
    }

    
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= (int)amount;
            Console.WriteLine($"{amount} has been withdrawn from your account.");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

   
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000); // موجودی اولیه 1000

        account.ShowBalance();       // نمایش موجودی
        account.Deposit(500);        // واریز 500
        account.Withdraw(200);       // برداشت 200
        account.Withdraw(2000);      // تلاش برای برداشت بیشتر از موجودی
        account.ShowBalance();       // نمایش موجودی نهایی
    }
}
