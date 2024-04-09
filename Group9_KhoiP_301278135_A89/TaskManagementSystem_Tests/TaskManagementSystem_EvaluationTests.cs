using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementSystem;
//KhoiP_301278135
namespace TaskManagementSystem_Tests
{
    [TestClass]
    public class TaskManagementSystem_EvaluationTests
    {
        [TestMethod]
        public void ToString_Display_Correctly_NoDueDate()
        {
            //Arrange
            string expected_message = "Type: Project-, Grade: 0, Weight: 10%, No Due Date";
            Evaluation evaluation = new Evaluation(new Course(1,"COMP123"), EvaluationType.Project, 10);
            //Act
            //Assert
            Assert.AreEqual(expected_message, evaluation.ToString());
        }
        [TestMethod]
        public void ToString_Display_Correctly_HaveDueDate()
        {
            //Arrange
            string expected_message = "Type: Project-, Grade: 0, Weight: 10%, Due Date: 4/30/2024 12:00:00 AM";
            Evaluation evaluation = new Evaluation(new Course(1, "COMP123"), EvaluationType.Project, 10);
            //Act
            evaluation.DueDate = new DateTime(2024, 4, 30);
            //Assert
            Assert.AreEqual(expected_message, evaluation.ToString());
        }
        [TestMethod]
        public void Weight_ValidValue_Set()
        {
            //Arrange
            byte expected_weight=25;
            Course course = new Course(1, "COMP123");
            course.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 5, 27));
            //Act
            course.Evaluations[0].Weight = 25;
            //Assert
            Assert.AreEqual(expected_weight, course.Evaluations[0].Weight);
        }
        [TestMethod]
        public void Weight_InvalidValue_Set()
        {
            //Arrange
            string expected_error_message = "Total evaluations weight exceeds 100%";
            Course course = new Course(1, "COMP123");
            course.AddEvaluation(EvaluationType.Assignment, 15, "A4", new DateTime(2024, 5, 27));
            //Act
            try
            {
                course.Evaluations[0].Weight=120;
            }
            catch (Exception e)
            {
                //Assert
                StringAssert.Equals(expected_error_message, e.Message);
            }
        }
    }
}
