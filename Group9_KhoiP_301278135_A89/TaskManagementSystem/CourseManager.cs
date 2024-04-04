using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class CourseManager : IPersistable
    {
        // Fields
        private static List<Course> courses = new List<Course>();
        // Default Constructor
        // Property #1
        public static List<Course> Courses
        {
            get { return courses; }
        }
        // Action member #1
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        // Action member #2
        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }
        // Action member #3
        public override string ToString()
        {
            return $"All courses:\n- {String.Join("\n- ", courses)}";
        }
        // Action member #4
        public void Save(string path)
        {
            FileStream fileOut = default;
            StreamWriter writer = default;
            string jsonString;
            try
            {
                jsonString = JsonSerializer.Serialize(courses);
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
        // Action member #5
        public void Load(string path2)
        {
            FileStream fileIn = default;
            StreamReader reader = default;
            string jsonString;
            try
            {
                fileIn = new FileStream(path2, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileIn);
                if ((jsonString = reader.ReadToEnd()) != null)
                {
                    courses = JsonSerializer.Deserialize<List<Course>>(jsonString);
                }
            }
            catch
            {
                throw new ArgumentException("The current path does not exist");
            }
            finally
            {
                reader.Close();
                fileIn.Close();
            }
        }
    }
}
