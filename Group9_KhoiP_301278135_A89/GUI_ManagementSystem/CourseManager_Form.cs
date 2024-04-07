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
    public partial class CourseManager_Form : Form
    {
        private Main_Form main_Form;

        public CourseManager_Form()
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
            btn_AddCourse.Click += Btn_AddCourse_Click;
        }

        private void Btn_GoMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AddCourse_Click(object sender, EventArgs e)
        {
            AddEditCourse_Form addEditCourse = new AddEditCourse_Form();
            addEditCourse.Show();
            this.Hide();
            addEditCourse.FormClosed += CourseManager_FormClosed;
            addEditCourse.FormClosed -= Main_FormClosed;
        }
        private void Btn_EditCourse_Click(object sender, EventArgs e)
        {
            AddEditCourse_Form addEditCourse = new AddEditCourse_Form();
            addEditCourse.Show();
            this.Hide();
            addEditCourse.FormClosed += CourseManager_FormClosed;
            addEditCourse.FormClosed -= Main_FormClosed;
        }
        private void Btn_DeleteCourse_Click(object sender, EventArgs e)
        {
            DeleteConfirmation_Form deleteConfirmation = new DeleteConfirmation_Form();
            deleteConfirmation.Show();
            this.Hide();
            deleteConfirmation.FormClosed -= Main_FormClosed;
            deleteConfirmation.FormClosed += CourseManager_FormClosed;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void CourseManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        
    }
}
