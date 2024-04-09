namespace GUI_ManagementSystem
{
    partial class AddEditAssignment_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAssignment_Form));
            this.txb_Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Course = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CancelAssignment = new System.Windows.Forms.Button();
            this.btn_OkAssignment = new System.Windows.Forms.Button();
            this.ckbx_IsGroupAssignment = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Weight
            // 
            this.txb_Weight.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Weight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_Weight.Location = new System.Drawing.Point(418, 167);
            this.txb_Weight.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Weight.Name = "txb_Weight";
            this.txb_Weight.Size = new System.Drawing.Size(54, 27);
            this.txb_Weight.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(351, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(37, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Course:";
            // 
            // txb_Course
            // 
            this.txb_Course.Enabled = false;
            this.txb_Course.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_Course.Location = new System.Drawing.Point(109, 122);
            this.txb_Course.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Course.Name = "txb_Course";
            this.txb_Course.Size = new System.Drawing.Size(147, 27);
            this.txb_Course.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Due Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Add or Edit Assignment:";
            // 
            // btn_CancelAssignment
            // 
            this.btn_CancelAssignment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_CancelAssignment.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelAssignment.Location = new System.Drawing.Point(277, 254);
            this.btn_CancelAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CancelAssignment.Name = "btn_CancelAssignment";
            this.btn_CancelAssignment.Size = new System.Drawing.Size(86, 30);
            this.btn_CancelAssignment.TabIndex = 41;
            this.btn_CancelAssignment.Text = "Cancel";
            this.btn_CancelAssignment.UseVisualStyleBackColor = false;
            this.btn_CancelAssignment.Click += new System.EventHandler(this.btn_CancelAssignment_Click);
            // 
            // btn_OkAssignment
            // 
            this.btn_OkAssignment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkAssignment.CausesValidation = false;
            this.btn_OkAssignment.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkAssignment.Location = new System.Drawing.Point(146, 253);
            this.btn_OkAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OkAssignment.Name = "btn_OkAssignment";
            this.btn_OkAssignment.Size = new System.Drawing.Size(86, 30);
            this.btn_OkAssignment.TabIndex = 40;
            this.btn_OkAssignment.Text = "Ok";
            this.btn_OkAssignment.UseVisualStyleBackColor = false;
            this.btn_OkAssignment.Click += new System.EventHandler(this.btn_OkAssignment_Click);
            // 
            // ckbx_IsGroupAssignment
            // 
            this.ckbx_IsGroupAssignment.AutoSize = true;
            this.ckbx_IsGroupAssignment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbx_IsGroupAssignment.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbx_IsGroupAssignment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbx_IsGroupAssignment.Location = new System.Drawing.Point(186, 203);
            this.ckbx_IsGroupAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_IsGroupAssignment.Name = "ckbx_IsGroupAssignment";
            this.ckbx_IsGroupAssignment.Size = new System.Drawing.Size(50, 20);
            this.ckbx_IsGroupAssignment.TabIndex = 54;
            this.ckbx_IsGroupAssignment.Text = "Yes";
            this.ckbx_IsGroupAssignment.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Is Group Assignment:";
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.Location = new System.Drawing.Point(104, 166);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_DueDate.TabIndex = 55;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_Name.Location = new System.Drawing.Point(344, 124);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(128, 27);
            this.txb_Name.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(288, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Name:";
            // 
            // AddEditAssignment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 298);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_DueDate);
            this.Controls.Add(this.ckbx_IsGroupAssignment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelAssignment);
            this.Controls.Add(this.btn_OkAssignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditAssignment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Assignment";
            this.Load += new System.EventHandler(this.AddEditAssignment_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancelAssignment;
        private System.Windows.Forms.Button btn_OkAssignment;
        private System.Windows.Forms.CheckBox ckbx_IsGroupAssignment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label2;
    }
}