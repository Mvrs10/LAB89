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
            this.btn_CancelTask = new System.Windows.Forms.Button();
            this.btn_OkTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_DescriptionTask = new System.Windows.Forms.TextBox();
            this.txb_DueDateTask = new System.Windows.Forms.TextBox();
            this.chckBox_CompletedTask = new System.Windows.Forms.CheckBox();
            this.chckBox_NoCompletedTask = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_CancelTask
            // 
            this.btn_CancelTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_CancelTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelTask.Location = new System.Drawing.Point(463, 284);
            this.btn_CancelTask.Name = "btn_CancelTask";
            this.btn_CancelTask.Size = new System.Drawing.Size(114, 37);
            this.btn_CancelTask.TabIndex = 12;
            this.btn_CancelTask.Text = "Cancel";
            this.btn_CancelTask.UseVisualStyleBackColor = false;
            // 
            // btn_OkTask
            // 
            this.btn_OkTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkTask.CausesValidation = false;
            this.btn_OkTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkTask.Location = new System.Drawing.Point(323, 284);
            this.btn_OkTask.Name = "btn_OkTask";
            this.btn_OkTask.Size = new System.Drawing.Size(114, 37);
            this.btn_OkTask.TabIndex = 11;
            this.btn_OkTask.Text = "Ok";
            this.btn_OkTask.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add or Edit Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Completed:";
            // 
            // txb_DescriptionTask
            // 
            this.txb_DescriptionTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DescriptionTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_DescriptionTask.Location = new System.Drawing.Point(161, 150);
            this.txb_DescriptionTask.Name = "txb_DescriptionTask";
            this.txb_DescriptionTask.Size = new System.Drawing.Size(307, 31);
            this.txb_DescriptionTask.TabIndex = 17;
            // 
            // txb_DueDateTask
            // 
            this.txb_DueDateTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DueDateTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_DueDateTask.Location = new System.Drawing.Point(161, 191);
            this.txb_DueDateTask.Name = "txb_DueDateTask";
            this.txb_DueDateTask.Size = new System.Drawing.Size(307, 31);
            this.txb_DueDateTask.TabIndex = 18;
            // 
            // chckBox_CompletedTask
            // 
            this.chckBox_CompletedTask.AutoSize = true;
            this.chckBox_CompletedTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chckBox_CompletedTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBox_CompletedTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chckBox_CompletedTask.Location = new System.Drawing.Point(161, 234);
            this.chckBox_CompletedTask.Name = "chckBox_CompletedTask";
            this.chckBox_CompletedTask.Size = new System.Drawing.Size(60, 24);
            this.chckBox_CompletedTask.TabIndex = 21;
            this.chckBox_CompletedTask.Text = "Yes";
            this.chckBox_CompletedTask.UseVisualStyleBackColor = false;
            // 
            // chckBox_NoCompletedTask
            // 
            this.chckBox_NoCompletedTask.AutoSize = true;
            this.chckBox_NoCompletedTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chckBox_NoCompletedTask.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBox_NoCompletedTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chckBox_NoCompletedTask.Location = new System.Drawing.Point(234, 234);
            this.chckBox_NoCompletedTask.Name = "chckBox_NoCompletedTask";
            this.chckBox_NoCompletedTask.Size = new System.Drawing.Size(54, 24);
            this.chckBox_NoCompletedTask.TabIndex = 22;
            this.chckBox_NoCompletedTask.Text = "No";
            this.chckBox_NoCompletedTask.UseVisualStyleBackColor = false;
            // 
            // AddEditTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 351);
            this.Controls.Add(this.chckBox_NoCompletedTask);
            this.Controls.Add(this.chckBox_CompletedTask);
            this.Controls.Add(this.txb_DueDateTask);
            this.Controls.Add(this.txb_DescriptionTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelTask);
            this.Controls.Add(this.btn_OkTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEditTask_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelTask;
        private System.Windows.Forms.Button btn_OkTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_DescriptionTask;
        private System.Windows.Forms.TextBox txb_DueDateTask;
        private System.Windows.Forms.CheckBox chckBox_CompletedTask;
        private System.Windows.Forms.CheckBox chckBox_NoCompletedTask;
    }
}