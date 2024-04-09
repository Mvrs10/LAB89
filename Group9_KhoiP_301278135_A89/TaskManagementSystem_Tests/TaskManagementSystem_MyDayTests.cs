using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_MyDayTests
    {
        [TestMethod]
        public void Create_MyDay_Correctly_UpToDate() // date field has no property, cannot test
        {
            //Arrange
            MyDay myDay = MyDay.NewDay();
            DateTime expected_date = DateTime.Today;
            //Act
            //Assert
        }
        [TestMethod]
        public void TaskList_Display_Correctly() // date field has no property, cannot test
        {
            //Arrange
            MyDay myDay = MyDay.NewDay();
            Task task = new Task("task1");
            string expected_message = "All today's task:\nTask description: task1, No Due Date, Not Done"; // will fail without \n
            //Act
            myDay.AddDayTask(task);
            //Assert
            Assert.AreEqual(message, myDay.ToString());
        }
    }
}

