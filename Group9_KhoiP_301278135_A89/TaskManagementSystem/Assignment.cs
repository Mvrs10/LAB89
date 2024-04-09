using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class Assignment : Evaluation
    {
        // Constructor
        public Assignment(Course course, byte weight, DateTime dueDate = default, bool isGroupAssignment = false) : base(course, EvaluationType.Assignment, weight)
        {
            IsGroupAssignment = isGroupAssignment;
            DueDate = dueDate;
        }
        // Property #1
        public bool IsGroupAssignment { get; set; }
        // Action member #1
        public new Task AddTask(string description)
        {
            TaskManager taskManager = new TaskManager();
            Task newTask = taskManager.CreateTask(description);
            newTask.DueDate = DueDate;
            Tasks.Add(newTask);
            return newTask;
        }
        // Action member #2
        public override string ToString()
        {
            return $"{base.ToString()} - Group: {IsGroupAssignment}";
        }
    }
}
