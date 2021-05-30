using System;

namespace MemoryAllocations
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            application.PrintDateFromLocalVariables();
            application.PrintDateFromLocalStruct();
            application.PrintDateFromClass();
        }
    }

    public class Application
    {
        public void PrintDateFromLocalVariables()
        {
            int day = 18;
            int month = 12;
            int year = 2021;
            
            unsafe
            {
                int* pointer = &year;
                year++;
            }

            Console.WriteLine($"The date is: {day}/{month}/{year}");
        }
        
        public void PrintDateFromLocalStruct()
        {
            DateStruct dateStruct = new DateStruct
            {
                Day = 18,
                Month = 12,
                Year = 2021
            };

            Console.WriteLine($"The date is: {dateStruct.Day}/{dateStruct.Month}/{dateStruct.Year}");
        }
        
        public void PrintDateFromClass()
        {
            DateClass dateClass = new DateClass
            {
                Day = 18,
                Month = 12,
                Year = 2021
            };

            Console.WriteLine($"The date is: {dateClass.Day}/{dateClass.Month}/{dateClass.Year}");
        }
    }
    
    public ref struct DateStruct
    {
        public int Day { get; init; }

        public int Month { get; init; }

        public int Year { get; init; }
    }
    
    public class DateClass
    {
        public int Day { get; init; }

        public int Month { get; init; }

        public int Year { get; init; }
    }
}