namespace Homework19.Task4;

public class Counter
{
    public int startValue;
    
    public Counter(int startValue)
    {
        this.startValue = startValue;
    }

    public Counter()
    {
        this.startValue = 0;
    }

    public void Increase()
    {
        this.startValue++;
    }

    public void Decrease()
    {
        this.startValue--;
    }
    public void Increase(int increaseBy)
    {
        if(increaseBy >= 0)
            this.startValue += increaseBy;
    }

    public void Decrease(int decreaseBy)
    {
        if (decreaseBy >= 0)
            this.startValue -= decreaseBy;
    }

    public void GetInfo()
    {
        Console.WriteLine($"the current value is {this.startValue}");
    }
}