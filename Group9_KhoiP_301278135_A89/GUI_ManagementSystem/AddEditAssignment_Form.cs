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
        public AddEditAssignment_Form(Course course, Assignment assignment)
        {
            InitializeComponent();
            this.course = course;
            this.assignment = assignment;
        }
        private void btn_OkAssignment_Click(object sender, EventArgs e)
        {
            string name = txb_Name.Text;
            byte weight = Convert.ToByte(txb_Weight.Text);
            DateTime dueDate = dtp_DueDate.Value;
            bool isGroupAssignment = ckbx_IsGroupAssignment.Checked;
            if (assignment == null)
            {
                try
                {
                    course.AddEvaluation(EvaluationType.Assignment, weight, name, dueDate);
                    assignment = course.Evaluations[course.Evaluations.Count - 1] as Assignment;
                    assignment.IsGroupAssignment = isGroupAssignment;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
            else
            {
                assignment.Name = name;
                assignment.Weight = weight;
                assignment.DueDate = dueDate;
                assignment.IsGroupAssignment = isGroupAssignment;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void AddEditAssignment_Form_Load(object sender, EventArgs e)
        {
            txb_Course.Text = course.ToString();
            if (assignment != null)
            {
                txb_Name.Text = assignment.Name;
                txb_Weight.Text = Convert.ToString(assignment.Weight);
                dtp_DueDate.Value = assignment.DueDate;
                ckbx_IsGroupAssignment.Checked = assignment.IsGroupAssignment;
            }
        }

        private void btn_CancelAssignment_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
