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
        }

        private void Btn_GoMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
