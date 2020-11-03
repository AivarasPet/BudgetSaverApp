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
            this.TextBoxGoalItemName = new System.Windows.Forms.TextBox();
            this.LabelSavings = new System.Windows.Forms.Label();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.TextBoxMonthlySalary = new System.Windows.Forms.TextBox();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelGoalName = new System.Windows.Forms.Label();
            this.TextBoxSavings = new System.Windows.Forms.TextBox();
            this.LabelGoalPrice = new System.Windows.Forms.Label();
            this.TextBoxGoalItemPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxGoalItemName
            // 
            this.TextBoxGoalItemName.BackColor = System.Drawing.Color.White;
            this.TextBoxGoalItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxGoalItemName.Location = new System.Drawing.Point(108, 63);
            this.TextBoxGoalItemName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxGoalItemName.Name = "TextBoxGoalItemName";
            this.TextBoxGoalItemName.Size = new System.Drawing.Size(315, 22);
            this.TextBoxGoalItemName.TabIndex = 0;
            // 
            // LabelSavings
            // 
            this.LabelSavings.AutoSize = true;
            this.LabelSavings.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSavings.Location = new System.Drawing.Point(80, 178);
            this.LabelSavings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSavings.Name = "LabelSavings";
            this.LabelSavings.Size = new System.Drawing.Size(111, 17);
            this.LabelSavings.TabIndex = 1;
            this.LabelSavings.Text = "Current savings:";
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSalary.Location = new System.Drawing.Point(80, 255);
            this.LabelSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(99, 17);
            this.LabelSalary.TabIndex = 3;
            this.LabelSalary.Text = "Monthly salary";
            // 
            // TextBoxMonthlySalary
            // 
            this.TextBoxMonthlySalary.BackColor = System.Drawing.Color.White;
            this.TextBoxMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxMonthlySalary.Location = new System.Drawing.Point(108, 288);
            this.TextBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMonthlySalary.Name = "TextBoxMonthlySalary";
            this.TextBoxMonthlySalary.Size = new System.Drawing.Size(315, 22);
            this.TextBoxMonthlySalary.TabIndex = 2;
            this.TextBoxMonthlySalary.Click += new System.EventHandler(this.TextBoxMonthlySalary_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonConfirm.FlatAppearance.BorderSize = 0;
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(35, 338);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(109, 34);
            this.ButtonConfirm.TabIndex = 4;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.InfoBoxConfirm_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(381, 338);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(115, 34);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.InfoBoxCancel_Click);
            // 
            // LabelGoalName
            // 
            this.LabelGoalName.AutoSize = true;
            this.LabelGoalName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelGoalName.Location = new System.Drawing.Point(84, 31);
            this.LabelGoalName.Name = "LabelGoalName";
            this.LabelGoalName.Size = new System.Drawing.Size(68, 17);
            this.LabelGoalName.TabIndex = 6;
            this.LabelGoalName.Text = "Goal item";
            // 
            // TextBoxSavings
            // 
            this.TextBoxSavings.BackColor = System.Drawing.Color.White;
            this.TextBoxSavings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSavings.Location = new System.Drawing.Point(108, 213);
            this.TextBoxSavings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSavings.Name = "TextBoxSavings";
            this.TextBoxSavings.Size = new System.Drawing.Size(314, 22);
            this.TextBoxSavings.TabIndex = 7;
            this.TextBoxSavings.Click += new System.EventHandler(this.TextBoxSavings_Click);
            // 
            // LabelGoalPrice
            // 
            this.LabelGoalPrice.AutoSize = true;
            this.LabelGoalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelGoalPrice.Location = new System.Drawing.Point(84, 98);
            this.LabelGoalPrice.Name = "LabelGoalPrice";
            this.LabelGoalPrice.Size = new System.Drawing.Size(110, 17);
            this.LabelGoalPrice.TabIndex = 8;
            this.LabelGoalPrice.Text = "Goal items price";
            // 
            // TextBoxGoalItemPrice
            // 
            this.TextBoxGoalItemPrice.BackColor = System.Drawing.Color.White;
            this.TextBoxGoalItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxGoalItemPrice.Location = new System.Drawing.Point(108, 129);
            this.TextBoxGoalItemPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxGoalItemPrice.Name = "TextBoxGoalItemPrice";
            this.TextBoxGoalItemPrice.Size = new System.Drawing.Size(315, 22);
            this.TextBoxGoalItemPrice.TabIndex = 9;
            this.TextBoxGoalItemPrice.Click += new System.EventHandler(this.TextBoxGoalItemPrice_Click);
            // 
            // EnterInfoBox
            // 
            this.AcceptButton = this.ButtonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.TextBoxGoalItemPrice);
            this.Controls.Add(this.LabelGoalPrice);
            this.Controls.Add(this.TextBoxSavings);
            this.Controls.Add(this.LabelGoalName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.TextBoxMonthlySalary);
            this.Controls.Add(this.LabelSavings);
            this.Controls.Add(this.TextBoxGoalItemName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterInfoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add portfolio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxGoalItemName;
        private System.Windows.Forms.Label LabelSavings;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.TextBox TextBoxMonthlySalary;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelGoalName;
        private System.Windows.Forms.TextBox TextBoxSavings;
        private System.Windows.Forms.Label LabelGoalPrice;
        private System.Windows.Forms.TextBox TextBoxGoalItemPrice;
    }
}