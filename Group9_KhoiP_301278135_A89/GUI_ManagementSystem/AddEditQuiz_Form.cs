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
        Quiz quiz;
        public AddEditQuiz_Form(Course course, Quiz quiz)
        {
            InitializeComponent();
            this.course = course;
            this.quiz = quiz;
        }

        private void AddEditQuiz_Form_Load(object sender, EventArgs e)
        {
            txb_Course.Text = course.ToString();
            if (quiz != null)
            {
                txb_Name.Text = quiz.Name;
                txb_Weight.Text = Convert.ToString(quiz.Weight);
                dtp_DueDate.Value = quiz.DueDate;
                txb_NumberOfQuestions.Text = Convert.ToString(quiz.NumberOfQuestions);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string name = txb_Name.Text;
            byte weight = Convert.ToByte(txb_Weight.Text);
            DateTime dueDate = dtp_DueDate.Value;
            uint numberOfQuestions = Convert.ToUInt32(txb_NumberOfQuestions.Text);
            if (quiz == null)
            {
                try
                {
                    course.AddEvaluation(EvaluationType.Quiz, weight, name);
                    Quiz quiz = (Quiz)course.Evaluations[course.Evaluations.Count - 1];
                    quiz.NumberOfQuestions = numberOfQuestions;
                    quiz.DueDate = dueDate;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
            else
            {
                quiz.Name = name;
                quiz.Weight = weight;
                quiz.DueDate = dueDate;
                quiz.NumberOfQuestions = numberOfQuestions;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
