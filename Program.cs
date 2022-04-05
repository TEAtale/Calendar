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

            
            

        }

        static void PrintMonth (int count)
        {
            for (int i = 0; i < count+1; i = i + 7)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if ((j + i) < count+1)
                    {
                        if ((j+i) < 10)
                        {
                            Console.Write(j + i);
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write(j + i);
                            Console.Write(" ");
                        }
                        
                    }
                }
                Console.WriteLine();
            }
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
