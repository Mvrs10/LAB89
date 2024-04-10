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
//Maria, Minh
namespace GUI_ManagementSystem
{
    public partial class TaskManager_Form : Form
    {
        TaskManager taskManager = new TaskManager();
        public TaskManager_Form()
        {
            InitializeComponent();
        }

        private void Btn_AddTask_Click(object sender, EventArgs e)
        {
            AddEditTask_Form addEditTask = new AddEditTask_Form(default);
            this.Hide();
            addEditTask.FormClosed += ShowThis;
            if (addEditTask.ShowDialog() != DialogResult.OK) return;
            updateTaskListBox();
        }

        private void updateTaskListBox()
        {
            lsbx_Tasks.Items.Clear();
            if (TaskManager.Tasks.Count != 0)
            {
                foreach (TaskManagementSystem.Task task in TaskManager.Tasks)
                {
                    lsbx_Tasks.Items.Add(task);
                }
                btn_Edit.Visible = lsbx_Tasks.SelectedIndex != -1;
                btn_Delete.Visible = lsbx_Tasks.SelectedIndex != -1;
                btn_AddToMyDay.Visible = lsbx_Tasks.SelectedIndex != -1;
            }
        }

        private void btn_EditTask_Click(object sender, EventArgs e)
        {
            TaskManagementSystem.Task task = lsbx_Tasks.SelectedItem as TaskManagementSystem.Task;
            AddEditTask_Form addEditTask = new AddEditTask_Form(task);
            this.Hide();
            addEditTask.FormClosed += ShowThis;
            if (addEditTask.ShowDialog() != DialogResult.OK) return;
            updateTaskListBox();
        }
        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            DeleteConfirmation_Form deleteConfirmation = new DeleteConfirmation_Form();
            this.Hide();
            deleteConfirmation.FormClosed += ShowThis;
            if(deleteConfirmation.ShowDialog() == DialogResult.OK)
            {
                TaskManager.Tasks.RemoveAt(lsbx_Tasks.SelectedIndex);
                lsbx_Tasks.Items.Remove(lsbx_Tasks.SelectedItem);
                updateTaskListBox();
            }
        }
        private void ShowThis(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Btn_GoMain_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void TaskManager_Form_Load(object sender, EventArgs e)
        {
            updateTaskListBox();
        }

        private void lsbx_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Edit.Visible = lsbx_Tasks.SelectedIndex != -1;
            btn_Delete.Visible = lsbx_Tasks.SelectedIndex != -1;
            btn_AddToMyDay.Visible = lsbx_Tasks.SelectedIndex != -1;
        }

        private void btn_AddToMyDay_Click(object sender, EventArgs e)
        {
            TaskManagementSystem.Task task = lsbx_Tasks.SelectedItem as TaskManagementSystem.Task;
            MyDay myDay = MyDay.NewDay();
            myDay.AddDayTask(task);
            new MyDay_Form(myDay);
            MessageBox.Show("Successfully added", "MyDay", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "TaskManager.json";
                taskManager.Save(path);
                MessageBox.Show("Successfully saved", "All tasks", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch { throw; }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "TaskManager.json";
                taskManager.Load(path);
                MessageBox.Show("Successfully loaded", "All tasks", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch { throw; }
            finally
            {
                //updateCourseListBox();
                //Refresh();
                TaskManager_Form taskManager_Form = new TaskManager_Form();
                taskManager_Form.ShowDialog();
                Close();
            }
        }
    }
}
