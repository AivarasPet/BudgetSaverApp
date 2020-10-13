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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMonthlySalary = new System.Windows.Forms.TextBox();
            this.InfoBoxConfirm = new System.Windows.Forms.Button();
            this.InfoBoxCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSavingsEnter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGoalItemPrice = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(80, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current savings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly salary";
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
            // 
            // InfoBoxConfirm
            // 
            this.InfoBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InfoBoxConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InfoBoxConfirm.FlatAppearance.BorderSize = 0;
            this.InfoBoxConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBoxConfirm.ForeColor = System.Drawing.Color.White;
            this.InfoBoxConfirm.Location = new System.Drawing.Point(35, 338);
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
            this.InfoBoxCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.InfoBoxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InfoBoxCancel.FlatAppearance.BorderSize = 0;
            this.InfoBoxCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBoxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBoxCancel.ForeColor = System.Drawing.Color.White;
            this.InfoBoxCancel.Location = new System.Drawing.Point(381, 338);
            this.InfoBoxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBoxCancel.Name = "InfoBoxCancel";
            this.InfoBoxCancel.Size = new System.Drawing.Size(115, 34);
            this.InfoBoxCancel.TabIndex = 5;
            this.InfoBoxCancel.Text = "Cancel";
            this.InfoBoxCancel.UseVisualStyleBackColor = false;
            this.InfoBoxCancel.Click += new System.EventHandler(this.InfoBoxCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(84, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Goal item";
            // 
            // TextBoxSavingsEnter
            // 
            this.TextBoxSavingsEnter.BackColor = System.Drawing.Color.White;
            this.TextBoxSavingsEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSavingsEnter.Location = new System.Drawing.Point(108, 213);
            this.TextBoxSavingsEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSavingsEnter.Name = "TextBoxSavingsEnter";
            this.TextBoxSavingsEnter.Size = new System.Drawing.Size(314, 22);
            this.TextBoxSavingsEnter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(84, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Goal items price";
            // 
            // textBoxGoalItemPrice
            // 
            this.textBoxGoalItemPrice.BackColor = System.Drawing.Color.White;
            this.textBoxGoalItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGoalItemPrice.Location = new System.Drawing.Point(108, 129);
            this.textBoxGoalItemPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGoalItemPrice.Name = "textBoxGoalItemPrice";
            this.textBoxGoalItemPrice.Size = new System.Drawing.Size(315, 22);
            this.textBoxGoalItemPrice.TabIndex = 9;
            // 
            // EnterInfoBox
            // 
            this.AcceptButton = this.InfoBoxConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.CancelButton = this.InfoBoxCancel;
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.textBoxGoalItemPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxSavingsEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoBoxCancel);
            this.Controls.Add(this.InfoBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMonthlySalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGoalItemName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterInfoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add starting values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxGoalItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMonthlySalary;
        private System.Windows.Forms.Button InfoBoxConfirm;
        private System.Windows.Forms.Button InfoBoxCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSavingsEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGoalItemPrice;
    }
}