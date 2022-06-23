using System;
class Account
{
    protected string customerName;
    protected int accountNumber;
    protected string type;
    protected double balance;
    public Account(string n, int a, string t, double b)
    {
        this.customerName = n;
        this.accountNumber = a;
        this.type = t;
        this.balance = b;
    }
    public void Deposit(double amount)
    {
        this.balance += amount;
    }
    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }
    public void displayBalance()
    {
        Console.WriteLine("Balance: {0}", this.balance);
    }
}
class CurAcct : Account
{
    double minBalance, penalty;
    public CurAcct(string n, int a, string t, double b, double m, double p) : base(n, a, t, b)
    {
        this.minBalance = m;
        this.penalty = p;
    }
    public new void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawal not allowed");
    }
    // Check for minimum balance, impose penalty if necessary and update the balance
    public void checkPenalty()
    {
        if (this.balance < this.minBalance)
        {
            this.balance -= this.penalty;
        }
    }
    

}
class SavAcct : Account
{
    double interestRate, interest;
    public SavAcct(string n, int a, string t, double b, double i) : base(n, a, t, b)
    {
        this.interestRate = i;
    }
    // Compute and deposit compound interest
    public void CompoundInterest()
    {
        interest = this.balance * this.interestRate / 100;
        this.balance += interest;
    }
}
class Origin
{
    public static void Main()
    {
        CurAcct c = new CurAcct("Debojeet Das", 22, "Current", 10000, 1000, 100);
        SavAcct s = new SavAcct("Swaubhik Chakraborty", 26, "Savings", 10000, 0.5);
        c.Deposit(5000);
        c.Withdraw(1000);
        c.displayBalance();
        c.checkPenalty();
        c.displayBalance();
        s.Deposit(5000);
        s.displayBalance();
        s.CompoundInterest();
        s.displayBalance();

    }
}