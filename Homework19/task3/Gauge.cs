namespace Homework19.task3;

public class Gauge
{
    public int value;

    public Gauge()
    {
        value = 0;
    }

    public void Increase()
    {
        if (value <= 5)
        {
            value++;
        }
    }

    public void Decrease()
    {
        if (value >= 0)
        {
            value--;
        }
    }

    public bool Full()
    {
        if (value == 5)
            return true;
        return false;
    }
    

}