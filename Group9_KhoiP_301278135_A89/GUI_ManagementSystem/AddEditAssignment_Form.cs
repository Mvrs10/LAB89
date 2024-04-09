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
    public partial class AddEditAssignment_Form : Form
    {
        Assignment assignment;
        Course course;
        public AddEditAssignment_Form(Course course) //Maria, Minh
        {
            InitializeComponent();
            this.course = course;
        }
        private void btn_OkAssignment_Click(object sender, EventArgs e) //Maria, Minh
        {
            string name = txb_Name.Text;
            byte weight = Convert.ToByte(txb_Weight.Text);
            DateTime dueDate = dtp_DueDate.Value;
            bool isGroupAssignment = ckbx_IsGroupAssignment.Checked;
            try
            {
                course.AddEvaluation(EvaluationType.Assignment, weight, name, dueDate);
            }
            catch (Exception)
            {
                throw;
            }
            assignment = course.Evaluations[course.Evaluations.Count - 1] as Assignment;
            assignment.IsGroupAssignment = isGroupAssignment;
            //assignment = new Assignment(course, weight, dueDate, isGroupAssignment);
            //assignment.Name = name;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void AddEditAssignment_Form_Load(object sender, EventArgs e)//Maria, Minh
        {
            txb_Course.Text = course.ToString();
        }

        private void btn_CancelAssignment_Click(object sender, EventArgs e)//Maria, Minh
        {
            Close();
        }
    }
}
