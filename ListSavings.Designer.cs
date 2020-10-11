namespace BudgetSaverApp
{
    partial class ListSavings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelValueInput = new System.Windows.Forms.Label();
            this.LabelTitleInput = new System.Windows.Forms.Label();
            this.LabelAmountInput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelValueInput
            // 
            this.LabelValueInput.AutoSize = true;
            this.LabelValueInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelValueInput.Location = new System.Drawing.Point(365, 12);
            this.LabelValueInput.Name = "LabelValueInput";
            this.LabelValueInput.Size = new System.Drawing.Size(22, 17);
            this.LabelValueInput.TabIndex = 11;
            this.LabelValueInput.Text = "- -";
            // 
            // LabelTitleInput
            // 
            this.LabelTitleInput.AutoSize = true;
            this.LabelTitleInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleInput.Location = new System.Drawing.Point(95, 12);
            this.LabelTitleInput.Name = "LabelTitleInput";
            this.LabelTitleInput.Size = new System.Drawing.Size(22, 17);
            this.LabelTitleInput.TabIndex = 10;
            this.LabelTitleInput.Text = "- -";
            // 
            // LabelAmountInput
            // 
            this.LabelAmountInput.AutoSize = true;
            this.LabelAmountInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountInput.Location = new System.Drawing.Point(302, 12);
            this.LabelAmountInput.Name = "LabelAmountInput";
            this.LabelAmountInput.Size = new System.Drawing.Size(22, 17);
            this.LabelAmountInput.TabIndex = 15;
            this.LabelAmountInput.Text = "- -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__23_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ListSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelAmountInput);
            this.Controls.Add(this.LabelValueInput);
            this.Controls.Add(this.LabelTitleInput);
            this.Name = "ListSavings";
            this.Size = new System.Drawing.Size(453, 46);
            this.Load += new System.EventHandler(this.ListSavings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelValueInput;
        private System.Windows.Forms.Label LabelTitleInput;
        private System.Windows.Forms.Label LabelAmountInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
