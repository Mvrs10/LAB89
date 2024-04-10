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
            this.lsbx_Tasks = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddTask = new System.Windows.Forms.Button();
            this.lbl_TaskDetails = new System.Windows.Forms.Label();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_AddToMyDay = new System.Windows.Forms.Button();
            this.btn_GoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(217, 86);
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
            this.label2.Location = new System.Drawing.Point(271, 191);
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
            this.label3.Location = new System.Drawing.Point(119, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "                  Manage all your tasks and to-dos.\r\n    Select an association wi" +
    "th the task to add a new task.\r\n                       Select a task to edit or " +
    "delete.";
            // 
            // lsbx_Tasks
            // 
            this.lsbx_Tasks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbx_Tasks.FormattingEnabled = true;
            this.lsbx_Tasks.ItemHeight = 17;
            this.lsbx_Tasks.Location = new System.Drawing.Point(136, 225);
            this.lsbx_Tasks.Margin = new System.Windows.Forms.Padding(2);
            this.lsbx_Tasks.Name = "lsbx_Tasks";
            this.lsbx_Tasks.Size = new System.Drawing.Size(393, 208);
            this.lsbx_Tasks.TabIndex = 6;
            this.lsbx_Tasks.SelectedIndexChanged += new System.EventHandler(this.lsbx_Tasks_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Delete.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(562, 378);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 30);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_DeleteTask_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Edit.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(562, 315);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(86, 30);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_EditTask_Click);
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTask.Location = new System.Drawing.Point(562, 254);
            this.btn_AddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.Size = new System.Drawing.Size(86, 30);
            this.btn_AddTask.TabIndex = 8;
            this.btn_AddTask.Text = "Add";
            this.btn_AddTask.UseVisualStyleBackColor = false;
            this.btn_AddTask.Click += new System.EventHandler(this.Btn_AddTask_Click);
            // 
            // lbl_TaskDetails
            // 
            this.lbl_TaskDetails.AutoSize = true;
            this.lbl_TaskDetails.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaskDetails.Location = new System.Drawing.Point(18, 225);
            this.lbl_TaskDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TaskDetails.Name = "lbl_TaskDetails";
            this.lbl_TaskDetails.Size = new System.Drawing.Size(0, 15);
            this.lbl_TaskDetails.TabIndex = 12;
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.Wheat;
            this.btn_Import.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(349, 489);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(140, 37);
            this.btn_Import.TabIndex = 13;
            this.btn_Import.Text = "Import Tasks";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.Wheat;
            this.btn_Export.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.Location = new System.Drawing.Point(168, 489);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(140, 37);
            this.btn_Export.TabIndex = 14;
            this.btn_Export.Text = "Export Tasks";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_AddToMyDay
            // 
            this.btn_AddToMyDay.BackColor = System.Drawing.Color.Khaki;
            this.btn_AddToMyDay.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToMyDay.Location = new System.Drawing.Point(33, 395);
            this.btn_AddToMyDay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddToMyDay.Name = "btn_AddToMyDay";
            this.btn_AddToMyDay.Size = new System.Drawing.Size(76, 38);
            this.btn_AddToMyDay.TabIndex = 15;
            this.btn_AddToMyDay.Text = "Add to My Day";
            this.btn_AddToMyDay.UseVisualStyleBackColor = false;
            this.btn_AddToMyDay.Visible = false;
            this.btn_AddToMyDay.Click += new System.EventHandler(this.btn_AddToMyDay_Click);
            // 
            // btn_GoMain
            // 
            this.btn_GoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoMain.BackgroundImage")));
            this.btn_GoMain.Location = new System.Drawing.Point(20, 503);
            this.btn_GoMain.Margin = new System.Windows.Forms.Padding(2);
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
            this.ClientSize = new System.Drawing.Size(682, 592);
            this.Controls.Add(this.btn_GoMain);
            this.Controls.Add(this.btn_AddToMyDay);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.lbl_TaskDetails);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddTask);
            this.Controls.Add(this.lsbx_Tasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox lsbx_Tasks;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddTask;
        private System.Windows.Forms.Label lbl_TaskDetails;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_AddToMyDay;
        private System.Windows.Forms.Button btn_GoMain;
    }
}