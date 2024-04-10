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
    public partial class AddEditTask_Form : Form
    {
        TaskManager taskManager = new TaskManager();
        CourseManager courseManager = new CourseManager();
        List<Course> courses = CourseManager.Courses;
        Evaluation evaluation;
        TaskManagementSystem.Task task;
        public AddEditTask_Form(TaskManagementSystem.Task task) //Maria, Minh
        {
            InitializeComponent();
            this.task = task;
        }

        private void AddEditTask_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            cbbx_Association.SelectedIndex = 0;
            if (task != null)
            {
                cbbx_Association.Enabled = false;
                lsbx_Courses.Enabled= false;
                lsbx_Evaluations.Enabled= false;
                txb_Description.Text = task.Description;
                dtp_DueDate.Value = task.DueDate;
                ckbx_Completed.Checked = task.IsDone;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (cbbx_Association.SelectedIndex == 0 && txb_Description.Text == default) return;
            if (string.IsNullOrEmpty(txb_Description.Text))
            {
                MessageBox.Show("Please enter the description","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_Description.Focus();
                return;
            }
            string description = txb_Description.Text;
            DateTime dueDate = dtp_DueDate.Value;
            bool isDone = ckbx_Completed.Checked;
            if (task == null)
            {
                switch (cbbx_Association.SelectedItem)
                {
                    case "Course":
                        if (lsbx_Courses.SelectedIndex == -1) return;
                        Course course = courses[lsbx_Courses.SelectedIndex];
                        course.AddTask(description);
                        course.Tasks[course.Tasks.Count - 1].DueDate = dueDate;
                        course.Tasks[course.Tasks.Count - 1].IsDone = isDone;
                        break;
                    case "Evaluation":
                        if (lsbx_Evaluations.SelectedIndex == -1) return;
                        Evaluation evaluation = courses[lsbx_Courses.SelectedIndex].Evaluations[lsbx_Evaluations.SelectedIndex];
                        evaluation.AddTask(description);
                        evaluation.Tasks[evaluation.Tasks.Count - 1].DueDate = dueDate;
                        evaluation.Tasks[evaluation.Tasks.Count - 1].IsDone = isDone;
                        break;
                } 
            }
            else
            {
                TaskManagementSystem.Task task = TaskManager.Tasks[TaskManager.Tasks.IndexOf(this.task)];
                task.Description = description;
                task.DueDate = dueDate;
                task.IsDone = isDone;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbbx_Association_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCourseListBox();
            switch (cbbx_Association.SelectedIndex)
            {
                case 0:
                    lbl_NoCourse.Visible = true;
                    lbl_NoEvaluation.Visible = true;
                    lsbx_Courses.Visible = false;
                    lsbx_Evaluations.Visible = false;
                    break;
                case 1:
                    lsbx_Courses.Visible = courses.Count !=0;
                    lsbx_Evaluations.Visible = false;
                    break;
                case 2:
                    lsbx_Courses.Visible = courses.Count != 0;
                    if(lbl_NoEvaluation.Visible==false)lsbx_Evaluations.Visible = true;
                    break;
            }
        }
        private void updateCourseListBox()
        {
            lsbx_Courses.Items.Clear();
            lbl_NoCourse.Visible = courses.Count == 0;
            if (courses.Count != 0)
            {
                foreach (Course course in courses)
                {
                    lsbx_Courses.Items.Add(course);
                }
            }
        }
        private void updateEvaluationListBox()
        {
            lsbx_Evaluations.Items.Clear();             
            Course course = courses[lsbx_Courses.SelectedIndex];
            lbl_NoEvaluation.Visible = course.Evaluations.Count == 0;
            if (course.Evaluations.Count != 0)
            {
                foreach (Evaluation evaluation in course.Evaluations)
                {
                    lsbx_Evaluations.Items.Add(evaluation);
                }
            }
        }
        private void lsbx_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEvaluationListBox();
        }
    }
}
