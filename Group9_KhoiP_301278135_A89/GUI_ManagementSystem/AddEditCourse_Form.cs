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
    public partial class AddEditCourse_Form : Form
    {
        Course course;
        CourseManager courseManager = new CourseManager();
        public AddEditCourse_Form(Course course) //Maria, Minh
        {
            InitializeComponent();
            this.course = course;
        }
        private void Btn_CancelCourse_Click(object sender, EventArgs e) //Maria, Minh
        {
            Close();
        }

        private void btn_OkCourse_Click(object sender, EventArgs e) //Maria, Minh
        {
            string code = txt_CourseCode.Text;
            uint id = Convert.ToUInt16(txt_CourseId.Text);
            if (this.course == null)
            {                
                this.course = new Course(id, code);
                courseManager.AddCourse(this.course);
            }
            this.course.Name = txt_CourseName.Text;
            this.course.Code = code;
            this.course.Semester = Convert.ToByte(comboBox_CourseSemester.SelectedItem);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddEditCourse_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            if (this.course != null)
            {
                txt_CourseCode.Text = course.Code;
                txt_CourseName.Text = course.Name;
                comboBox_CourseSemester.SelectedIndex = course.Semester - 1;
                txt_CourseId.Visible = false;
            }
        }
    }
}
