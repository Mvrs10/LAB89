using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
using System.Text.Json;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_CourseManagerTests
    {
        public const string InvalidSavePathErrorMessage = "Object reference not set to an instance of an object.";
        public const string InvalidLoadPathErrorMessage = "Object reference not set to an instance of an object.";
        [TestMethod]
        public void InvalidPath_Save_CourseList()
        {
            //Arrange
            CourseManager courseManager = new CourseManager();
            string path = $@"Invalid\CourseManager.json";
            //Act
            try
            {
                courseManager.Save(path);
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Contains(e.Message, InvalidSavePathErrorMessage);
            }
        }
        [TestMethod]
        public void InvalidPath_Load_CourseList()
        {
            //Arrange
            CourseManager courseManager = new CourseManager();
            string path = $@"Invalid\CourseManager.json";
            //Act
            try
            {
                courseManager.Load(path);
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Contains(e.Message, InvalidLoadPathErrorMessage);
            }
        }
    }
}
