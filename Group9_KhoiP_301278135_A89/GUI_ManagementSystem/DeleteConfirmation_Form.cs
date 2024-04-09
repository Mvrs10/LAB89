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
        public DeleteConfirmation_Form() //Maria, Minh
        {
            InitializeComponent();
        }
        private void Btn_OkDeleteItem_Click(object sender, EventArgs e) //Maria, Minh
        {
            DialogResult = DialogResult.OK;
            ItemDeleted_Form itemDeleted = new ItemDeleted_Form();
            itemDeleted.ShowDialog();
            this.Close();
        }
        private void btn_CancelDeleteItem_Click(object sender, EventArgs e) //Maria, Minh
        {
            this.Close();
        }

        private void DeleteConfirmation_Form_Load(object sender, EventArgs e) //Maria, Minh
        {

        }
    }
}
