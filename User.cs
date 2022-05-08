using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDay
{
    internal class User
    {
        private string name;
        private DateTime dateOfBirth;
        //int timeOfDay = DateTime.Now.Hour;

        public int Age { get {
                int age;
                if (DateTime.Now.Month < DateOfBirth.Month)
                {
                    age = DateTime.Now.Year - DateOfBirth.Year - 1;
                }
                else if(DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
                    age = DateTime.Now.Year - DateOfBirth.Year - 1;
                else
                    age = DateTime.Now.Year - DateOfBirth.Year;
                return age; }
        }
        
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public User(string userName, DateTime userBirthDate)
        {
            this.name = userName;
            DateOfBirth = userBirthDate;
        }

        public User(string name)
        {
            this.name = name;
        }

        public DayTime timeOfDay()
        {
            int timeOfDay = DateTime.Now.Hour;
            if (timeOfDay >= 5 && timeOfDay< 12)
            {
                return DayTime.Morning;
            }
            if (timeOfDay >= 12 && timeOfDay < 18)
            {
                return DayTime.Afternoon;

            }
            if (timeOfDay >= 18 && timeOfDay < 24)
            {
                return DayTime.Evening;

            }
            return DayTime.Night;
        }

        public void Hello()
        {
            switch (timeOfDay())
            {
                case DayTime.Morning:
                    Console.WriteLine("Доброе утро, " + name);
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("Доброго денечка, " + name);
                    break;
                case DayTime.Evening:
                    Console.WriteLine("Добрый вечер, " + name + "! \nКак день прошел?");
                    break;
                case DayTime.Night:
                    Console.WriteLine("Спи уже!!!");
                    break;
            }

        }
    }

    enum DayTime
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
}
