namespace GUI_ManagementSystem
{
    partial class ErrorBox_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBox_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OkError = new System.Windows.Forms.Button();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(220, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "ERROR:";
            // 
            // btn_OkError
            // 
            this.btn_OkError.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkError.CausesValidation = false;
            this.btn_OkError.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkError.Location = new System.Drawing.Point(224, 214);
            this.btn_OkError.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OkError.Name = "btn_OkError";
            this.btn_OkError.Size = new System.Drawing.Size(86, 30);
            this.btn_OkError.TabIndex = 82;
            this.btn_OkError.Text = "Ok";
            this.btn_OkError.UseVisualStyleBackColor = false;
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ErrorMessage.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(220, 151);
            this.lbl_ErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(141, 32);
            this.lbl_ErrorMessage.TabIndex = 84;
            this.lbl_ErrorMessage.Text = "*Empy Label - \r\nError Message.ex*";
            this.lbl_ErrorMessage.Visible = false;
            // 
            // ErrorBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 288);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OkError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ErrorBox_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorBox_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OkError;
        private System.Windows.Forms.Label lbl_ErrorMessage;
    }
}