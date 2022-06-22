using System;
class BankAccount
{
    public string depositor;
    public int accountNumber;
    public string type;
    public double balance;
    public BankAccount(string d, int a, string t, double b)
    {
        depositor = d;
        accountNumber = a;
        type = t;
        balance = b;
    }
    public void deposit(double amount)
    {
        balance += amount;
    }
    public void withdraw(double amount)
    {
        balance -= amount;
    }
    public void display()
    {
        Console.WriteLine("Depositor: " + depositor);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Balance: " + balance);
    }
}
class Origin
{
    public static void Main()
    {
        BankAccount ba = new BankAccount("John", 12345, "Checking", 100.00);
        ba.display();
        ba.deposit(100.00);
        ba.display();
        ba.withdraw(50.00);
        ba.display();
    }
}