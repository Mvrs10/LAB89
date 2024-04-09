using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_CourseTests
    {
        [TestMethod]
        public void ToString_Display_Correctly_NoEvaluation()
        {
            //Arrange
            string expected_message = "Course info - Code:COMP123, Total Grade: 0\nNo current evaluation";
            Course course = new Course(1, "COMP123");
            //Act
            //Assert
            Assert.AreEqual(expected_message, course.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_HaveEvaluation()
        {
            //Arrange
            string expected_message = "Course info - Code:COMP123, Total Grade: 0\nEvaluations: \nType: Quiz-Q1, Grade: 0, Weight: 5%, No Due Date, Number of Questions: 1";
            Course course = new Course(1, "COMP123");
            //Act
            course.AddEvaluation(EvaluationType.Quiz, 5, "Q1");
            //Assert
            Assert.AreEqual(expected_message, course.ToString());
        }
        [TestMethod]
        public void TaskList_Display_Correctly()
        {
            //Arrange
            string expected_message = "COMP123 all tasks: \nTask description: Test, No Due Date, Not Done";
            Course course = new Course(1, "COMP123");
            //Act
            course.AddTask("Test");
            //Assert
            Assert.AreEqual(expected_message, course.TaskToString());
        }
        [TestMethod]
        public void Date_Valid_AddEvaluation()
        {
            //Arrange
            Course course = new Course(1, "COMP123");
            DateTime expected_date = new DateTime(2024, 5, 27);
            //Act
            course.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 5, 27));
            //Assert
            Assert.AreEqual(expected_date, course.Evaluations[0].DueDate);
        }
        [TestMethod]
        public void Date_Invalid_AddEvaluation()
        {
            //Arrange
            Course course = new Course(1, "COMP123");
            string expected_error_message = "Due date must be in the future";
            //Act
            try
            {
                course.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 2, 13));
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Equals(expected_error_message, e.Message);
            }
        }
        [TestMethod]
        public void Weight_Valid_AddEvaluation()
        {
            //Arrange
            Course course = new Course(1, "COMP123");
            byte expected_weight = 15;
            //Act
            course.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 5, 27));
            //Assert
            Assert.AreEqual(expected_weight, course.Evaluations[0].Weight);
        }
        [TestMethod]
        public void Weight_Ialid_AddEvaluation()
        {
            //Arrange
            Course course = new Course(1, "COMP123");
            string expected_error_message = "Total evaluations weight exceeds 100%";
            //Act
            try
            {
                course.AddEvaluation(EvaluationType.Assignment, 150, "A4", new DateTime(2025, 2, 13));
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Equals(expected_error_message, e.Message);
            }
        }
    }

}
