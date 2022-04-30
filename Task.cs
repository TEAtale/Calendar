using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDay
{
    internal class Task
    {
        private string description;
        private int lasting;
        private Grade grade;
        private DateTime notification;
        
        private bool isDone = false;
        int taskCount;
        private DateTime taskDate;
        private int level;

        public string Description { get => description; set => description = value; }
        public int Lasting
        {
            get
            {
                return lasting;
            }
            set
            {
                if(lasting > 0)
                lasting = value;
            }
        }

        public bool IsDone { get => isDone; set => isDone = value; }
        public DateTime TaskDate { get { return taskDate; } set { 
                if(taskDate >= DateTime.Now)
                taskDate = value; } }

        public int Level { get { return level; }  set { 
                if(level >= 0)
                level = value; } }

        public Task(string description, int lasting)
        {
            this.Description = description;
            this.Lasting = lasting;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone, DateTime taskDate, int level)
        {
            this.Description = description;
            this.Level = level;
            this.TaskDate = taskDate;
            this.Lasting = lasting;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone, DateTime taskDate)
        {
            this.Description = description;
            this.Level = 0;
            this.TaskDate = taskDate;
            this.Lasting = lasting;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone, int level)
        {
            this.Description = description;
            this.Level = level;
            this.TaskDate = DateTime.Now;
            this.Lasting = lasting;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone)
        {
            this.Description = description;
            this.Level = 0;
            this.TaskDate = DateTime.Now;
            this.Lasting = lasting;
            this.IsDone = isDone;
            this.notification = notification;
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
    }
}
