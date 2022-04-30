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
        int timeOfDay = DateTime.Now.Hour;
        private int age;

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Age { get { 
                if (DateTime.Now.Month < dateOfBirth.Month)
                age = DateTime.Now.Year - dateOfBirth.Year - 1;
                else if(DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day)
                age = DateTime.Now.Year - dateOfBirth.Year - 1;
            else
                age = DateTime.Now.Year - dateOfBirth.Year;
                return age; }
        }

        public User(string userName, DateTime userBirthDate)
        {
            this.name = userName;
            DateOfBirth = userBirthDate;
        }

        public User(string name)
        {
            this.name = name;
        }

        public void Hello()
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
}
