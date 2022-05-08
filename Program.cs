using System;
using System.Collections.Generic;

namespace DailyDay
{
    internal class Program
    {
        static List<Task> tasks = new List<Task>();
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1988, 6, 9);
            

            User admin = new User("Женя", date);

            User guest = new User("Маша");
            Task task = new Task("Почесать кота", Level.Necessary);
            
            admin.Hello();
            guest.Hello();
            Console.WriteLine("Жене - " + admin.Age + " годика");
            
            PrintMonth();
            checkImportance(task);
            addTasks();
            printTasks();

            

        }

        static void addTasks()
        {

            Task task = new Task(Console.ReadLine(), Level.NotSoImportant);
            tasks.Add(task);
        }
        static void printTasks()
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine(task.Description);
            }
            
        }



        static void PrintMonth()
        {
            int count = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
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
       
        static void checkImportance(Task task)
        {
            if((int)task.Level > 2)
            {
                Console.WriteLine(task.Description + ": это очень важно!");
            }
        }
        
    }
}
