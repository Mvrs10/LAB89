using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_TaskManagerTests
    {
        public const string InvalidSavePathErrorMessage = "Object reference not set to an instance of an object.";
        public const string InvalidLoadPathErrorMessage = "The current path does not exist";
        [TestMethod]
        public void InvalidPath_Save_TaskList()
        {
            //Arrange
            TaskManager taskManager = new TaskManager();
            string path = $@"Invalid\TaskManager.json";
            //Act
            try
            {
                taskManager.Save(path);
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Contains(e.Message, InvalidSavePathErrorMessage);
            }
        }
        [TestMethod]
        public void InvalidPath_Load_TaskList()
        {
            //Arrange
            TaskManager taskManager = new TaskManager();
            string path = $@"Invalid\TaskManager.json";
            //Act
            try
            {
                taskManager.Load(path);
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Contains(e.Message, InvalidLoadPathErrorMessage);
            }
        }
    }
}
