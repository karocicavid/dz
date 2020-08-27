using System;

namespace EnumerationExample
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Привет сенсей");
            Console.Write("Введите название дние недели на английском:");
            string x = Convert.ToString(Console.ReadLine());
            if (x== "Monday" || x == "monday")
            {
                WriteText(DaysOfWeek.Monday);
            }
            else if (x == "Tuesday" || x == "tuesday")
            {
                WriteText(DaysOfWeek.Tuesday);
            }
            else if (x == "Wednesday" || x == "wednesday")
            {
                WriteText(DaysOfWeek.Wednesday);
            }
            else if (x == "Thursday" || x == "thursday")
            {
                WriteText(DaysOfWeek.Thursday);
            }
            else if (x == "Friday" || x == "friday")
            {
                WriteText(DaysOfWeek.Friday);
            }
            else if (x == "Saturday" || x == "saturday")
            {
                WriteText(DaysOfWeek.Saturday);
            }
            else if (x == "Sunday" || x == "sunday")
            {
                WriteText(DaysOfWeek.Sunday);
            }
            else
            {
                Console.Write("Учим английский!");
            }


        }

        static void WriteText(DaysOfWeek days)
        {
            switch (days)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("1-ый день недели.");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("2-ой день недели.");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("3-ий день недели.");
                    break;
                case DaysOfWeek.Thursday:
                    Console.WriteLine("4-ый день недели.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("5-ый день недели.");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("6-ой день недели.");
                    break;
                case DaysOfWeek.Sunday:
                    Console.WriteLine("7-ой день недели.");
                    break;
            }
        }
    }
}