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
        public ItemDeleted_Form() //Maria, Minh
        {
            InitializeComponent();
        }

        private void Btn_OkItemDeleted_Click(object sender, EventArgs e) //Maria, Minh
        {
            Close();
        }

        private void ItemDeleted_Form_Load(object sender, EventArgs e) //Maria, Minh
        {

        }
    }
}
