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
    public partial class EvaluationManager_Form : Form
    {
        CourseManager courseManager = new CourseManager();
        List<Course> courses = CourseManager.Courses;        
        public EvaluationManager_Form()
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
        }
        private void Btn_GoMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_AddEvaluation_Click(object sender, EventArgs e)
        {
            Course course = courses[lsbx_Courses.SelectedIndex];
            //course = lsbx_Courses.SelectedItem as Course;
            if (lsbx_Courses.SelectedIndex == -1 || cbbx_EvaluationType.SelectedIndex == 0 || course == null)
            {
                lbl_instruction.Text = "Please select a course and an evaluation type";
                return;
            }
            //Evaluation evaluation = lsbx_Evaluations.SelectedItem as Evaluation;
            switch (cbbx_EvaluationType.SelectedItem)
            {
                case "Assignment":
                    AddEditAssignment_Form addEditAssignment_Form = new AddEditAssignment_Form(course, default);                    
                    this.Hide();
                    addEditAssignment_Form.FormClosed += ShowThis;
                    if(addEditAssignment_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case "Quiz":
                    AddEditQuiz_Form addEditQuiz_Form = new AddEditQuiz_Form(course, default);
                    this.Hide();
                    addEditQuiz_Form.FormClosed += ShowThis;
                    if (addEditQuiz_Form.ShowDialog() != DialogResult.OK) return;;
                    break;
                case "Test":
                    AddEditTest_Form addEditTest_Form = new AddEditTest_Form(course, default);
                    this.Hide();
                    addEditTest_Form.FormClosed += ShowThis;
                    if (addEditTest_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case "Discussion":
                    AddEditDiscussion_Form addDiscussionTest_Form = new AddEditDiscussion_Form(course, default);
                    this.Hide();
                    addDiscussionTest_Form.FormClosed += ShowThis;
                    if (addDiscussionTest_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case "Project":
                    AddEditProject_Form addEditProject_Form = new AddEditProject_Form(course, default);
                    this.Hide();
                    addEditProject_Form.FormClosed += ShowThis;
                    if (addEditProject_Form.ShowDialog() != DialogResult.OK) return;
                    break;
            }
            updateCourseListBox();
        }
        private void btn_EditEval_Click(object sender, EventArgs e)
        {
            Course course = courses[lsbx_Courses.SelectedIndex];
            //course = lsbx_Courses.SelectedItem as Course;
            Evaluation evaluation = lsbx_Evaluations.SelectedItem as Evaluation;
            if (course == null || evaluation == null) return;
            switch (evaluation.Type)
            {
                case EvaluationType.Assignment:
                    Assignment assignment = evaluation as Assignment;
                    AddEditAssignment_Form addEditAssignment_Form = new AddEditAssignment_Form(course, assignment);
                    this.Hide();
                    addEditAssignment_Form.FormClosed += ShowThis;
                    if (addEditAssignment_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case EvaluationType.Quiz:
                    Quiz quiz = evaluation as Quiz;
                    AddEditQuiz_Form addEditQuiz_Form = new AddEditQuiz_Form(course, quiz);
                    this.Hide();
                    addEditQuiz_Form.FormClosed += ShowThis;
                    if (addEditQuiz_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case EvaluationType.Discussion:
                    AddEditDiscussion_Form addEditDiscussion_Form = new AddEditDiscussion_Form(course, evaluation);
                    this.Hide();
                    addEditDiscussion_Form.FormClosed += ShowThis;
                    if (addEditDiscussion_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case EvaluationType.Project:
                    AddEditProject_Form addEditProject_Form = new AddEditProject_Form(course, evaluation);
                    this.Hide();
                    addEditProject_Form.FormClosed += ShowThis;
                    if (addEditProject_Form.ShowDialog() != DialogResult.OK) return;
                    break;
                case EvaluationType.Test:
                    AddEditTest_Form addEditTest_Form = new AddEditTest_Form(course, evaluation);
                    this.Hide();
                    addEditTest_Form.FormClosed += ShowThis;
                    if (addEditTest_Form.ShowDialog() != DialogResult.OK) return;
                    break;
            }

        }
        private void ShowThis(object sender, FormClosedEventArgs e)
        {
            cbbx_EvaluationType.SelectedIndex = 0;
            lbl_EvaluationList.Text = string.Empty;
            lbl_instruction.Text = string.Empty;
            btn_EditEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;
            btn_DeleteEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;            
            this.Show();
        }

        private void EvaluationManager_Form_Load(object sender, EventArgs e)
        {
            updateCourseListBox();
            cbbx_EvaluationType.SelectedIndex = 0;
        }

        private void updateCourseListBox() //Maria, Minh
        {
            lsbx_Courses.Items.Clear();
            foreach (Course course in this.courses)
            {
                lsbx_Courses.Items.Add(course);
            }
            updateEvaluationListBox();
        }

        private void lsbx_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Courses.SelectedIndex == -1) return;
            Course course = courses[lsbx_Courses.SelectedIndex];
            //course = (Course)lsbx_Courses.SelectedItem;
            updateEvaluationListBox();
            lbl_EvaluationList.Text = string.Empty;
            int i = 1;
            foreach (Evaluation evaluation in course.Evaluations)
            {                
                lbl_EvaluationList.Text += $"{i}/ "+evaluation.FormatedString()+"\n\n";
                i++;
            }
            btn_EditEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;
            btn_DeleteEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;
        }

        private void updateEvaluationListBox()
        {
            lsbx_Evaluations.Items.Clear();
            if (lsbx_Courses.SelectedIndex == -1) return;
            Course course = courses[lsbx_Courses.SelectedIndex];
            course = lsbx_Courses.SelectedItem as Course;
            foreach (Evaluation evaluation in course.Evaluations)
            {
                lsbx_Evaluations.Items.Add(evaluation);
            }
        }
        private void lsbx_Evaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Evaluations.SelectedIndex == -1) return;
            btn_EditEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;
            btn_DeleteEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1 && lsbx_Courses.SelectedIndex != -1;
        }

        private void btn_DeleteEvaluation_Click(object sender, EventArgs e)
        {
            DeleteConfirmation_Form deleteConfirmation = new DeleteConfirmation_Form();
            this.Hide();
            deleteConfirmation.FormClosed += ShowThis;
            if (deleteConfirmation.ShowDialog() == DialogResult.OK)
            {
                courses[lsbx_Courses.SelectedIndex].Evaluations.RemoveAt(lsbx_Evaluations.SelectedIndex);
                lsbx_Evaluations.Items.Remove(lsbx_Evaluations.SelectedItem);
                updateCourseListBox();
            }
            else return;
        }
    }
}
