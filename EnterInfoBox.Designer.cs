namespace BudgetSaverApp
{
    partial class EnterInfoBox
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
            this.TextBoxSavingsEnter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMonthlySalary = new System.Windows.Forms.TextBox();
            this.InfoBoxConfirm = new System.Windows.Forms.Button();
            this.InfoBoxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxSavingsEnter
            // 
            this.TextBoxSavingsEnter.Location = new System.Drawing.Point(34, 25);
            this.TextBoxSavingsEnter.Name = "TextBoxSavingsEnter";
            this.TextBoxSavingsEnter.Size = new System.Drawing.Size(237, 20);
            this.TextBoxSavingsEnter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current savings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly salary";
            // 
            // TextBoxMonthlySalary
            // 
            this.TextBoxMonthlySalary.Location = new System.Drawing.Point(34, 87);
            this.TextBoxMonthlySalary.Name = "TextBoxMonthlySalary";
            this.TextBoxMonthlySalary.Size = new System.Drawing.Size(237, 20);
            this.TextBoxMonthlySalary.TabIndex = 2;
            // 
            // InfoBoxConfirm
            // 
            this.InfoBoxConfirm.Location = new System.Drawing.Point(34, 207);
            this.InfoBoxConfirm.Name = "InfoBoxConfirm";
            this.InfoBoxConfirm.Size = new System.Drawing.Size(75, 23);
            this.InfoBoxConfirm.TabIndex = 4;
            this.InfoBoxConfirm.Text = "Confirm";
            this.InfoBoxConfirm.UseVisualStyleBackColor = true;
            this.InfoBoxConfirm.Click += new System.EventHandler(this.InfoBoxConfirm_Click);
            // 
            // InfoBoxCancel
            // 
            this.InfoBoxCancel.Location = new System.Drawing.Point(196, 207);
            this.InfoBoxCancel.Name = "InfoBoxCancel";
            this.InfoBoxCancel.Size = new System.Drawing.Size(75, 23);
            this.InfoBoxCancel.TabIndex = 5;
            this.InfoBoxCancel.Text = "Cancel";
            this.InfoBoxCancel.UseVisualStyleBackColor = true;
            this.InfoBoxCancel.Click += new System.EventHandler(this.InfoBoxCancel_Click);
            // 
            // EnterInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 247);
            this.Controls.Add(this.InfoBoxCancel);
            this.Controls.Add(this.InfoBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMonthlySalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSavingsEnter);
            this.Name = "EnterInfoBox";
            this.Text = "EnterInfoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSavingsEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMonthlySalary;
        private System.Windows.Forms.Button InfoBoxConfirm;
        private System.Windows.Forms.Button InfoBoxCancel;
    }
}