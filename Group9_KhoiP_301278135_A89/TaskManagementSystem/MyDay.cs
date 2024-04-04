using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class MyDay
    {
        // Fields
        private List<Task> todaysTasks;
        private DateTime date;
        private static MyDay currentDay = new MyDay();
        // Constructor
        private MyDay()
        {
            date = DateTime.Today;
            todaysTasks = new List<Task>();
        }
        // Property
        public List<Task> TodaysTasks
        {
            get
            {
                return todaysTasks;
            }
        }
        // Action member #1 
        public static MyDay NewDay()
        {
            if (currentDay.date != DateTime.Today)
            {
                currentDay = new MyDay();
                return currentDay;
            }
            else
            {
                return currentDay;
            }
        }
        // Action member #2
        public void AddDayTask(Task task)
        {
            todaysTasks.Add(task);
        }
        // Action member #3
        public override string ToString()
        {
            return $"All today's task:\n{String.Join("\n", todaysTasks)}";
        }
    }
}
