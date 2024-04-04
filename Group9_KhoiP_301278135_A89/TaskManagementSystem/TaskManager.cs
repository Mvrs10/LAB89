using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class TaskManager : IPersistable
    {
        // Fields
        private static List<Task> tasks;
        // Constructor
        public TaskManager()
        {
            tasks = new List<Task>();
        }
        // Property #1
        public static List<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }
        // Action member #1
        public Task CreateTask(string description)
        {
            Task newTask = new Task(description);
            tasks.Add(newTask);
            return newTask;
        }
        // Action member #2
        public string AllTasksToString()
        {
            return $"All tasks:\n- {String.Join("\n- ", tasks)}";
        }
        // Action member #3
        public void Save(string path)
        {
            FileStream fileOut = default;
            StreamWriter writer = default;
            string jsonString;
            try
            {
                jsonString = JsonSerializer.Serialize(tasks);
                fileOut = new FileStream(path, FileMode.Create, FileAccess.Write);
                if ((writer = new StreamWriter(fileOut)) != null)
                {
                    writer.WriteLine(jsonString);
                }
            }
            catch
            {
                throw new ArgumentException("The current path does not exist");
            }
            finally
            {
                writer.Close();
                fileOut.Close();
            }
        }
        // Action member #4
        public void Load(string path)
        {
            FileStream fileIn = default;
            StreamReader reader = default;
            string jsonString;
            try
            {
                fileIn = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileIn);
                if ((jsonString = reader.ReadToEnd()) != null)
                {
                    tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
                }
            }
            catch
            {
                throw new ArgumentException("The current path does not exist");
            }
            finally
            {
                reader?.Close();
                fileIn?.Close();
            }
        }
    }
}
