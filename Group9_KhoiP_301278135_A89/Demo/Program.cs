using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //0.Create instance of both TaskManager and CourseManager classes
            TaskManager taskManager = new TaskManager();
            CourseManager courseManager = new CourseManager();
            //1.Create 2 courses
            Course course1 = new Course(1, "COMP123");
            Course course2 = new Course(2, "COMP253");
            //2.Add courses to the course manager
            courseManager.AddCourse(course1);
            courseManager.AddCourse(course2);
            //3.Write content of course manager to the console
            Console.WriteLine(courseManager);
            Console.WriteLine("---------------------------------------------");
            //4.Add 2 assignments to the first course with due dates in 14 and 7 days respectively
            DateTime evaluationStartDay = DateTime.Today;
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A1", evaluationStartDay.AddDays(14));
            course1.AddEvaluation(EvaluationType.Assignment, 20, "A2", evaluationStartDay.AddDays(7));
            //5.Add quiz, and test to the first course
            course1.AddEvaluation(EvaluationType.Quiz, 5, "Q1");
            course1.AddEvaluation(EvaluationType.Test, 25, "Mid-term");
            //6.Add test to the first course
            course1.AddEvaluation(EvaluationType.Test, 25, "Final");
            //7.Add 3 assignments to the second course with due dates in 10,5, and 6 days respectively
            course2.AddEvaluation(EvaluationType.Assignment, 16, "A1", evaluationStartDay.AddDays(10));
            course2.AddEvaluation(EvaluationType.Assignment, 15, "A2", evaluationStartDay.AddDays(5));
            course2.AddEvaluation(EvaluationType.Assignment, 15, "A3", evaluationStartDay.AddDays(6));
            //8.Trying to add assignment with a due date in the past
            try
            {
                course2.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 2, 13));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("---------------------------------------------");
            //9.Trying to add assignment with a weight that exceeds total weight of 100% for all assignments
            try
            {
                course2.AddEvaluation(EvaluationType.Assignment, 90, "A4", evaluationStartDay.AddDays(14));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("---------------------------------------------");
            //10.Trying to modify the weight of an assignment to exceed total weight of 100% for all assignments.
            try
            {
                course2.Evaluations[2].Weight = 70;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("---------------------------------------------");
            //11.Add test to the first course
            course1.AddEvaluation(EvaluationType.Test, 0, "Mock Test");
            //12.Set TextFile for the first assignment of  the course to "Evaluations\COMP123\KhoiP_301278135_A45_Reflection.txt"
            course1.Evaluations[0].TextFile = @"Evaluations\COMP123\KhoiP_301278135_A45_Reflection.txt";
            //13.Write content of the evaluation text
            Console.WriteLine(course1.Evaluations[0].EvaluationText);
            //14.Write the content of the course manager to the console
            Console.WriteLine(courseManager);
            Console.WriteLine("---------------------------------------------");
            //15.Add grade to the first assignment of the first course
            course1.Evaluations[0].Grade = 98;
            //16.Write content of the course manager to the console
            Console.WriteLine(courseManager);
            Console.WriteLine("---------------------------------------------");
            //17.Add grade to the second assignment of the first course
            course1.Evaluations[1].Grade = 80;
            //18.Write content of course manager to the console
            Console.WriteLine(courseManager);
            Console.WriteLine("---------------------------------------------");
            //19.Add task 'Read chapter 2' to the first course with due date in 6 days
            course1.AddTask("Read chapter 2");
            course1.Tasks[0].DueDate = evaluationStartDay.AddDays(6);
            //20.Add task 'Read chapter 3' to the first course
            course1.AddTask("Read chapter 3");
            //21.Output tasks for the first course to the console
            Console.WriteLine(course1.TaskToString());
            Console.WriteLine("---------------------------------------------");
            //22.Add task 'Start assignment' to the first assignment of the first course
            course1.Evaluations[0].AddTask("Start Assignment 67");
            //23.Add task 'Write main() method'' to the first assignment of the first course and mark it done
            course1.Evaluations[0].AddTask("Write main() method");
            course1.Evaluations[0].Tasks[1].IsDone = true;
            //24.Output all task for the first evaluation of the first course to the console
            Console.WriteLine(course1.Evaluations[0].TaskToString());
            Console.WriteLine("---------------------------------------------");
            //25.Create MyDay and add two tasks
            MyDay myDailyTasks = MyDay.NewDay();
            myDailyTasks.AddDayTask(course1.Tasks[0]);
            myDailyTasks.AddDayTask(course1.Evaluations[0].Tasks[0]);
            //26.Output the MyDay to the console
            Console.WriteLine(myDailyTasks);
            //27.Create array of 2 IPersistable elements and add instances of class and task manager
            IPersistable[] Iarray = new IPersistable[2];
            Iarray[0] = courseManager;
            Iarray[1] = taskManager;
            //28.Persist all elements of the array using Save method
            foreach (IPersistable manager in Iarray)
            {
                string path = $@"Save\{manager.GetType().Name}.json";
                manager.Save(path);
            }
            //29.Create instance of both TaskManager and CourseManager classes and add them to elements of the array
            TaskManager taskManager2 = new TaskManager();
            CourseManager courseManager2 = new CourseManager();
            Iarray[0] = courseManager2;
            Iarray[1] = taskManager2;
            //30.Load all persisted content from a file in each element of the array
            foreach (IPersistable manager in Iarray)
            {
                string path = $@"Save\{manager.GetType().Name}.json";
                manager.Load(path);
            }
            //31.Output a separator
            Console.WriteLine("---------------------------------------------");
            //32.Write content of course manager
            Console.WriteLine(courseManager2);
            Console.WriteLine("---------------------------------------------");
            //33.Write content of task manager
            Console.WriteLine(taskManager2.AllTasksToString());
        }
    }
}
