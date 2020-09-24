namespace BudgetSaverApp
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowLayoutTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentSavingsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MonthlySalaryLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Expense";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.FlowLayoutTransactions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 366);
            this.panel1.TabIndex = 1;
            // 
            // FlowLayoutTransactions
            // 
            this.FlowLayoutTransactions.AutoScroll = true;
            this.FlowLayoutTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutTransactions.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayoutTransactions.Name = "FlowLayoutTransactions";
            this.FlowLayoutTransactions.Size = new System.Drawing.Size(346, 366);
            this.FlowLayoutTransactions.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MonthlySalaryLabel);
            this.panel2.Controls.Add(this.CurrentSavingsLabel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(346, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 366);
            this.panel2.TabIndex = 2;
            // 
            // CurrentSavingsLabel
            // 
            this.CurrentSavingsLabel.AutoSize = true;
            this.CurrentSavingsLabel.Location = new System.Drawing.Point(5, 296);
            this.CurrentSavingsLabel.Name = "CurrentSavingsLabel";
            this.CurrentSavingsLabel.Size = new System.Drawing.Size(92, 13);
            this.CurrentSavingsLabel.TabIndex = 1;
            this.CurrentSavingsLabel.Text = "Current savings: 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Enter info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MonthlySalaryLabel
            // 
            this.MonthlySalaryLabel.AutoSize = true;
            this.MonthlySalaryLabel.Location = new System.Drawing.Point(159, 296);
            this.MonthlySalaryLabel.Name = "MonthlySalaryLabel";
            this.MonthlySalaryLabel.Size = new System.Drawing.Size(86, 13);
            this.MonthlySalaryLabel.TabIndex = 2;
            this.MonthlySalaryLabel.Text = "Monthly salary: 0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Budget Saver App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutTransactions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CurrentSavingsLabel;
        private System.Windows.Forms.Label MonthlySalaryLabel;
    }
}

