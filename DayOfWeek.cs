using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            while (year < 1)
            {
                Console.Write("Anna vuosi: ");
                year = Convert.ToInt32(Console.ReadLine());
            }

            int month = 0;
            while (month < 1 || month > 12)
            {
                Console.Write("Anna kuukausi: ");
                month = Convert.ToInt32(Console.ReadLine());
            }

            int day = 0;
            while (day < 1 || day > 31)
            {
                Console.Write("Anna päivämäärä: ");
                day = Convert.ToInt32(Console.ReadLine());
            }


            int pvm = DayOfWeek(year, month, day);
            string weekday = WeekDay(pvm);
            Console.WriteLine();
            Console.WriteLine("Päivämäärän " + day + "." + month + "." + year + " viikonpäivä oli " + weekday);
            Console.ReadLine();


        }

    static string WeekDay(int pvm)
        {
            string WeekDay;

            switch (pvm)
            {
                case 1:
                    WeekDay = "maanantai";
                    break;
                case 2:
                    WeekDay = "tiistai";
                    break;
                case 3:
                    WeekDay = "keskiviikko";
                    break;
                case 4:
                    WeekDay = "torstai";
                    break;
                case 5:
                    WeekDay = "perjantai";
                    break;
                case 6:
                    WeekDay = "lauantai";
                    break;
                case 0:
                    WeekDay = "sunnuntai";
                    break;
                default:
                    WeekDay = "";
                    break;
            }
            return WeekDay;
        }

    static int DayOfWeek(int y, int m, int d)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (m < 3)
            {
                y = y - 1;
            }
            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }


    }
}
