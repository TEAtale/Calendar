using System;

namespace DailyDay
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1988, 6, 9);
            
            User admin = new User("Женя", date);

            User guest = new User("Маша");
            
            admin.Hello();
            guest.Hello();
            Console.WriteLine("Жене - " + admin.Age + " годика");
            
            PrintMonth(30);

            
        }

        static void PrintMonth(int count)
        {
            for (int i = 1; i < count + 1; i++)
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
       
        
    }
}
