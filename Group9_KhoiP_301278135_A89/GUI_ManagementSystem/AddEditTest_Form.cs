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
    public partial class AddEditTest_Form : Form
    {
        Course course;
        Evaluation evaluation;
        public AddEditTest_Form(Course course) //Maria, Minh
        {
            InitializeComponent();
            this.course = course;
        }

        private void AddEditTest_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            txb_Course.Text = course.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string name = txb_Name.Text;
            byte weight = Convert.ToByte(txb_Weight.Text);
            DateTime dueDate = dtp_DueDate.Value;
            try
            {
                course.AddEvaluation(EvaluationType.Test, weight, name, dueDate);
            }
            catch (Exception)
            {
                throw;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
