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
            courseManagerForm.FormClosed += ShowThis;
        }

        private void Btn_ManageEvals_Click(object sender, EventArgs e)
        {
            EvaluationManager_Form evaluationManagerForm = new EvaluationManager_Form();
            evaluationManagerForm.Show();
            this.Hide();
            evaluationManagerForm.FormClosed += ShowThis;
        }

        private void Btn_ManageTasks_Click(object sender, EventArgs e)
        {
            TaskManager_Form taskManagerForm = new TaskManager_Form();
            taskManagerForm.Show();
            this.Hide();
            taskManagerForm.FormClosed += ShowThis;
        }

        private void Btn_ViewMyDay_Click(object sender, EventArgs e)
        {
            MyDay_Form myDayForm = new MyDay_Form(MyDay.NewDay());
            myDayForm.Show();
            this.Hide();
            myDayForm.FormClosed += ShowThis;
        }
        private void ShowThis(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
