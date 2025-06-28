namespace Homework19.Task5;

public class PaymentCard
{
    private double balance;

    public PaymentCard(double initialBalance)
    {
        balance = initialBalance;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void AddMoney(double amount)
    {
        this.balance += amount;
    }
    public bool TakeMoney(double amount)
    {
        if (this.balance >= amount && amount >= 0)
        {
            this.balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Kartangizda mablag' yetarli emas !");
            return false;
        }
    }
}