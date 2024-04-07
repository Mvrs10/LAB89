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
            this.btn_ExportEval = new System.Windows.Forms.Button();
            this.btn_ImportEval = new System.Windows.Forms.Button();
            this.lbl_EvalDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DeleteEval = new System.Windows.Forms.Button();
            this.btn_EditEval = new System.Windows.Forms.Button();
            this.btn_AddEval = new System.Windows.Forms.Button();
            this.lst_Evaluations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExportEval
            // 
            this.btn_ExportEval.BackColor = System.Drawing.Color.Wheat;
            this.btn_ExportEval.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportEval.Location = new System.Drawing.Point(184, 619);
            this.btn_ExportEval.Name = "btn_ExportEval";
            this.btn_ExportEval.Size = new System.Drawing.Size(187, 46);
            this.btn_ExportEval.TabIndex = 26;
            this.btn_ExportEval.Text = "Export Evaluation";
            this.btn_ExportEval.UseVisualStyleBackColor = false;
            // 
            // btn_ImportEval
            // 
            this.btn_ImportEval.BackColor = System.Drawing.Color.Wheat;
            this.btn_ImportEval.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportEval.Location = new System.Drawing.Point(425, 619);
            this.btn_ImportEval.Name = "btn_ImportEval";
            this.btn_ImportEval.Size = new System.Drawing.Size(187, 46);
            this.btn_ImportEval.TabIndex = 25;
            this.btn_ImportEval.Text = "Import Evaluation";
            this.btn_ImportEval.UseVisualStyleBackColor = false;
            // 
            // lbl_EvalDetails
            // 
            this.lbl_EvalDetails.AutoSize = true;
            this.lbl_EvalDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EvalDetails.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EvalDetails.Location = new System.Drawing.Point(36, 289);
            this.lbl_EvalDetails.Name = "lbl_EvalDetails";
            this.lbl_EvalDetails.Size = new System.Drawing.Size(124, 54);
            this.lbl_EvalDetails.TabIndex = 24;
            this.lbl_EvalDetails.Text = "**THIS IS \r\nAN INVISIBLE \r\nLABEL**";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(34, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Details";
            // 
            // btn_DeleteEval
            // 
            this.btn_DeleteEval.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_DeleteEval.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEval.Location = new System.Drawing.Point(577, 465);
            this.btn_DeleteEval.Name = "btn_DeleteEval";
            this.btn_DeleteEval.Size = new System.Drawing.Size(114, 37);
            this.btn_DeleteEval.TabIndex = 22;
            this.btn_DeleteEval.Text = "Delete";
            this.btn_DeleteEval.UseVisualStyleBackColor = false;
            // 
            // btn_EditEval
            // 
            this.btn_EditEval.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_EditEval.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditEval.Location = new System.Drawing.Point(577, 387);
            this.btn_EditEval.Name = "btn_EditEval";
            this.btn_EditEval.Size = new System.Drawing.Size(114, 37);
            this.btn_EditEval.TabIndex = 21;
            this.btn_EditEval.Text = "Edit";
            this.btn_EditEval.UseVisualStyleBackColor = false;
            this.btn_EditEval.Click += new System.EventHandler(this.btn_EditEval_Click);
            // 
            // btn_AddEval
            // 
            this.btn_AddEval.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_AddEval.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEval.Location = new System.Drawing.Point(577, 312);
            this.btn_AddEval.Name = "btn_AddEval";
            this.btn_AddEval.Size = new System.Drawing.Size(114, 37);
            this.btn_AddEval.TabIndex = 20;
            this.btn_AddEval.Text = "Add";
            this.btn_AddEval.UseVisualStyleBackColor = false;
            // 
            // lst_Evaluations
            // 
            this.lst_Evaluations.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Evaluations.FormattingEnabled = true;
            this.lst_Evaluations.ItemHeight = 18;
            this.lst_Evaluations.Location = new System.Drawing.Point(283, 289);
            this.lst_Evaluations.Name = "lst_Evaluations";
            this.lst_Evaluations.Size = new System.Drawing.Size(219, 310);
            this.lst_Evaluations.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "                      Keep track of evaluations and grades.\r\nFirst select one eva" +
    "luation and then the action you need: Edit, Delete.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(287, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Evaluations List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(213, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Evaluation Manager";
            // 
            // btn_GoMain
            // 
            this.btn_GoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GoMain.BackgroundImage")));
            this.btn_GoMain.Location = new System.Drawing.Point(39, 612);
            this.btn_GoMain.Name = "btn_GoMain";
            this.btn_GoMain.Size = new System.Drawing.Size(74, 63);
            this.btn_GoMain.TabIndex = 30;
            this.btn_GoMain.UseVisualStyleBackColor = true;
            this.btn_GoMain.Click += new System.EventHandler(this.Btn_GoMain_Click);
            // 
            // EvaluationManager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 728);
            this.Controls.Add(this.btn_GoMain);
            this.Controls.Add(this.btn_ExportEval);
            this.Controls.Add(this.btn_ImportEval);
            this.Controls.Add(this.lbl_EvalDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DeleteEval);
            this.Controls.Add(this.btn_EditEval);
            this.Controls.Add(this.btn_AddEval);
            this.Controls.Add(this.lst_Evaluations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EvaluationManager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluation Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ExportEval;
        private System.Windows.Forms.Button btn_ImportEval;
        private System.Windows.Forms.Label lbl_EvalDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DeleteEval;
        private System.Windows.Forms.Button btn_EditEval;
        private System.Windows.Forms.Button btn_AddEval;
        private System.Windows.Forms.ListBox lst_Evaluations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoMain;
    }
}