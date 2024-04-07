namespace GUI_ManagementSystem
{
    partial class CourseManager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManager_Form));
            this.btn_ExportCourse = new System.Windows.Forms.Button();
            this.btn_ImportCourse = new System.Windows.Forms.Button();
            this.lbl_CourseDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DeleteCourse = new System.Windows.Forms.Button();
            this.btn_EditCourse = new System.Windows.Forms.Button();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            this.lst_Courses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CourseEvaluations = new System.Windows.Forms.Label();
            this.btn_GoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExportCourse
            // 
            this.btn_ExportCourse.BackColor = System.Drawing.Color.Wheat;
            this.btn_ExportCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportCourse.Location = new System.Drawing.Point(301, 637);
            this.btn_ExportCourse.Name = "btn_ExportCourse";
            this.btn_ExportCourse.Size = new System.Drawing.Size(187, 46);
            this.btn_ExportCourse.TabIndex = 26;
            this.btn_ExportCourse.Text = "Export Course";
            this.btn_ExportCourse.UseVisualStyleBackColor = false;
            // 
            // btn_ImportCourse
            // 
            this.btn_ImportCourse.BackColor = System.Drawing.Color.Wheat;
            this.btn_ImportCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportCourse.Location = new System.Drawing.Point(542, 637);
            this.btn_ImportCourse.Name = "btn_ImportCourse";
            this.btn_ImportCourse.Size = new System.Drawing.Size(187, 46);
            this.btn_ImportCourse.TabIndex = 25;
            this.btn_ImportCourse.Text = "Import Course";
            this.btn_ImportCourse.UseVisualStyleBackColor = false;
            // 
            // lbl_CourseDetails
            // 
            this.lbl_CourseDetails.AutoSize = true;
            this.lbl_CourseDetails.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CourseDetails.Location = new System.Drawing.Point(36, 293);
            this.lbl_CourseDetails.Name = "lbl_CourseDetails";
            this.lbl_CourseDetails.Size = new System.Drawing.Size(124, 54);
            this.lbl_CourseDetails.TabIndex = 24;
            this.lbl_CourseDetails.Text = "**THIS IS \r\nAN INVISIBLE \r\nLABEL**";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(34, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Details";
            // 
            // btn_DeleteCourse
            // 
            this.btn_DeleteCourse.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_DeleteCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCourse.Location = new System.Drawing.Point(596, 470);
            this.btn_DeleteCourse.Name = "btn_DeleteCourse";
            this.btn_DeleteCourse.Size = new System.Drawing.Size(114, 37);
            this.btn_DeleteCourse.TabIndex = 22;
            this.btn_DeleteCourse.Text = "Delete";
            this.btn_DeleteCourse.UseVisualStyleBackColor = false;
            // 
            // btn_EditCourse
            // 
            this.btn_EditCourse.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_EditCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCourse.Location = new System.Drawing.Point(596, 392);
            this.btn_EditCourse.Name = "btn_EditCourse";
            this.btn_EditCourse.Size = new System.Drawing.Size(114, 37);
            this.btn_EditCourse.TabIndex = 21;
            this.btn_EditCourse.Text = "Edit";
            this.btn_EditCourse.UseVisualStyleBackColor = false;
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddCourse.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCourse.Location = new System.Drawing.Point(596, 317);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(114, 37);
            this.btn_AddCourse.TabIndex = 20;
            this.btn_AddCourse.Text = "Add";
            this.btn_AddCourse.UseVisualStyleBackColor = false;
            // 
            // lst_Courses
            // 
            this.lst_Courses.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Courses.FormattingEnabled = true;
            this.lst_Courses.ItemHeight = 18;
            this.lst_Courses.Location = new System.Drawing.Point(295, 293);
            this.lst_Courses.Name = "lst_Courses";
            this.lst_Courses.Size = new System.Drawing.Size(204, 274);
            this.lst_Courses.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "                   Organize and access your courses.\r\nFirst select one course and" +
    " then the option you need: Edit, Delete.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(310, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Course List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(231, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Course Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(34, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 60);
            this.label5.TabIndex = 27;
            this.label5.Text = "List of \r\nEvaluations";
            // 
            // lbl_CourseEvaluations
            // 
            this.lbl_CourseEvaluations.AutoSize = true;
            this.lbl_CourseEvaluations.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CourseEvaluations.Location = new System.Drawing.Point(36, 513);
            this.lbl_CourseEvaluations.Name = "lbl_CourseEvaluations";
            this.lbl_CourseEvaluations.Size = new System.Drawing.Size(124, 54);
            this.lbl_CourseEvaluations.TabIndex = 28;
            this.lbl_CourseEvaluations.Text = "**THIS IS \r\nAN INVISIBLE \r\nLABEL**";
            // 
            // btn_GoMain
            // 
            this.btn_GoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoMain.BackgroundImage")));
            this.btn_GoMain.Location = new System.Drawing.Point(39, 630);
            this.btn_GoMain.Name = "btn_GoMain";
            this.btn_GoMain.Size = new System.Drawing.Size(74, 63);
            this.btn_GoMain.TabIndex = 29;
            this.btn_GoMain.UseVisualStyleBackColor = true;
            this.btn_GoMain.Click += new System.EventHandler(this.Btn_GoMain_Click);
            // 
            // CourseManager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 728);
            this.Controls.Add(this.btn_GoMain);
            this.Controls.Add(this.lbl_CourseEvaluations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ExportCourse);
            this.Controls.Add(this.btn_ImportCourse);
            this.Controls.Add(this.lbl_CourseDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DeleteCourse);
            this.Controls.Add(this.btn_EditCourse);
            this.Controls.Add(this.btn_AddCourse);
            this.Controls.Add(this.lst_Courses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CourseManager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ExportCourse;
        private System.Windows.Forms.Button btn_ImportCourse;
        private System.Windows.Forms.Label lbl_CourseDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DeleteCourse;
        private System.Windows.Forms.Button btn_EditCourse;
        private System.Windows.Forms.Button btn_AddCourse;
        private System.Windows.Forms.ListBox lst_Courses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CourseEvaluations;
        private System.Windows.Forms.Button btn_GoMain;
    }
}