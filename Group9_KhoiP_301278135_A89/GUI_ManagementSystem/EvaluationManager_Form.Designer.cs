namespace GUI_ManagementSystem
{
    partial class EvaluationManager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationManager_Form));
            this.lbl_EvaluationList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DeleteEvaluation = new System.Windows.Forms.Button();
            this.btn_EditEvaluation = new System.Windows.Forms.Button();
            this.btn_AddEvaluation = new System.Windows.Forms.Button();
            this.lsbx_Courses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoMain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lsbx_Evaluations = new System.Windows.Forms.ListBox();
            this.cbbx_EvaluationType = new System.Windows.Forms.ComboBox();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_EvaluationList
            // 
            this.lbl_EvaluationList.AutoSize = true;
            this.lbl_EvaluationList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EvaluationList.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EvaluationList.Location = new System.Drawing.Point(27, 235);
            this.lbl_EvaluationList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EvaluationList.Name = "lbl_EvaluationList";
            this.lbl_EvaluationList.Size = new System.Drawing.Size(0, 14);
            this.lbl_EvaluationList.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Evaluations in course";
            // 
            // btn_DeleteEvaluation
            // 
            this.btn_DeleteEvaluation.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_DeleteEvaluation.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEvaluation.Location = new System.Drawing.Point(405, 477);
            this.btn_DeleteEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteEvaluation.Name = "btn_DeleteEvaluation";
            this.btn_DeleteEvaluation.Size = new System.Drawing.Size(84, 30);
            this.btn_DeleteEvaluation.TabIndex = 22;
            this.btn_DeleteEvaluation.Text = "Delete";
            this.btn_DeleteEvaluation.UseVisualStyleBackColor = false;
            this.btn_DeleteEvaluation.Visible = false;
            this.btn_DeleteEvaluation.Click += new System.EventHandler(this.btn_DeleteEvaluation_Click);
            // 
            // btn_EditEvaluation
            // 
            this.btn_EditEvaluation.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_EditEvaluation.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditEvaluation.Location = new System.Drawing.Point(405, 432);
            this.btn_EditEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditEvaluation.Name = "btn_EditEvaluation";
            this.btn_EditEvaluation.Size = new System.Drawing.Size(84, 30);
            this.btn_EditEvaluation.TabIndex = 21;
            this.btn_EditEvaluation.Text = "Edit";
            this.btn_EditEvaluation.UseVisualStyleBackColor = false;
            this.btn_EditEvaluation.Visible = false;
            this.btn_EditEvaluation.Click += new System.EventHandler(this.btn_EditEval_Click);
            // 
            // btn_AddEvaluation
            // 
            this.btn_AddEvaluation.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEvaluation.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvaluation.Location = new System.Drawing.Point(405, 278);
            this.btn_AddEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddEvaluation.Name = "btn_AddEvaluation";
            this.btn_AddEvaluation.Size = new System.Drawing.Size(164, 42);
            this.btn_AddEvaluation.TabIndex = 20;
            this.btn_AddEvaluation.Text = "Add an evaluation";
            this.btn_AddEvaluation.UseVisualStyleBackColor = false;
            this.btn_AddEvaluation.Click += new System.EventHandler(this.btn_AddEvaluation_Click);
            // 
            // lsbx_Courses
            // 
            this.lsbx_Courses.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbx_Courses.FormattingEnabled = true;
            this.lsbx_Courses.ItemHeight = 17;
            this.lsbx_Courses.Location = new System.Drawing.Point(212, 235);
            this.lsbx_Courses.Margin = new System.Windows.Forms.Padding(2);
            this.lsbx_Courses.Name = "lsbx_Courses";
            this.lsbx_Courses.Size = new System.Drawing.Size(165, 89);
            this.lsbx_Courses.TabIndex = 19;
            this.lsbx_Courses.SelectedIndexChanged += new System.EventHandler(this.lsbx_Courses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "                      Keep track of evaluations and grades.\r\nFirst select one cou" +
    "rse and then the action you need: Edit, Delete.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(215, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select a course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(160, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Evaluation Manager";
            // 
            // btn_GoMain
            // 
            this.btn_GoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoMain.BackgroundImage")));
            this.btn_GoMain.Location = new System.Drawing.Point(29, 497);
            this.btn_GoMain.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoMain.Name = "btn_GoMain";
            this.btn_GoMain.Size = new System.Drawing.Size(56, 51);
            this.btn_GoMain.TabIndex = 30;
            this.btn_GoMain.UseVisualStyleBackColor = true;
            this.btn_GoMain.Click += new System.EventHandler(this.Btn_GoMain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(215, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Evaluation List";
            // 
            // lsbx_Evaluations
            // 
            this.lsbx_Evaluations.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbx_Evaluations.FormattingEnabled = true;
            this.lsbx_Evaluations.ItemHeight = 15;
            this.lsbx_Evaluations.Location = new System.Drawing.Point(198, 416);
            this.lsbx_Evaluations.Margin = new System.Windows.Forms.Padding(2);
            this.lsbx_Evaluations.Name = "lsbx_Evaluations";
            this.lsbx_Evaluations.Size = new System.Drawing.Size(193, 94);
            this.lsbx_Evaluations.TabIndex = 32;
            this.lsbx_Evaluations.SelectedIndexChanged += new System.EventHandler(this.lsbx_Evaluations_SelectedIndexChanged);
            // 
            // cbbx_EvaluationType
            // 
            this.cbbx_EvaluationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbx_EvaluationType.FormattingEnabled = true;
            this.cbbx_EvaluationType.Items.AddRange(new object[] {
            "Choose an evaluation type",
            "Assignment",
            "Discussion",
            "Project",
            "Quiz",
            "Test"});
            this.cbbx_EvaluationType.Location = new System.Drawing.Point(405, 235);
            this.cbbx_EvaluationType.Name = "cbbx_EvaluationType";
            this.cbbx_EvaluationType.Size = new System.Drawing.Size(164, 21);
            this.cbbx_EvaluationType.TabIndex = 33;
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_instruction.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction.ForeColor = System.Drawing.Color.Red;
            this.lbl_instruction.Location = new System.Drawing.Point(185, 335);
            this.lbl_instruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(0, 15);
            this.lbl_instruction.TabIndex = 34;
            // 
            // EvaluationManager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 592);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.cbbx_EvaluationType);
            this.Controls.Add(this.lsbx_Evaluations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_GoMain);
            this.Controls.Add(this.lbl_EvaluationList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DeleteEvaluation);
            this.Controls.Add(this.btn_EditEvaluation);
            this.Controls.Add(this.btn_AddEvaluation);
            this.Controls.Add(this.lsbx_Courses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluationManager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluation Manager";
            this.Load += new System.EventHandler(this.EvaluationManager_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_EvaluationList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DeleteEvaluation;
        private System.Windows.Forms.Button btn_EditEvaluation;
        private System.Windows.Forms.Button btn_AddEvaluation;
        private System.Windows.Forms.ListBox lsbx_Courses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbx_Evaluations;
        private System.Windows.Forms.ComboBox cbbx_EvaluationType;
        private System.Windows.Forms.Label lbl_instruction;
    }
}