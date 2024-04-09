namespace GUI_ManagementSystem
{
    partial class TaskManager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Tasks = new System.Windows.Forms.ListBox();
            this.btn_DeleteTask = new System.Windows.Forms.Button();
            this.btn_EditTask = new System.Windows.Forms.Button();
            this.btn_AddTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TaskDetails = new System.Windows.Forms.Label();
            this.btn_ImportTask = new System.Windows.Forms.Button();
            this.btn_ExportTask = new System.Windows.Forms.Button();
            this.btn_AddTaskMyDay = new System.Windows.Forms.Button();
            this.btn_GoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(190, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(238, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "                  Manage your daily tasks and to-dos.\r\nFirst select one task and " +
    "then the option you need: Edit, Delete.";
            // 
            // lst_Tasks
            // 
            this.lst_Tasks.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Tasks.FormattingEnabled = true;
            this.lst_Tasks.ItemHeight = 14;
            this.lst_Tasks.Location = new System.Drawing.Point(215, 225);
            this.lst_Tasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_Tasks.Name = "lst_Tasks";
            this.lst_Tasks.Size = new System.Drawing.Size(154, 214);
            this.lst_Tasks.TabIndex = 6;
            // 
            // btn_DeleteTask
            // 
            this.btn_DeleteTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_DeleteTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTask.Location = new System.Drawing.Point(436, 369);
            this.btn_DeleteTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteTask.Name = "btn_DeleteTask";
            this.btn_DeleteTask.Size = new System.Drawing.Size(86, 30);
            this.btn_DeleteTask.TabIndex = 10;
            this.btn_DeleteTask.Text = "Delete";
            this.btn_DeleteTask.UseVisualStyleBackColor = false;
            this.btn_DeleteTask.Click += new System.EventHandler(this.btn_DeleteTask_Click);
            // 
            // btn_EditTask
            // 
            this.btn_EditTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_EditTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditTask.Location = new System.Drawing.Point(436, 306);
            this.btn_EditTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EditTask.Name = "btn_EditTask";
            this.btn_EditTask.Size = new System.Drawing.Size(86, 30);
            this.btn_EditTask.TabIndex = 9;
            this.btn_EditTask.Text = "Edit";
            this.btn_EditTask.UseVisualStyleBackColor = false;
            this.btn_EditTask.Click += new System.EventHandler(this.btn_EditTask_Click);
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTask.Location = new System.Drawing.Point(436, 245);
            this.btn_AddTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.Size = new System.Drawing.Size(86, 30);
            this.btn_AddTask.TabIndex = 8;
            this.btn_AddTask.Text = "Add";
            this.btn_AddTask.UseVisualStyleBackColor = false;
            this.btn_AddTask.Click += new System.EventHandler(this.Btn_AddTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details";
            // 
            // lbl_TaskDetails
            // 
            this.lbl_TaskDetails.AutoSize = true;
            this.lbl_TaskDetails.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaskDetails.Location = new System.Drawing.Point(18, 225);
            this.lbl_TaskDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TaskDetails.Name = "lbl_TaskDetails";
            this.lbl_TaskDetails.Size = new System.Drawing.Size(105, 45);
            this.lbl_TaskDetails.TabIndex = 12;
            this.lbl_TaskDetails.Text = "**THIS IS \r\nAN INVISIBLE \r\nLABEL**";
            // 
            // btn_ImportTask
            // 
            this.btn_ImportTask.BackColor = System.Drawing.Color.Wheat;
            this.btn_ImportTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportTask.Location = new System.Drawing.Point(317, 503);
            this.btn_ImportTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ImportTask.Name = "btn_ImportTask";
            this.btn_ImportTask.Size = new System.Drawing.Size(140, 37);
            this.btn_ImportTask.TabIndex = 13;
            this.btn_ImportTask.Text = "Import Task";
            this.btn_ImportTask.UseVisualStyleBackColor = false;
            // 
            // btn_ExportTask
            // 
            this.btn_ExportTask.BackColor = System.Drawing.Color.Wheat;
            this.btn_ExportTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportTask.Location = new System.Drawing.Point(136, 503);
            this.btn_ExportTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ExportTask.Name = "btn_ExportTask";
            this.btn_ExportTask.Size = new System.Drawing.Size(140, 37);
            this.btn_ExportTask.TabIndex = 14;
            this.btn_ExportTask.Text = "Export Task";
            this.btn_ExportTask.UseVisualStyleBackColor = false;
            // 
            // btn_AddTaskMyDay
            // 
            this.btn_AddTaskMyDay.BackColor = System.Drawing.Color.Khaki;
            this.btn_AddTaskMyDay.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTaskMyDay.Location = new System.Drawing.Point(20, 401);
            this.btn_AddTaskMyDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddTaskMyDay.Name = "btn_AddTaskMyDay";
            this.btn_AddTaskMyDay.Size = new System.Drawing.Size(110, 38);
            this.btn_AddTaskMyDay.TabIndex = 15;
            this.btn_AddTaskMyDay.Text = "Add Task to My Day";
            this.btn_AddTaskMyDay.UseVisualStyleBackColor = false;
            // 
            // btn_GoMain
            // 
            this.btn_GoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoMain.BackgroundImage")));
            this.btn_GoMain.Location = new System.Drawing.Point(20, 503);
            this.btn_GoMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GoMain.Name = "btn_GoMain";
            this.btn_GoMain.Size = new System.Drawing.Size(56, 51);
            this.btn_GoMain.TabIndex = 30;
            this.btn_GoMain.UseVisualStyleBackColor = true;
            this.btn_GoMain.Click += new System.EventHandler(this.Btn_GoMain_Click);
            // 
            // TaskManager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 592);
            this.Controls.Add(this.btn_GoMain);
            this.Controls.Add(this.btn_AddTaskMyDay);
            this.Controls.Add(this.btn_ExportTask);
            this.Controls.Add(this.btn_ImportTask);
            this.Controls.Add(this.lbl_TaskDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DeleteTask);
            this.Controls.Add(this.btn_EditTask);
            this.Controls.Add(this.btn_AddTask);
            this.Controls.Add(this.lst_Tasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskManager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Tasks;
        private System.Windows.Forms.Button btn_DeleteTask;
        private System.Windows.Forms.Button btn_EditTask;
        private System.Windows.Forms.Button btn_AddTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TaskDetails;
        private System.Windows.Forms.Button btn_ImportTask;
        private System.Windows.Forms.Button btn_ExportTask;
        private System.Windows.Forms.Button btn_AddTaskMyDay;
        private System.Windows.Forms.Button btn_GoMain;
    }
}