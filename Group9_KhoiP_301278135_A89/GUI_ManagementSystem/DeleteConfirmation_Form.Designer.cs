namespace GUI_ManagementSystem
{
    partial class DeleteConfirmation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteConfirmation_Form));
            this.btn_CancelDeleteItem = new System.Windows.Forms.Button();
            this.btn_OkDeleteItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CancelDeleteItem
            // 
            this.btn_CancelDeleteItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_CancelDeleteItem.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelDeleteItem.Location = new System.Drawing.Point(345, 253);
            this.btn_CancelDeleteItem.Name = "btn_CancelDeleteItem";
            this.btn_CancelDeleteItem.Size = new System.Drawing.Size(114, 37);
            this.btn_CancelDeleteItem.TabIndex = 14;
            this.btn_CancelDeleteItem.Text = "Cancel";
            this.btn_CancelDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btn_OkDeleteItem
            // 
            this.btn_OkDeleteItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkDeleteItem.CausesValidation = false;
            this.btn_OkDeleteItem.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkDeleteItem.Location = new System.Drawing.Point(205, 253);
            this.btn_OkDeleteItem.Name = "btn_OkDeleteItem";
            this.btn_OkDeleteItem.Size = new System.Drawing.Size(114, 37);
            this.btn_OkDeleteItem.TabIndex = 13;
            this.btn_OkDeleteItem.Text = "Ok";
            this.btn_OkDeleteItem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Are you sure you want to delete this item?";
            // 
            // DeleteConfirmation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 315);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CancelDeleteItem);
            this.Controls.Add(this.btn_OkDeleteItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteConfirmation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelDeleteItem;
        private System.Windows.Forms.Button btn_OkDeleteItem;
        private System.Windows.Forms.Label label3;
    }
}