using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_AssignmentTests
    {
        [TestMethod]
        public void ToString_Display_Correctly_NotGroupAssignment()
        {
            //Arrange
            Course course1 = new Course(1, "COMP123");
            string expected_message = "Type: - , Grade: , Weight: 10%, Due Date: 1/4/2024 12:00:00 AM, Group Assignment status: False"; // purposedly fail
            Assignment assignment = new Assignment(course1, 10, new DateTime(2024, 1, 4), false);
            //Act
            //Assert
            Assert.AreEqual(expected_message, assignment.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_IsGroupAssignment()
        {
            //Arrange
            Course course1 = new Course(1, "COMP123");
            string expected_message = "Type: Assignment-, Grade: 0, Weight: 10%, Due Date: 1/4/2024 12:00:00 AM, Group Assignment status: True";
            Assignment assignment = new Assignment(course1, 10, new DateTime(2024, 1, 4), true);
            //Act
            //Assert
            Assert.AreEqual(expected_message, assignment.ToString());
        }
    }
}
