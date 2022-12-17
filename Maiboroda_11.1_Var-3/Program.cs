// Майборода А.А. - Вар 3 - Средний 
void Main()
{
    var luckyDate = new Date(2022, 11, 11);
    luckyDate.Print();
    Console.WriteLine(luckyDate.MonthEqualDay());
    luckyDate.AddMonth();
    luckyDate.Print();

    Console.WriteLine('\n');

    var date = new Date(2022, 12, 31);
    date.Print();
    Console.WriteLine(date.MonthEqualDay());
    date.AddMonth();
    date.Print();
}

Main();


public class Date
{
    private int Day { get; set; }
    private int Month { get; set; }
    private int Year { get; set; }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public Date(int year)
    {
        Year = year;
    }

    public Date(int year, int month)
    {
        Year = year;
        if (!(month > 0 && month < 13)) throw new Exception("Месяц должен быть в диапазоне от 1 до 12");
        Month = month;
    }

    public bool MonthEqualDay()
    {
        return Month == Day;
    }

    public void AddMonth()
    {
        if (Month != 12)
        {
            Month++;
            return;
        }

        Month = 1;
        Year++;
    }

    public void Print()
    {
        Console.WriteLine($"{Day.ToString().PadLeft(2, '0')}.{Month.ToString().PadLeft(2, '0')}.{Year}");
    }
}