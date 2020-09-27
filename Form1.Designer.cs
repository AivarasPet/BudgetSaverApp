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
            this.goalPriceLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.MonthlySalaryLabel = new System.Windows.Forms.Label();
            this.CurrentSavingsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 450);
            this.panel1.TabIndex = 1;
            // 
            // FlowLayoutTransactions
            // 
            this.FlowLayoutTransactions.AutoScroll = true;
            this.FlowLayoutTransactions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FlowLayoutTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutTransactions.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowLayoutTransactions.Name = "FlowLayoutTransactions";
            this.FlowLayoutTransactions.Size = new System.Drawing.Size(461, 450);
            this.FlowLayoutTransactions.TabIndex = 0;
            this.FlowLayoutTransactions.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutTransactions_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.goalPriceLabel);
            this.panel2.Controls.Add(this.goalLabel);
            this.panel2.Controls.Add(this.MonthlySalaryLabel);
            this.panel2.Controls.Add(this.CurrentSavingsLabel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(461, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 450);
            this.panel2.TabIndex = 2;
            // 
            // goalPriceLabel
            // 
            this.goalPriceLabel.AutoSize = true;
            this.goalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goalPriceLabel.Location = new System.Drawing.Point(7, 347);
            this.goalPriceLabel.Name = "goalPriceLabel";
            this.goalPriceLabel.Size = new System.Drawing.Size(89, 17);
            this.goalPriceLabel.TabIndex = 4;
            this.goalPriceLabel.Text = "Goal price: 0";
            // 
            // goalLabel
            // 
            this.goalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goalLabel.AutoSize = true;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goalLabel.Location = new System.Drawing.Point(7, 330);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(42, 17);
            this.goalLabel.TabIndex = 3;
            this.goalLabel.Text = "Goal:";
            // 
            // MonthlySalaryLabel
            // 
            this.MonthlySalaryLabel.AutoSize = true;
            this.MonthlySalaryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthlySalaryLabel.Location = new System.Drawing.Point(211, 364);
            this.MonthlySalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthlySalaryLabel.Name = "MonthlySalaryLabel";
            this.MonthlySalaryLabel.Size = new System.Drawing.Size(115, 17);
            this.MonthlySalaryLabel.TabIndex = 2;
            this.MonthlySalaryLabel.Text = "Monthly salary: 0";
            // 
            // CurrentSavingsLabel
            // 
            this.CurrentSavingsLabel.AutoSize = true;
            this.CurrentSavingsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentSavingsLabel.Location = new System.Drawing.Point(7, 364);
            this.CurrentSavingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentSavingsLabel.Name = "CurrentSavingsLabel";
            this.CurrentSavingsLabel.Size = new System.Drawing.Size(123, 17);
            this.CurrentSavingsLabel.TabIndex = 1;
            this.CurrentSavingsLabel.Text = "Current savings: 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 66);
            this.button2.TabIndex = 0;
            this.button2.Text = "Enter info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label goalPriceLabel;
        private System.Windows.Forms.Label goalLabel;
    }
}

