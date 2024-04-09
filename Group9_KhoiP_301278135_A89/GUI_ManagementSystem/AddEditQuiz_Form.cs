using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem;

namespace GUI_ManagementSystem
{
    public partial class AddEditQuiz_Form : Form
    {
        Course course;
        public AddEditQuiz_Form(Course course) //Maria, Minh
        {
            InitializeComponent();
            this.course = course;
        }

        private void AddEditQuiz_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            txb_Course.Text = course.ToString();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string name = txb_Name.Text;
            byte weight = Convert.ToByte(txb_Weight.Text);
            DateTime dueDate = dtp_DueDate.Value;
            uint numberOfQuestions = Convert.ToUInt32(txb_NumberOfQuestions.Text);
            course.AddEvaluation(EvaluationType.Quiz, weight, name);
            course.Evaluations[course.Evaluations.Count - 1].DueDate = dueDate;
            Quiz quiz = (Quiz)course.Evaluations[course.Evaluations.Count - 1];
            quiz.NumberOfQuestions = numberOfQuestions;
            //quiz.NumberOfQuestions = numberOfQuestions;
            //quiz = new Quiz(course, weight, numberOfQuestions)
            //{
            //    Name = name,
            //    DueDate = dueDate
            //};
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
