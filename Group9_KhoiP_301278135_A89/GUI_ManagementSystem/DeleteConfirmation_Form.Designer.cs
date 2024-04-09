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
            this.btn_CancelDeleteItem.Location = new System.Drawing.Point(259, 206);
            this.btn_CancelDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancelDeleteItem.Name = "btn_CancelDeleteItem";
            this.btn_CancelDeleteItem.Size = new System.Drawing.Size(86, 30);
            this.btn_CancelDeleteItem.TabIndex = 14;
            this.btn_CancelDeleteItem.Text = "Cancel";
            this.btn_CancelDeleteItem.UseVisualStyleBackColor = false;
            this.btn_CancelDeleteItem.Click += new System.EventHandler(this.btn_CancelDeleteItem_Click);
            // 
            // btn_OkDeleteItem
            // 
            this.btn_OkDeleteItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkDeleteItem.CausesValidation = false;
            this.btn_OkDeleteItem.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkDeleteItem.Location = new System.Drawing.Point(154, 206);
            this.btn_OkDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OkDeleteItem.Name = "btn_OkDeleteItem";
            this.btn_OkDeleteItem.Size = new System.Drawing.Size(86, 30);
            this.btn_OkDeleteItem.TabIndex = 13;
            this.btn_OkDeleteItem.Text = "Ok";
            this.btn_OkDeleteItem.UseVisualStyleBackColor = false;
            this.btn_OkDeleteItem.Click += new System.EventHandler(this.Btn_OkDeleteItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Are you sure you want to delete this item?";
            // 
            // DeleteConfirmation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CancelDeleteItem);
            this.Controls.Add(this.btn_OkDeleteItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteConfirmation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Confirmation";
            this.Load += new System.EventHandler(this.DeleteConfirmation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelDeleteItem;
        private System.Windows.Forms.Button btn_OkDeleteItem;
        private System.Windows.Forms.Label label3;
    }
}