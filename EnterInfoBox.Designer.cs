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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGoalItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGoalItemPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxSavingsEnter
            // 
            this.TextBoxSavingsEnter.Location = new System.Drawing.Point(45, 31);
            this.TextBoxSavingsEnter.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSavingsEnter.Name = "TextBoxSavingsEnter";
            this.TextBoxSavingsEnter.Size = new System.Drawing.Size(315, 22);
            this.TextBoxSavingsEnter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current savings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly salary";
            // 
            // TextBoxMonthlySalary
            // 
            this.TextBoxMonthlySalary.Location = new System.Drawing.Point(45, 107);
            this.TextBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMonthlySalary.Name = "TextBoxMonthlySalary";
            this.TextBoxMonthlySalary.Size = new System.Drawing.Size(315, 22);
            this.TextBoxMonthlySalary.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Goal item";
            // 
            // textBoxGoalItemName
            // 
            this.textBoxGoalItemName.Location = new System.Drawing.Point(46, 185);
            this.textBoxGoalItemName.Name = "textBoxGoalItemName";
            this.textBoxGoalItemName.Size = new System.Drawing.Size(314, 22);
            this.textBoxGoalItemName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Goal items price";
            // 
            // textBoxGoalItemPrice
            // 
            this.textBoxGoalItemPrice.Location = new System.Drawing.Point(45, 255);
            this.textBoxGoalItemPrice.Name = "textBoxGoalItemPrice";
            this.textBoxGoalItemPrice.Size = new System.Drawing.Size(315, 22);
            this.textBoxGoalItemPrice.TabIndex = 9;
            // 
            // InfoBoxConfirm
            // 
            this.InfoBoxConfirm.Location = new System.Drawing.Point(46, 299);
            this.InfoBoxConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBoxConfirm.Name = "InfoBoxConfirm";
            this.InfoBoxConfirm.Size = new System.Drawing.Size(100, 28);
            this.InfoBoxConfirm.TabIndex = 4;
            this.InfoBoxConfirm.Text = "Confirm";
            this.InfoBoxConfirm.UseVisualStyleBackColor = true;
            this.InfoBoxConfirm.Click += new System.EventHandler(this.InfoBoxConfirm_Click);
            // 
            // InfoBoxCancel
            // 
            this.InfoBoxCancel.Location = new System.Drawing.Point(259, 299);
            this.InfoBoxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBoxCancel.Name = "InfoBoxCancel";
            this.InfoBoxCancel.Size = new System.Drawing.Size(100, 28);
            this.InfoBoxCancel.TabIndex = 5;
            this.InfoBoxCancel.Text = "Cancel";
            this.InfoBoxCancel.UseVisualStyleBackColor = true;
            this.InfoBoxCancel.Click += new System.EventHandler(this.InfoBoxCancel_Click);
            // 
            // EnterInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 353);
            this.Controls.Add(this.textBoxGoalItemPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGoalItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoBoxCancel);
            this.Controls.Add(this.InfoBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMonthlySalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSavingsEnter);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGoalItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGoalItemPrice;
    }
}