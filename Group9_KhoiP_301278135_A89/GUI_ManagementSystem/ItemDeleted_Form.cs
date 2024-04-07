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
    public partial class ItemDeleted_Form : Form
    {
        public ItemDeleted_Form()
        {
            InitializeComponent();
            btn_OkItemDeleted.Click += Btn_OkItemDeleted_Click;
        }

        private void Btn_OkItemDeleted_Click(object sender, EventArgs e)
        {
            //Okay button from the ItemDeleted_Form must update the Evaluation Manager_Form list
            //Is showing the DeleteConfirmation_Form when clicking, this must change 
            this.Close();
        }
    }
}
