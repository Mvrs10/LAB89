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
    public partial class CourseManager_Form : Form
    {
        public CourseManager courseManager = new CourseManager();
        public List<Course> courses=CourseManager.Courses;
        public List<TaskManagementSystem.Task> tasks=new List<TaskManagementSystem.Task>();

        public CourseManager_Form() //Maria, Minh
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
            btn_AddCourse.Click += Btn_AddCourse_Click;
        }

        private void Btn_GoMain_Click(object sender, EventArgs e) //Maria, Minh
        {
            this.Close();
        }

        private void Btn_AddCourse_Click(object sender, EventArgs e) //Maria, Minh
        {
            AddEditCourse_Form addEditCourse = new AddEditCourse_Form();
            this.Hide();            
            addEditCourse.FormClosed += ShowThis;
            if (addEditCourse.ShowDialog() != DialogResult.OK) return;
            courses.Add(addEditCourse.course);
            updateCourseListBox();
        }

        private void updateCourseListBox()
        {
            lsbx_Courses.Items.Clear();
            foreach (Course course in this.courses)
            {
                lsbx_Courses.Items.Add(course);
            }
            btn_EditCourse.Visible = lsbx_Courses.SelectedIndex != -1;
            btn_DeleteCourse.Visible = lsbx_Courses.SelectedIndex != -1;
        }

        private void Btn_EditCourse_Click(object sender, EventArgs e) //Maria, Minh
        {
            Course editedCourse = lsbx_Courses.SelectedItem as Course;
            AddEditCourse_Form addEditCourse = new AddEditCourse_Form();
            addEditCourse.course = editedCourse;
            this.Hide();
            addEditCourse.FormClosed += ShowThis;
            if (addEditCourse.ShowDialog() != DialogResult.OK) return;            
            updateCourseListBox();
        }
        private void Btn_DeleteCourse_Click(object sender, EventArgs e) //Maria, Minh
        {
            DeleteConfirmation_Form deleteConfirmation = new DeleteConfirmation_Form();
            this.Hide();
            deleteConfirmation.FormClosed += ShowThis;
            if (deleteConfirmation.ShowDialog() == DialogResult.OK)
            {
                courses.RemoveAt(lsbx_Courses.SelectedIndex);
                lsbx_Courses.Items.Remove(lsbx_Courses.SelectedItem);
            }
            updateCourseListBox();
        }
        private void ShowThis(object sender, FormClosedEventArgs e) //Maria, Minh
        {
            this.Show();
            lbl_CourseDetails.Text = string.Empty;
        }

        private void CourseManager_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            updateCourseListBox();
        }

        private void lsbx_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Courses.SelectedIndex == -1) return;
            Course course = (Course)lsbx_Courses.SelectedItem;
            lbl_CourseDetails.Text = course.Formatted_String();
            btn_EditCourse.Visible = lsbx_Courses.SelectedIndex != -1;
            btn_DeleteCourse.Visible = lsbx_Courses.SelectedIndex != -1;
        }
    }
}
