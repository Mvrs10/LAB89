﻿using System;
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
    public partial class AddEditCourse_Form : Form
    {
        public AddEditCourse_Form()
        {
            InitializeComponent();
        }
        private void Btn_CancelCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OkCourse_Click(object sender, EventArgs e)
        {
            // Okay button for the AddEddit muts add or edit the items in the list for course, evaluation and task
        }
    }
}
