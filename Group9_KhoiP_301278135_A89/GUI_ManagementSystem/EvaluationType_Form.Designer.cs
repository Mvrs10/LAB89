namespace GUI_ManagementSystem
{
    partial class EvaluationType_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationType_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddEditAssignment = new System.Windows.Forms.Button();
            this.btn_AddEditQuiz = new System.Windows.Forms.Button();
            this.btn_AddEditTest = new System.Windows.Forms.Button();
            this.btn_AddEditProject = new System.Windows.Forms.Button();
            this.btn_AddEditDiscussion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Please select the type of evaluation you wish to create or modify:";
            // 
            // btn_AddEditAssignment
            // 
            this.btn_AddEditAssignment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEditAssignment.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEditAssignment.Location = new System.Drawing.Point(295, 169);
            this.btn_AddEditAssignment.Name = "btn_AddEditAssignment";
            this.btn_AddEditAssignment.Size = new System.Drawing.Size(154, 41);
            this.btn_AddEditAssignment.TabIndex = 38;
            this.btn_AddEditAssignment.Text = "Assignment";
            this.btn_AddEditAssignment.UseVisualStyleBackColor = false;
            // 
            // btn_AddEditQuiz
            // 
            this.btn_AddEditQuiz.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEditQuiz.CausesValidation = false;
            this.btn_AddEditQuiz.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEditQuiz.Location = new System.Drawing.Point(111, 169);
            this.btn_AddEditQuiz.Name = "btn_AddEditQuiz";
            this.btn_AddEditQuiz.Size = new System.Drawing.Size(154, 41);
            this.btn_AddEditQuiz.TabIndex = 37;
            this.btn_AddEditQuiz.Text = "Quiz";
            this.btn_AddEditQuiz.UseVisualStyleBackColor = false;
            // 
            // btn_AddEditTest
            // 
            this.btn_AddEditTest.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEditTest.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEditTest.Location = new System.Drawing.Point(473, 169);
            this.btn_AddEditTest.Name = "btn_AddEditTest";
            this.btn_AddEditTest.Size = new System.Drawing.Size(154, 41);
            this.btn_AddEditTest.TabIndex = 40;
            this.btn_AddEditTest.Text = "Test";
            this.btn_AddEditTest.UseVisualStyleBackColor = false;
            // 
            // btn_AddEditProject
            // 
            this.btn_AddEditProject.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEditProject.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEditProject.Location = new System.Drawing.Point(388, 255);
            this.btn_AddEditProject.Name = "btn_AddEditProject";
            this.btn_AddEditProject.Size = new System.Drawing.Size(154, 41);
            this.btn_AddEditProject.TabIndex = 42;
            this.btn_AddEditProject.Text = "Project";
            this.btn_AddEditProject.UseVisualStyleBackColor = false;
            // 
            // btn_AddEditDiscussion
            // 
            this.btn_AddEditDiscussion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEditDiscussion.CausesValidation = false;
            this.btn_AddEditDiscussion.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEditDiscussion.Location = new System.Drawing.Point(204, 255);
            this.btn_AddEditDiscussion.Name = "btn_AddEditDiscussion";
            this.btn_AddEditDiscussion.Size = new System.Drawing.Size(154, 41);
            this.btn_AddEditDiscussion.TabIndex = 41;
            this.btn_AddEditDiscussion.Text = " Discussion";
            this.btn_AddEditDiscussion.UseVisualStyleBackColor = false;
            // 
            // EvaluationType_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 340);
            this.Controls.Add(this.btn_AddEditProject);
            this.Controls.Add(this.btn_AddEditDiscussion);
            this.Controls.Add(this.btn_AddEditTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddEditAssignment);
            this.Controls.Add(this.btn_AddEditQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EvaluationType_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Evaluation Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddEditAssignment;
        private System.Windows.Forms.Button btn_AddEditQuiz;
        private System.Windows.Forms.Button btn_AddEditTest;
        private System.Windows.Forms.Button btn_AddEditProject;
        private System.Windows.Forms.Button btn_AddEditDiscussion;
    }
}