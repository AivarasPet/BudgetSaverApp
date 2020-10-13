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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelValueInput
            // 
            this.LabelValueInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelValueInput.Location = new System.Drawing.Point(317, 14);
            this.LabelValueInput.Name = "LabelValueInput";
            this.LabelValueInput.Size = new System.Drawing.Size(121, 17);
            this.LabelValueInput.TabIndex = 11;
            this.LabelValueInput.Text = "- -";
            this.LabelValueInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTitleInput
            // 
            this.LabelTitleInput.AutoSize = true;
            this.LabelTitleInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleInput.Location = new System.Drawing.Point(91, 14);
            this.LabelTitleInput.Name = "LabelTitleInput";
            this.LabelTitleInput.Size = new System.Drawing.Size(22, 17);
            this.LabelTitleInput.TabIndex = 10;
            this.LabelTitleInput.Text = "- -";
            // 
            // LabelAmountInput
            // 
            this.LabelAmountInput.AutoSize = true;
            this.LabelAmountInput.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountInput.Location = new System.Drawing.Point(268, 14);
            this.LabelAmountInput.Name = "LabelAmountInput";
            this.LabelAmountInput.Size = new System.Drawing.Size(22, 17);
            this.LabelAmountInput.TabIndex = 15;
            this.LabelAmountInput.Text = "- -";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxLogo.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__23_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(23, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ListSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.LabelAmountInput);
            this.Controls.Add(this.LabelValueInput);
            this.Controls.Add(this.LabelTitleInput);
            this.Name = "ListSavings";
            this.Size = new System.Drawing.Size(453, 46);
            this.Load += new System.EventHandler(this.ListSavings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelValueInput;
        private System.Windows.Forms.Label LabelTitleInput;
        private System.Windows.Forms.Label LabelAmountInput;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
