using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ManagementSystem
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            btn_ManageCourses.Click += Btn_ManageCourses_Click;
            btn_ManageEvals.Click += Btn_ManageEvals_Click;
            btn_ManageTasks.Click += Btn_ManageTasks_Click;
            btn_ViewMyDay.Click += Btn_ViewMyDay_Click;
        }
        private void Btn_ManageCourses_Click(object sender, EventArgs e)
        {
            CourseManager_Form courseManagerForm = new CourseManager_Form();
            courseManagerForm.Show();
            this.Hide();
            courseManagerForm.FormClosed += Main_FormClosed;
        }

        private void Btn_ManageEvals_Click(object sender, EventArgs e)
        {
            EvaluationManager_Form evaluationManagerForm = new EvaluationManager_Form();
            evaluationManagerForm.Show();
            this.Hide();
            evaluationManagerForm.FormClosed += Main_FormClosed;
        }

        private void Btn_ManageTasks_Click(object sender, EventArgs e)
        {
            TaskManager_Form taskManagerForm = new TaskManager_Form();
            taskManagerForm.Show();
            this.Hide();
            taskManagerForm.FormClosed += Main_FormClosed;
        }

        private void Btn_ViewMyDay_Click(object sender, EventArgs e)
        {
            MyDay_Form myDayForm = new MyDay_Form();
            myDayForm.Show();
            this.Hide();
            myDayForm.FormClosed += Main_FormClosed;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
