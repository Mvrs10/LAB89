namespace GUI_ManagementSystem
{
    partial class ItemDeleted_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDeleted_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OkItemDeleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item successfully deleted.";
            // 
            // btn_OkItemDeleted
            // 
            this.btn_OkItemDeleted.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OkItemDeleted.CausesValidation = false;
            this.btn_OkItemDeleted.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkItemDeleted.Location = new System.Drawing.Point(179, 143);
            this.btn_OkItemDeleted.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OkItemDeleted.Name = "btn_OkItemDeleted";
            this.btn_OkItemDeleted.Size = new System.Drawing.Size(86, 30);
            this.btn_OkItemDeleted.TabIndex = 17;
            this.btn_OkItemDeleted.Text = "Ok";
            this.btn_OkItemDeleted.UseVisualStyleBackColor = false;
            this.btn_OkItemDeleted.Click += new System.EventHandler(this.Btn_OkItemDeleted_Click);
            // 
            // ItemDeleted_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 232);
            this.Controls.Add(this.btn_OkItemDeleted);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemDeleted_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDeleted_Form";
            this.Load += new System.EventHandler(this.ItemDeleted_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OkItemDeleted;
    }
}