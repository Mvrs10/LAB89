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
    public partial class MyDay_Form : Form
    {
        MyDay myDay;
        public MyDay_Form(MyDay myDay) //Maria, Minh
        {
            InitializeComponent();
            this.myDay = myDay;
        }
        private void Btn_GoMain_Click(object sender, EventArgs e) //Maria, Minh
        {
            Close();
        }
        private void MyDay_Form_Load(object sender, EventArgs e) //Maria, Minh
        {
            updateListOfTasks();
        }

        private void updateListOfTasks()
        {

                lbl_Tasks.Text = myDay.ToString();

        }
    }
}
