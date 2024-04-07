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
    public partial class TaskManager_Form : Form
    {
        public TaskManager_Form()
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
            btn_AddTask.Click += Btn_AddTask_Click;
        }

        private void Btn_AddTask_Click(object sender, EventArgs e)
        {
            AddEditTask_Form addEditTask = new AddEditTask_Form();
            addEditTask.Show();
            this.Hide();
            addEditTask.FormClosed -= Main_FormClosed;
            addEditTask.FormClosed += TaskManager_FormClosed;
        }
        private void btn_EditTask_Click(object sender, EventArgs e)
        {
            AddEditTask_Form addEditTask = new AddEditTask_Form();
            addEditTask.Show();
            this.Hide();
            addEditTask.FormClosed -= Main_FormClosed;
            addEditTask.FormClosed += TaskManager_FormClosed;
        }
        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            DeleteConfirmation_Form deleteConfirmation = new DeleteConfirmation_Form();
            deleteConfirmation.Show();
            this.Hide();
            deleteConfirmation.FormClosed -= Main_FormClosed;
            deleteConfirmation.FormClosed += TaskManager_FormClosed;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void TaskManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Btn_GoMain_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
