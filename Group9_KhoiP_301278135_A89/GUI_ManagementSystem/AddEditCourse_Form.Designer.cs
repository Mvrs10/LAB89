namespace GUI_ManagementSystem
{
    partial class AddEditCourse_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCourse_Form));
            this.txt_CourseCode = new System.Windows.Forms.TextBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CancelCourse = new System.Windows.Forms.Button();
            this.btn_OkCourse = new System.Windows.Forms.Button();
            this.txt_CourseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_CourseSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_CourseCode
            // 
            this.txt_CourseCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CourseCode.Location = new System.Drawing.Point(82, 160);
            this.txt_CourseCode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CourseCode.Name = "txt_CourseCode";
            this.txt_CourseCode.Size = new System.Drawing.Size(115, 26);
            this.txt_CourseCode.TabIndex = 30;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CourseName.Location = new System.Drawing.Point(82, 127);
            this.txt_CourseName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(115, 26);
            this.txt_CourseName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add or Edit Course";
            // 
            // btn_CancelCourse
            // 
            this.btn_CancelCourse.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_CancelCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelCourse.Location = new System.Drawing.Point(264, 206);
            this.btn_CancelCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CancelCourse.Name = "btn_CancelCourse";
            this.btn_CancelCourse.Size = new System.Drawing.Size(86, 30);
            this.btn_CancelCourse.TabIndex = 24;
            this.btn_CancelCourse.Text = "Cancel";
            this.btn_CancelCourse.UseVisualStyleBackColor = false;
            this.btn_CancelCourse.Click += new System.EventHandler(this.Btn_CancelCourse_Click);
            // 
            // btn_OkCourse
            // 
            this.btn_OkCourse.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkCourse.CausesValidation = false;
            this.btn_OkCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkCourse.Location = new System.Drawing.Point(134, 206);
            this.btn_OkCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OkCourse.Name = "btn_OkCourse";
            this.btn_OkCourse.Size = new System.Drawing.Size(86, 30);
            this.btn_OkCourse.TabIndex = 23;
            this.btn_OkCourse.Text = "Ok";
            this.btn_OkCourse.UseVisualStyleBackColor = false;
            this.btn_OkCourse.Click += new System.EventHandler(this.btn_OkCourse_Click);
            // 
            // txt_CourseId
            // 
            this.txt_CourseId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CourseId.Location = new System.Drawing.Point(351, 127);
            this.txt_CourseId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CourseId.Name = "txt_CourseId";
            this.txt_CourseId.Size = new System.Drawing.Size(98, 26);
            this.txt_CourseId.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(262, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Semester:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(262, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID:";
            // 
            // comboBox_CourseSemester
            // 
            this.comboBox_CourseSemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CourseSemester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_CourseSemester.FormattingEnabled = true;
            this.comboBox_CourseSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_CourseSemester.Location = new System.Drawing.Point(351, 158);
            this.comboBox_CourseSemester.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_CourseSemester.Name = "comboBox_CourseSemester";
            this.comboBox_CourseSemester.Size = new System.Drawing.Size(98, 27);
            this.comboBox_CourseSemester.TabIndex = 36;
            // 
            // AddEditCourse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.comboBox_CourseSemester);
            this.Controls.Add(this.txt_CourseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CourseCode);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelCourse);
            this.Controls.Add(this.btn_OkCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditCourse_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Course";
            this.Load += new System.EventHandler(this.AddEditCourse_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CourseCode;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancelCourse;
        private System.Windows.Forms.Button btn_OkCourse;
        private System.Windows.Forms.TextBox txt_CourseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_CourseSemester;
    }
}