namespace Homework19.Task1;

public class DayProperties
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }
    public int Millisecond { get; set; }

    public DateTime now=DateTime.Now;

    public void GetInfo()
    {
        Console.WriteLine(
            $"""
            Year: {now.Year}
            Month: {now.Month}
            Day: {now.Day}
            Hour: {now.Hour}
            Minute: {now.Minute}
            Second: {now.Second}
            Millisecond: {now.Millisecond}
            """
            );
    }
}