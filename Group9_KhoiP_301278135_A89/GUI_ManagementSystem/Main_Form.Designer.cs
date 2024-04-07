namespace GUI_ManagementSystem
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ManageCourses = new System.Windows.Forms.Button();
            this.btn_ManageEvals = new System.Windows.Forms.Button();
            this.btn_ManageTasks = new System.Windows.Forms.Button();
            this.btn_ViewMyDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(214, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programming II - Group 9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "School Task Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to your Task Management System. \r\nManage your courses, evaluations, and t" +
    "asks with ease.";
            // 
            // btn_ManageCourses
            // 
            this.btn_ManageCourses.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_ManageCourses.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageCourses.Location = new System.Drawing.Point(207, 201);
            this.btn_ManageCourses.Name = "btn_ManageCourses";
            this.btn_ManageCourses.Size = new System.Drawing.Size(202, 69);
            this.btn_ManageCourses.TabIndex = 4;
            this.btn_ManageCourses.Text = "Manage Courses";
            this.btn_ManageCourses.UseVisualStyleBackColor = false;
            // 
            // btn_ManageEvals
            // 
            this.btn_ManageEvals.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_ManageEvals.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageEvals.Location = new System.Drawing.Point(207, 276);
            this.btn_ManageEvals.Name = "btn_ManageEvals";
            this.btn_ManageEvals.Size = new System.Drawing.Size(202, 69);
            this.btn_ManageEvals.TabIndex = 5;
            this.btn_ManageEvals.Text = "Manage Evaluations";
            this.btn_ManageEvals.UseVisualStyleBackColor = false;
            // 
            // btn_ManageTasks
            // 
            this.btn_ManageTasks.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_ManageTasks.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageTasks.Location = new System.Drawing.Point(207, 354);
            this.btn_ManageTasks.Name = "btn_ManageTasks";
            this.btn_ManageTasks.Size = new System.Drawing.Size(202, 69);
            this.btn_ManageTasks.TabIndex = 6;
            this.btn_ManageTasks.Text = "Manage Tasks";
            this.btn_ManageTasks.UseVisualStyleBackColor = false;
            // 
            // btn_ViewMyDay
            // 
            this.btn_ViewMyDay.BackColor = System.Drawing.Color.Khaki;
            this.btn_ViewMyDay.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewMyDay.Location = new System.Drawing.Point(524, 259);
            this.btn_ViewMyDay.Name = "btn_ViewMyDay";
            this.btn_ViewMyDay.Size = new System.Drawing.Size(168, 102);
            this.btn_ViewMyDay.TabIndex = 7;
            this.btn_ViewMyDay.Text = "View My Day Details";
            this.btn_ViewMyDay.UseVisualStyleBackColor = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 531);
            this.Controls.Add(this.btn_ViewMyDay);
            this.Controls.Add(this.btn_ManageTasks);
            this.Controls.Add(this.btn_ManageEvals);
            this.Controls.Add(this.btn_ManageCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ManageCourses;
        private System.Windows.Forms.Button btn_ManageEvals;
        private System.Windows.Forms.Button btn_ManageTasks;
        private System.Windows.Forms.Button btn_ViewMyDay;
    }
}

