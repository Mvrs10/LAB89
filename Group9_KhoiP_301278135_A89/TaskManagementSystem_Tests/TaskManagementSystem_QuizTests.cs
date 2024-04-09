using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_QuizTests
    {
        [TestMethod]
        public void ToString_Display_Correctly()
        {
            //Arrange
            Course course1 = new Course(1, "COMP123");
            string expected_message = "Type: Quiz-, Grade: 0, Weight: 10%, Due Date: 1/4/2024 12:00:00 AM, Number of Questions: 15";
            Quiz quiz = new Quiz(course1, 10, 15)
            {
                DueDate = new DateTime(2024, 1, 4)
            };
            //Act
            //Assert
            Assert.AreEqual(expected_message, quiz.ToString());
        }
    }
}
