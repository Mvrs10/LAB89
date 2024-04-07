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
    public partial class EvaluationManager_Form : Form
    {
        public EvaluationManager_Form()
        {
            InitializeComponent();
            btn_GoMain.Click += Btn_GoMain_Click;
            btn_AddEval.Click += Btn_AddEval_Click;
        }
        private void Btn_GoMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AddEval_Click(object sender, EventArgs e)
        {
            EvaluationType_Form evaluationType = new EvaluationType_Form();
            evaluationType.Show();
            this.Hide();
            evaluationType.FormClosed -= Main_FormClosed;
            evaluationType.FormClosed += EvalManager_FormClosed;
        }
        private void btn_EditEval_Click(object sender, EventArgs e)
        {
            EvaluationType_Form evaluationType = new EvaluationType_Form();
            evaluationType.Show();
            this.Hide();
            evaluationType.FormClosed -= Main_FormClosed;
            evaluationType.FormClosed += EvalManager_FormClosed;
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
