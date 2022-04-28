using System;

namespace DailyDay
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int timeOfDay = DateTime.Now.Hour;
            //string admin = "Женя";
            int minutes = DateTime.Now.Minute;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime date = new DateTime(1988, 6, 9);
            User admin = new User("Женя", date);

            User guest = new User("Маша", date);
            
            admin.Hello(timeOfDay);
            guest.Hello(timeOfDay);
            
            PrintMonth(30);

            char[,] myChars = new char[,] { { 'a', 'b', 'c'}, { 'd', 'e', 'f' } };
            
            for (int i = 0; i < myChars.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < myChars.GetUpperBound(1)+1; j++)
                {
                    Console.Write(myChars[i, j]);
                }
                Console.WriteLine();
            }

            
            string[][] tasks = new string[3][];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new string[2];
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

        
        public class User
        {
            private string name;
            private DateTime dateOfBirth;

            public User(string userName, DateTime userBirthDate)
            {
                this.name = userName;
                dateOfBirth = userBirthDate;
            }

            public void setName (string name)
            {
                this.name = name;
            }

            public string getName()
            {
                return name;
            }

            public void Hello(int timeOfDay)
            {

                if (timeOfDay >= 5 && timeOfDay < 12)
                {
                    Console.WriteLine("Доброе утро, " + name);

                }
                if (timeOfDay >= 12 && timeOfDay < 18)
                {
                    Console.WriteLine("Доброго денечка, " + name);

                }
                if (timeOfDay >= 18 && timeOfDay < 24)
                {
                    Console.WriteLine("Добрый вечер, " + name + "! \nКак день прошел?");
                    
                }
                if (timeOfDay == 24 || timeOfDay < 5)
                {
                    Console.WriteLine("Спи уже!!!");
                }

            }
        }
        public enum Grade
        {
            OK,
            PERFECT,
            SAD,
            HURT,
            SICK,
            INLOVE,
            PROUD,
            INSPIRED
        }
        public class Task
        {
            private string description;
            private int lasting;
            private Grade grade;
            private DateTime notification;
            private bool redDay;
            private bool isDone;
            int taskCount;
            
            public Task(string description, int lasting)
            {
                
            }

            public void setDescription(string description)
            {
                this.description = description;
;
            }
            public string getDescription()
            {
                return description;
            }

            public void setLasting(int lasting)
            {
                this.lasting = lasting;
            }

            public int getLasting()
            {
                return lasting;
            }
        }
    }
}
