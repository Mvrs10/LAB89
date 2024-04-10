namespace GUI_ManagementSystem
{
    partial class AddEditTask_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTask_Form));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.ckbx_Completed = new System.Windows.Forms.CheckBox();
            this.cbbx_Association = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsbx_Courses = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbx_Evaluations = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_NoCourse = new System.Windows.Forms.Label();
            this.lbl_NoEvaluation = new System.Windows.Forms.Label();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Cancel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(137, 269);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 30);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Ok.CausesValidation = false;
            this.btn_Ok.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(32, 269);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(86, 30);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add or Edit Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Completed:";
            // 
            // txb_Description
            // 
            this.txb_Description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_Description.Location = new System.Drawing.Point(122, 159);
            this.txb_Description.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(231, 26);
            this.txb_Description.TabIndex = 17;
            // 
            // ckbx_Completed
            // 
            this.ckbx_Completed.AutoSize = true;
            this.ckbx_Completed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbx_Completed.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbx_Completed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbx_Completed.Location = new System.Drawing.Point(122, 227);
            this.ckbx_Completed.Margin = new System.Windows.Forms.Padding(2);
            this.ckbx_Completed.Name = "ckbx_Completed";
            this.ckbx_Completed.Size = new System.Drawing.Size(50, 20);
            this.ckbx_Completed.TabIndex = 21;
            this.ckbx_Completed.Text = "Yes";
            this.ckbx_Completed.UseVisualStyleBackColor = false;
            // 
            // cbbx_Association
            // 
            this.cbbx_Association.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbx_Association.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbx_Association.FormattingEnabled = true;
            this.cbbx_Association.Items.AddRange(new object[] {
            "Choose an association",
            "Course",
            "Evaluation"});
            this.cbbx_Association.Location = new System.Drawing.Point(122, 127);
            this.cbbx_Association.Name = "cbbx_Association";
            this.cbbx_Association.Size = new System.Drawing.Size(164, 24);
            this.cbbx_Association.TabIndex = 35;
            this.cbbx_Association.SelectedIndexChanged += new System.EventHandler(this.cbbx_Association_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Association:";
            // 
            // lsbx_Courses
            // 
            this.lsbx_Courses.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbx_Courses.FormattingEnabled = true;
            this.lsbx_Courses.ItemHeight = 17;
            this.lsbx_Courses.Location = new System.Drawing.Point(390, 140);
            this.lsbx_Courses.Margin = new System.Windows.Forms.Padding(2);
            this.lsbx_Courses.Name = "lsbx_Courses";
            this.lsbx_Courses.Size = new System.Drawing.Size(165, 89);
            this.lsbx_Courses.TabIndex = 38;
            this.lsbx_Courses.Visible = false;
            this.lsbx_Courses.SelectedIndexChanged += new System.EventHandler(this.lsbx_Courses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(380, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Available courses";
            // 
            // lsbx_Evaluations
            // 
            this.lsbx_Evaluations.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbx_Evaluations.FormattingEnabled = true;
            this.lsbx_Evaluations.ItemHeight = 17;
            this.lsbx_Evaluations.Location = new System.Drawing.Point(608, 140);
            this.lsbx_Evaluations.Margin = new System.Windows.Forms.Padding(2);
            this.lsbx_Evaluations.Name = "lsbx_Evaluations";
            this.lsbx_Evaluations.Size = new System.Drawing.Size(313, 89);
            this.lsbx_Evaluations.TabIndex = 40;
            this.lsbx_Evaluations.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(654, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Available Evaluations";
            // 
            // lbl_NoCourse
            // 
            this.lbl_NoCourse.AutoSize = true;
            this.lbl_NoCourse.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_NoCourse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoCourse.Location = new System.Drawing.Point(409, 146);
            this.lbl_NoCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NoCourse.Name = "lbl_NoCourse";
            this.lbl_NoCourse.Size = new System.Drawing.Size(124, 17);
            this.lbl_NoCourse.TabIndex = 41;
            this.lbl_NoCourse.Text = "No available course";
            this.lbl_NoCourse.Visible = false;
            // 
            // lbl_NoEvaluation
            // 
            this.lbl_NoEvaluation.AutoSize = true;
            this.lbl_NoEvaluation.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_NoEvaluation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoEvaluation.Location = new System.Drawing.Point(690, 146);
            this.lbl_NoEvaluation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NoEvaluation.Name = "lbl_NoEvaluation";
            this.lbl_NoEvaluation.Size = new System.Drawing.Size(144, 17);
            this.lbl_NoEvaluation.TabIndex = 42;
            this.lbl_NoEvaluation.Text = "No available evaluation";
            this.lbl_NoEvaluation.Visible = false;
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.Location = new System.Drawing.Point(122, 192);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.Size = new System.Drawing.Size(202, 20);
            this.dtp_DueDate.TabIndex = 87;
            // 
            // AddEditTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 331);
            this.Controls.Add(this.dtp_DueDate);
            this.Controls.Add(this.lbl_NoEvaluation);
            this.Controls.Add(this.lbl_NoCourse);
            this.Controls.Add(this.lsbx_Evaluations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbx_Courses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbx_Association);
            this.Controls.Add(this.ckbx_Completed);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditTask_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Task";
            this.Load += new System.EventHandler(this.AddEditTask_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.CheckBox ckbx_Completed;
        private System.Windows.Forms.ComboBox cbbx_Association;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbx_Courses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsbx_Evaluations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_NoCourse;
        private System.Windows.Forms.Label lbl_NoEvaluation;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
    }
}