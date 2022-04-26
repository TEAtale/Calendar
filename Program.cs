using System;

namespace DailyDay
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int timeOfDay = DateTime.Now.Hour;
            string admin = "Женя";
            int minutes = DateTime.Now.Minute;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            
            Console.WriteLine(Hello(admin, timeOfDay));
            
            PrintMonth(30);

            string[][] tasks = new string[7][];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new string[5];
                Console.WriteLine("День " + (i+1) + ":");
                for (int j = 0; j < tasks[i].Length; j++)
                {
                    
                    tasks[i][j] = "Задание " + (j + 1) + ": ";
                    Console.WriteLine(tasks[i][j]);
                    
                }
                Console.WriteLine();
            }


        }

        static void PrintMonth (int count)
        {
            for (int i = 1; i < count+1; i++)
            {
                if (i < 10)
                {
                    Console.Write(i);
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                if ((i % 7) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static string Hello(string s, int timeOfDay)
        {
            
                if (timeOfDay >= 5 && timeOfDay < 12)
                {
                    return "Доброе утро, " + s;

                }
                if (timeOfDay >= 12 && timeOfDay < 18)
                {
                    return "Доброго денечка, " + s; ;

                }
                if (timeOfDay >= 18 && timeOfDay < 24)
                {
                    s = "Добрый вечер, " + s + "! \nКак день прошел?";
                    return s;

                }
                if (timeOfDay == 24 || timeOfDay < 5)
                {
                    return "Спи уже!!!";
                }
                
            return s;
        }
    }
}
