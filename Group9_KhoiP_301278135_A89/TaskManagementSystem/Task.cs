using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class Task
    {
        // Constructor
        public Task(string description)
        {
            DueDate = DateTime.MinValue;
            IsDone = false;
            Id = new Guid();
            Description = description;
        }
        // Property #1
        public string Description { get; set; }
        // Property #2
        public DateTime DueDate { get; set; }
        // Property #3 
        public Guid Id { get; set; }
        // Property #4
        public bool IsDone { get; set; }
        // Action member #1
        public override string ToString()
        {
            string toString = $"{Description}";
            if (IsDone == false && DueDate == DateTime.MinValue)
            {
                return $"{toString}, No Due Date, Not Done";
            }
            else
            {
                if (IsDone == false && DueDate != DateTime.MinValue)
                {
                    return $"{toString}, {DueDate}, Not Done";
                }
                else
                {
                    if (IsDone == true && DueDate == DateTime.MinValue)
                    {
                        return $"{toString}, No Due Date, Done. Good job!";
                    }
                    else
                    {
                        return $"{toString}, {DueDate}, Done. Good job!";
                    }
                }
            }
        }
    }
}
