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
        public EvaluationManager_Form() //Maria, Minh
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
        }
        private void Btn_GoMain_Click(object sender, EventArgs e) //Maria, Minh
        {
            this.Close();
        }
        private void btn_AddEvaluation_Click(object sender, EventArgs e) //Maria, Minh
        {
            //EvaluationType evaluationType = (EvaluationType)cbbx_EvaluationType.SelectedItem;
            Course course = lsbx_Courses.SelectedItem as Course;
            //Evaluation evaluation = lsbx_Evaluations.SelectedItem as Evaluation;
            switch (cbbx_EvaluationType.SelectedItem)
            {
                case "Assignment":
                    AddEditAssignment_Form addEditAssignment_Form = new AddEditAssignment_Form();                    
                    addEditAssignment_Form.course = course;
                    this.Hide();
                    addEditAssignment_Form.FormClosed += ShowThis;
                    if(addEditAssignment_Form.ShowDialog() != DialogResult.OK) return;
                    updateEvaluationListBox();
                    lsbx_Courses.SelectedIndex = -1;
                    break;
                case "Quiz":
                    AddEditQuiz_Form addEditQuiz_Form = new AddEditQuiz_Form(course);
                    //addEditQuiz_Form.course = course;
                    this.Hide();
                    addEditQuiz_Form.FormClosed += ShowThis;
                    if (addEditQuiz_Form.ShowDialog() != DialogResult.OK) return;
                    updateEvaluationListBox();
                    lsbx_Courses.SelectedIndex = -1;
                    break;
                case "Test":
                    AddEditTest_Form addEditTest_Form = new AddEditTest_Form();
                    addEditTest_Form.course = course;
                    this.Hide();
                    addEditTest_Form.FormClosed += ShowThis;
                    if (addEditTest_Form.ShowDialog() != DialogResult.OK) return;
                    courses[lsbx_Courses.SelectedIndex].Evaluations.Add(addEditTest_Form.evaluation);
                    updateEvaluationListBox();
                    lsbx_Courses.SelectedIndex = -1;
                    break;
                case "Discussion":
                    AddEditDiscussion_Form addEditDiscussion_Form = new AddEditDiscussion_Form();
                    addEditDiscussion_Form.course = course;
                    this.Hide();
                    addEditDiscussion_Form.FormClosed += ShowThis;
                    if (addEditDiscussion_Form.ShowDialog() != DialogResult.OK) return;
                    courses[lsbx_Courses.SelectedIndex].Evaluations.Add(addEditDiscussion_Form.evaluation);
                    updateEvaluationListBox();
                    lsbx_Courses.SelectedIndex = -1;
                    break;
                case "Project":
                    AddEditProject_Form addEditProject_Form = new AddEditProject_Form();
                    addEditProject_Form.course = course;
                    this.Hide();
                    addEditProject_Form.FormClosed += ShowThis;
                    if (addEditProject_Form.ShowDialog() != DialogResult.OK) return;
                    courses[lsbx_Courses.SelectedIndex].Evaluations.Add(addEditProject_Form.evaluation);
                    updateEvaluationListBox();
                    lsbx_Courses.SelectedIndex = -1;
                    break;
            }
        }
        private void btn_EditEval_Click(object sender, EventArgs e) //Maria, Minh
        {
            Course course = lsbx_Courses.SelectedItem as Course;
            Evaluation evaluation = lsbx_Evaluations.SelectedItem as Evaluation;
            switch (evaluation.Type)
            {
                case EvaluationType.Assignment:
                    AddEditAssignment_Form addEditAssignment_Form = new AddEditAssignment_Form();
                    addEditAssignment_Form.course = course;
                    this.Hide();
                    addEditAssignment_Form.FormClosed += ShowThis;
                    if (addEditAssignment_Form.ShowDialog() != DialogResult.OK) return;
                    lsbx_Courses.SelectedIndex = -1;
                    updateEvaluationListBox();
                    break;
            }

        }
        private void ShowThis(object sender, FormClosedEventArgs e) //Maria, Minh
        {
            lbl_options.Visible = true;
            cbbx_EvaluationType.SelectedIndex = -1;
            lbl_EvaluationList.Text = string.Empty;
            updateEvaluationListBox();
            this.Show();
        }

        private void EvaluationManager_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            updateCourseListBox();
        }

        private void updateCourseListBox() //Maria, Minh
        {
            lsbx_Courses.Items.Clear();
            foreach (Course course in this.courses)
            {
                lsbx_Courses.Items.Add(course);
            }
            btn_AddEvaluation.Visible = lsbx_Courses.SelectedIndex != -1;
        }

        private void lsbx_Courses_SelectedIndexChanged(object sender, EventArgs e) //aria, Minh
        {
            if (lsbx_Courses.SelectedIndex == -1) return;
            Course course = (Course)lsbx_Courses.SelectedItem;
            lbl_EvaluationList.Text = string.Empty;
            int i = 1;
            foreach (Evaluation evaluation in course.Evaluations)
            {                
                lbl_EvaluationList.Text += $"{i}/ "+evaluation.FormatedString()+"\n\n";
                i++;
            }
            updateEvaluationListBox();
            btn_AddEvaluation.Visible = lsbx_Courses.SelectedIndex != -1;
        }

        private void updateEvaluationListBox()
        {
            lsbx_Evaluations.Items.Clear();
            Course course = (Course)lsbx_Courses.SelectedItem;
            foreach (Evaluation evaluation in course.Evaluations)
            {
                lsbx_Evaluations.Items.Add(evaluation);
            }
        }

        private void cbbx_EvaluationType_DropDown(object sender, EventArgs e)
        {
            lbl_options.Visible = false;
        }

        private void lsbx_Evaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Evaluations.SelectedIndex == -1) return;
            btn_EditEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1;
            btn_DeleteEvaluation.Visible = lsbx_Evaluations.SelectedIndex != -1;
        }
    }
}
