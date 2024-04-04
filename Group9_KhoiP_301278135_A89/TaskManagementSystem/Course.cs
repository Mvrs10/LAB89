using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class Course
    {
        // Fields
        private string code;
        private string name;
        private uint id;
        private byte semester;
        [JsonInclude]
        private List<Evaluation> evaluations;
        [JsonInclude]
        private List<Task> tasks;
        // Constructor
        public Course(uint id, string code)
        {
            this.id = id;
            Code = code;
            evaluations = new List<Evaluation>();
            tasks = new List<Task>();
        }
        // Property #1
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        // Property #2
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
        // Property #3
        public uint Id
        {
            get
            {
                return id;
            }
        }
        // Property #4
        public byte Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        // Property #5 Grade sum of product
        public ushort Grade
        {
            get
            {
                //return (ushort)(evaluations.Sum(newEvaluation => newEvaluation.Grade * newEvaluation.Weight) / 100);
                ushort sum = 0;
                foreach (Evaluation evaluation in evaluations)
                {
                    sum += (ushort)(evaluation.Grade * evaluation.Weight);
                }
                return (ushort)(sum / 100);
            }
        }
        // Property #6
        [JsonIgnore]
        public List<Evaluation> Evaluations
        {
            get
            {
                return evaluations;
            }
        }
        // Property #7
        [JsonIgnore]
        public List<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }
        // Action member #1
        public void AddEvaluation(EvaluationType type, byte weight, string name, DateTime dueDate = default)
        {
            byte totalWeight = 0;
            foreach (Evaluation evaluation in evaluations)
            {
                totalWeight += evaluation.Weight;
            }
            if (dueDate < DateTime.Today && dueDate != default)
            {
                throw new ArgumentException("Due date must be in the future");
            }
            else if (totalWeight + weight > 100)
            {
                throw new ArgumentException("Total evaluations weight exceeds 100%");
            }
            else
            {
                switch (type)
                {
                    case EvaluationType.Assignment:
                        Assignment assignment = new Assignment(this, weight, dueDate);
                        assignment.Name = name;
                        evaluations.Add(assignment);
                        break;
                    case EvaluationType.Quiz:
                        Quiz quiz = new Quiz(this, weight);
                        quiz.Name = name;
                        evaluations.Add(quiz);
                        break;
                    default:
                        Evaluation evaluation = new Evaluation(this, type, weight);
                        evaluation.Name = name;
                        evaluations.Add(evaluation);
                        break;
                }
            }
        }
        // Action member #2
        public Task AddTask(string description)
        {
            Task newTask = new TaskManager().CreateTask(description);
            Tasks.Add(newTask);
            return newTask;
        }
        // Action member #3
        public string TaskToString()
        {
            return $"{Code} all tasks: \n{String.Join("\n", tasks)}";
        }
        // Action member #4
        public override string ToString()
        {
            string toString = $"Course info - Code:{Code}, Total Grade: {Grade}";
            if (evaluations.Count == 0)
            {
                return $"{toString}\nNo current evaluation";
            }
            else
            {
                return $"{toString}\nEvaluations: \n{String.Join("\n", evaluations)}";
            }
        }
    }
}
