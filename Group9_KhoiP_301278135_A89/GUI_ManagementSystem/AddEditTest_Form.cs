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
        public AddEditTest_Form(Course course, Evaluation evaluation)
        {
            InitializeComponent();
            this.course = course;
            this.evaluation = evaluation;
        }

        private void AddEditTest_Form_Load(object sender, EventArgs e)
        {
            txb_Course.Text = course.ToString();
            if (evaluation != null)
            {
                txb_Name.Text = evaluation.Name;
                txb_Weight.Text = Convert.ToString(evaluation.Weight);
                dtp_DueDate.Value = evaluation.DueDate;
            }
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
            if (evaluation == null)
            {
                try
                {
                    course.AddEvaluation(EvaluationType.Test, weight, name, dueDate);
                    Evaluation evaluation = course.Evaluations[course.Evaluations.Count - 1];
                    evaluation.DueDate = dueDate;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                evaluation.Name = name;
                evaluation.Weight = weight;
                evaluation.DueDate = dueDate;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
