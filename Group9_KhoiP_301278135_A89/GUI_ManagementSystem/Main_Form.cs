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
        }
        private void Btn_ManageCourses_Click(object sender, EventArgs e)
        {
            CourseManager_Form courseManagerForm = new CourseManager_Form();
            courseManagerForm.Show();
            this.Hide();
            courseManagerForm.FormClosed += Manager_FormClosed;
        }

        private void Btn_ManageEvals_Click(object sender, EventArgs e)
        {
            // Open EvaluationManager_Form
            EvaluationManager_Form evaluationManagerForm = new EvaluationManager_Form();
            evaluationManagerForm.Show();
            this.Hide();
            evaluationManagerForm.FormClosed += Manager_FormClosed;
        }

        private void Btn_ManageTasks_Click(object sender, EventArgs e)
        {
            // Open TaskManager_Form
            TaskManager_Form taskManagerForm = new TaskManager_Form();
            taskManagerForm.Show();
            this.Hide();
            taskManagerForm.FormClosed += Manager_FormClosed;
        }
        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
