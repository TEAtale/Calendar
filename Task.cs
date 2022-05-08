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
        private Grade grade;
        private DateTime notification;
        
        private bool isDone = false;
        int taskCount;
        private DateTime taskDate;
        
        private Level level;

        public string Description { get => description; set => description = value; }

        public bool IsDone { get => isDone; set => isDone = value; }
        public DateTime TaskDate { get { return taskDate; } set { 
                if(taskDate >= DateTime.Now)
                taskDate = value; } }

        public Level Level { get => level; set => level = value; }
       
        public Task(string description, int lasting, DateTime notification, bool isDone, DateTime taskDate, Level level)
        {
            this.Description = description;
            this.Level = level;
            this.TaskDate = taskDate;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, DateTime notification, bool isDone, DateTime taskDate)
        {
            this.Description = description;
            this.Level = 0;
            this.TaskDate = taskDate;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone, Level level)
        {
            this.Description = description;
            this.Level = level;
            this.TaskDate = DateTime.Now;
            this.IsDone = isDone;
            this.notification = notification;
        }
        public Task(string description, int lasting, DateTime notification, bool isDone)
        {
            this.Description = description;
            this.Level = 0;
            this.TaskDate = DateTime.Now;
            this.IsDone = isDone;
            this.notification = notification;
        }

        public Task(string description, Level level)
        {
            this.Description = description;
            this.level = level;
        }
        
       
    }
    public enum Level
    {
        NotImportant,
        NotSoImportant,
        Important,
        MoreImportant,
        Necessary
    }
    public enum Grade
    {
        SAD,
        HURT,
        SICK,
        OK,
        INLOVE,
        PROUD,
        INSPIRED,
        PERFECT
    }
}
