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
    public partial class DeleteConfirmation_Form : Form
    {
        public DeleteConfirmation_Form()
        {
            InitializeComponent();
            btn_OkDeleteItem.Click += Btn_OkDeleteItem_Click;
        }
        private void Btn_OkDeleteItem_Click(object sender, EventArgs e)
        {
            ItemDeleted_Form itemDeleted = new ItemDeleted_Form();
            itemDeleted.Show();
            this.Hide();
            itemDeleted.FormClosed -= Main_FormClosed;
            itemDeleted.FormClosed += DeleteConfirmation_FormClosed;
        }
        private void btn_CancelDeleteItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void DeleteConfirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
