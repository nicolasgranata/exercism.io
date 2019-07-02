using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int month;
    private int year;

    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {        
        return GetDayOfMonth(dayOfWeek, schedule);
    }

    private DateTime GetDayOfMonth(DayOfWeek dayOfWeek, Schedule schedule)
    {   
        switch (schedule)
        {
            case Schedule.First:
                return GetDay(dayOfWeek, 1, 7);
            case Schedule.Second:
                return GetDay(dayOfWeek, 8, 14);
            case Schedule.Third:
                return GetDay(dayOfWeek, 15, 21);
            case Schedule.Fourth:
                return GetDay(dayOfWeek, 22, 30);
            case Schedule.Last:
                return LastDayInMonth(dayOfWeek);
            default:
                return GetDay(dayOfWeek, 13, 20);
        }
    }

    private DateTime GetDay(DayOfWeek dayOfWeek, int firstDay, int lastDay)
    {
        for (int day = firstDay; day <= lastDay; day++)
        {
            DateTime currentDateTime = new DateTime(year, month, day);
            
            if (currentDateTime.DayOfWeek == dayOfWeek)
            {
                return currentDateTime;
            }               
        }

        return new DateTime();
    }

    private DateTime LastDayInMonth(DayOfWeek dayOfWeek)
    {
        var daysInMonth = DateTime.DaysInMonth(this.year, this.month);

        for (int day = daysInMonth; day > 0; day--)
        {
            DateTime currentDateTime = new DateTime(year, month, day);
            
            if (currentDateTime.DayOfWeek == dayOfWeek)
            {
                return currentDateTime;
            }               
        }

        return new DateTime();
    }
}