using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
// KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_TaskTests
    {
        [TestMethod]
        public void ToString_Display_Correctly_NoDueDate_NotDone()
        {
            //Arrange
            string expected_message = "Task description: Test, No Due Date, Not Done";
            Task task = new Task("Test")
            {
                IsDone = false,
                DueDate = DateTime.MinValue
            };
            //Act
            //Assert
            Assert.AreEqual(expected_message, task.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_NoDueDate_Done()
        {
            //Arrange
            string expected_message = "Task description: Test, No Due Date, Done. Good job!";
            Task task = new Task("Test")
            {
                IsDone = true,
                DueDate = DateTime.MinValue
            };
            //Act
            //Assert
            Assert.AreEqual(expected_message, task.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_HaveDueDate_NotDone()
        {
            //Arrange
            string expected_message = "Task description: Test, 1/4/2024 12:00:00 AM, Not Done";
            Task task = new Task("Test")
            {
                IsDone = false,        
            };
            task.DueDate = new DateTime(2024,1,4);
            //Act
            //Assert
            Assert.AreEqual(expected_message, task.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_HaveDueDate_Done()
        {
            //Arrange
            string expected_message = "Task description: Test, 1/4/2024 12:00:00 AM, Done. Good job!";
            Task task = new Task("Test")
            {
                IsDone = true,
            };
            task.DueDate = new DateTime(2024, 1, 4);
            //Act
            //Assert
            Assert.AreEqual(expected_message, task.ToString());
        }
    }
}
