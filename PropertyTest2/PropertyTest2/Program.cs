/*using System;
class EnumPropertyExam
{
    public enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }

    DayOfWeek _day;
    public DayOfWeek Day
    {
        get
        {
            // We don't allow this to be used on Friday.
            if (this._day == DayOfWeek.Friday)
            {
                throw new Exception("Invalid access");
            }
            return this._day;
        }
        set
        {
            this._day = value;
        }
    }
}

class Program
{
    static void Main()
    {
        EnumPropertyExam example = new EnumPropertyExam();
        example.Day = DayOfWeek.Monday;
        Console.WriteLine(example.Day == DayOfWeek.Monday);
    }
}
*/