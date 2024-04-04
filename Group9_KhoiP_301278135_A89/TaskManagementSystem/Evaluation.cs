using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class Evaluation
    {
        // Fields
        private string name;
        private string textFile;
        private byte grade;
        private byte weight;
        private Guid id;
        private DateTime dueDate;
        private readonly EvaluationType type;
        private Course course;
        private List<Task> tasks;
        // Constructor
        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            this.type = type;
            Weight = weight;
            tasks = new List<Task>();
        }
        // Property #1
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // Property #2
        public string TextFile
        {
            get
            {
                return textFile;
            }
            set
            {
                textFile = value;
            }
        }
        // Property #3
        public byte Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }
        // Property #4
        public byte Weight
        {
            get
            {
                return weight;
            }
            set
            {
                byte totalWeight = 0;
                if (course != null)
                {
                    foreach (Evaluation evaluation in course.Evaluations)
                    {
                        totalWeight += evaluation.Weight;
                    }
                    if (totalWeight + value > 100)
                    {
                        throw new ArgumentException("Total evaluations weight exceeds 100%");
                    }
                    else
                    {
                        weight = value;
                    }
                }
                else
                {
                    weight = value;
                }
            }
        }
        // Property #5
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        // Property #6
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        // Property #7
        public EvaluationType Type
        {
            get
            {
                return type;
            }
        }
        // Property #8
        [JsonIgnore]
        public Course Course
        {
            get
            {
                return course;
            }
        }
        // Property #9
        public List<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }
        // Property #10
        public string EvaluationText
        {
            get
            {
                if (TextFile == null)
                {
                    return null;
                }
                else
                {
                    FileStream fileIn = default;
                    StreamReader reader = default;
                    string line;
                    try
                    {
                        fileIn = new FileStream(TextFile, FileMode.Open, FileAccess.Read);
                        reader = new StreamReader(fileIn);
                        line = reader.ReadToEnd();
                        return $"********************** Start of evaluation text ********************** \n{line} \n********************** End **********************";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                    finally
                    {
                        reader?.Close();
                        fileIn?.Close();
                    }
                }
            }
        }
        // Action member #1
        public Task AddTask(string description)
        {
            TaskManager taskManager = new TaskManager();
            Task newTask = taskManager.CreateTask(description);
            tasks.Add(newTask);
            return newTask;
        }
        // Action member #2
        public string TaskToString()
        {
            return $"{Type}-{Name} all tasks:\n-{String.Join("\n-", tasks)}";
        }
        // Action member #3
        public override string ToString()
        {
            string toString = $"Type: {Type}-{Name}, Grade: {Grade}, Weight: {Weight}%";
            if (DueDate == default)
            {
                return $"{toString}, No Due Date";
            }
            else
            {
                return $"{toString}, Due Date: {DueDate}";
            }
        }
    }
}
