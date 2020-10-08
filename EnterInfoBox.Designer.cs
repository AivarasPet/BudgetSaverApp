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
            this.TextBoxSavingsEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxSavingsEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.TextBoxSavingsEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSavingsEnter.Location = new System.Drawing.Point(125, 199);
            this.TextBoxSavingsEnter.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSavingsEnter.Name = "TextBoxSavingsEnter";
            this.TextBoxSavingsEnter.Size = new System.Drawing.Size(315, 22);
            this.TextBoxSavingsEnter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(96, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current savings:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(96, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly salary";
            // 
            // TextBoxMonthlySalary
            // 
            this.TextBoxMonthlySalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxMonthlySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.TextBoxMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxMonthlySalary.Location = new System.Drawing.Point(125, 275);
            this.TextBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMonthlySalary.Name = "TextBoxMonthlySalary";
            this.TextBoxMonthlySalary.Size = new System.Drawing.Size(315, 22);
            this.TextBoxMonthlySalary.TabIndex = 2;
            // 
            // InfoBoxConfirm
            // 
            this.InfoBoxConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InfoBoxConfirm.FlatAppearance.BorderSize = 0;
            this.InfoBoxConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBoxConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoBoxConfirm.Location = new System.Drawing.Point(34, 359);
            this.InfoBoxConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBoxConfirm.Name = "InfoBoxConfirm";
            this.InfoBoxConfirm.Size = new System.Drawing.Size(109, 34);
            this.InfoBoxConfirm.TabIndex = 4;
            this.InfoBoxConfirm.Text = "Confirm";
            this.InfoBoxConfirm.UseVisualStyleBackColor = false;
            this.InfoBoxConfirm.Click += new System.EventHandler(this.InfoBoxConfirm_Click);
            // 
            // InfoBoxCancel
            // 
            this.InfoBoxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBoxCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InfoBoxCancel.FlatAppearance.BorderSize = 0;
            this.InfoBoxCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBoxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBoxCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoBoxCancel.Location = new System.Drawing.Point(413, 359);
            this.InfoBoxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBoxCancel.Name = "InfoBoxCancel";
            this.InfoBoxCancel.Size = new System.Drawing.Size(114, 34);
            this.InfoBoxCancel.TabIndex = 5;
            this.InfoBoxCancel.Text = "Cancel";
            this.InfoBoxCancel.UseVisualStyleBackColor = false;
            this.InfoBoxCancel.Click += new System.EventHandler(this.InfoBoxCancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(100, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Goal item";
            // 
            // textBoxGoalItemName
            // 
            this.textBoxGoalItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGoalItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.textBoxGoalItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGoalItemName.Location = new System.Drawing.Point(125, 59);
            this.textBoxGoalItemName.Name = "textBoxGoalItemName";
            this.textBoxGoalItemName.Size = new System.Drawing.Size(314, 22);
            this.textBoxGoalItemName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Goal items price";
            // 
            // textBoxGoalItemPrice
            // 
            this.textBoxGoalItemPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGoalItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.textBoxGoalItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGoalItemPrice.Location = new System.Drawing.Point(124, 129);
            this.textBoxGoalItemPrice.Name = "textBoxGoalItemPrice";
            this.textBoxGoalItemPrice.Size = new System.Drawing.Size(315, 22);
            this.textBoxGoalItemPrice.TabIndex = 9;
            // 
            // EnterInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(593, 416);
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