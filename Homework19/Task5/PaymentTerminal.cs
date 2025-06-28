namespace Homework19.Task5;

public class PaymentTerminal
{
    public double money;
    public double lunchPrice = 10.5;
    public double coffeePrice = 2.5;

    public PaymentTerminal()
    {
        this.money = 100.5;
    }

    public double ProcessLunchPayment(double cashGiven)
    {
        if (cashGiven >= lunchPrice)
        {
            money += cashGiven;
            return cashGiven-lunchPrice;
        }
        else
        {
            Console.WriteLine("Yetarli mablag' yo'q !");
            return cashGiven;
        }
    }

    public double ProcessCoffeePayment(double cashGiven)
    {
        if (cashGiven >= coffeePrice)
        {
            money += cashGiven;
            return cashGiven-coffeePrice;
        }
        else
        {
            Console.WriteLine("Yetarli mablag' yo'q !");
            return cashGiven;
        }
    }

    public bool ProcessLunchPayment(PaymentCard card)
    {
        return card.TakeMoney(lunchPrice);
    }

    public bool ProcessCoffeePayment(PaymentCard card)
    {
        return card.TakeMoney(coffeePrice);
    }

    public void AddMoneyToCard(PaymentCard card, double amount)
    {
        if (amount >= 0)
        {
            card.AddMoney(amount);
            money+= amount;
        }
        else
        {
            Console.WriteLine("Ko'proq pul qo'yishingiz kerak");
        }
    }

    public double GetMoney()
    {
        return money;
    }
}