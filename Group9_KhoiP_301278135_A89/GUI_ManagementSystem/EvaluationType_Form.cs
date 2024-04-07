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
    public partial class EvaluationType_Form : Form
    {
        public EvaluationType_Form()
        {
            InitializeComponent();
            btn_AddEditQuiz.Click += Btn_AddEditQuiz_Click;
            btn_AddEditProject.Click += Btn_AddEditProject_Click;
            btn_AddEditTest.Click += Btn_AddEditTest_Click;
            btn_AddEditAssignment.Click += Btn_AddEditAssignment_Click;
            btn_AddEditDiscussion.Click += Btn_AddEditDiscussion_Click;
        }

        private void Btn_AddEditQuiz_Click(object sender, EventArgs e)
        {
            AddEditQuiz_Form addEditQuiz = new AddEditQuiz_Form();
            addEditQuiz.Show();
            this.Hide();
            addEditQuiz.FormClosed -= Main_FormClosed;
            addEditQuiz.FormClosed += EvalManager_FormClosed;
        }
        private void Btn_AddEditAssignment_Click(object sender, EventArgs e)
        {
            AddEditAssignment_Form addEditAssignment = new AddEditAssignment_Form();
            addEditAssignment.Show();
            this.Hide();
            addEditAssignment.FormClosed -= Main_FormClosed;
            addEditAssignment.FormClosed += EvalManager_FormClosed;
        }
        private void Btn_AddEditTest_Click(object sender, EventArgs e)
        {
            AddEditTest_Form addEditTest = new AddEditTest_Form();
            addEditTest.Show();
            this.Hide();
            addEditTest.FormClosed -= Main_FormClosed;
            addEditTest.FormClosed += EvalManager_FormClosed;
        }
        private void Btn_AddEditDiscussion_Click(object sender, EventArgs e)
        {
            AddEditDiscussion_Form addEditDiscussion = new AddEditDiscussion_Form();
            addEditDiscussion.Show();
            this.Hide();
            addEditDiscussion.FormClosed -= Main_FormClosed;
            addEditDiscussion.FormClosed += EvalManager_FormClosed;
        }
        private void Btn_AddEditProject_Click(object sender, EventArgs e)
        {
            AddEditProject_Form addEditProject = new AddEditProject_Form();
            addEditProject.Show();
            this.Hide();
            addEditProject.FormClosed -= Main_FormClosed;
            addEditProject.FormClosed += EvalManager_FormClosed;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void EvalManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
