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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTransactionType = new System.Windows.Forms.ComboBox();
            this.AddTransactionAmount = new System.Windows.Forms.TextBox();
            this.AddTransactionName = new System.Windows.Forms.TextBox();
            this.goalPriceLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.MonthlySalaryLabel = new System.Windows.Forms.Label();
            this.CurrentSavingsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddTransactionButton = new System.Windows.Forms.Button();
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
            this.FlowLayoutTransactions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FlowLayoutTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutTransactions.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayoutTransactions.Name = "FlowLayoutTransactions";
            this.FlowLayoutTransactions.Size = new System.Drawing.Size(346, 366);
            this.FlowLayoutTransactions.TabIndex = 0;
            this.FlowLayoutTransactions.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutTransactions_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.AddTransactionButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AddTransactionType);
            this.panel2.Controls.Add(this.AddTransactionAmount);
            this.panel2.Controls.Add(this.AddTransactionName);
            this.panel2.Controls.Add(this.goalPriceLabel);
            this.panel2.Controls.Add(this.goalLabel);
            this.panel2.Controls.Add(this.MonthlySalaryLabel);
            this.panel2.Controls.Add(this.CurrentSavingsLabel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(346, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 366);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(167, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type:";
            // 
            // AddTransactionType
            // 
            this.AddTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionType.FormattingEnabled = true;
            this.AddTransactionType.Items.AddRange(new object[] {
            "+",
            "-"});
            this.AddTransactionType.Location = new System.Drawing.Point(24, 97);
            this.AddTransactionType.Name = "AddTransactionType";
            this.AddTransactionType.Size = new System.Drawing.Size(32, 21);
            this.AddTransactionType.TabIndex = 7;
            // 
            // AddTransactionAmount
            // 
            this.AddTransactionAmount.Location = new System.Drawing.Point(170, 98);
            this.AddTransactionAmount.Name = "AddTransactionAmount";
            this.AddTransactionAmount.Size = new System.Drawing.Size(62, 20);
            this.AddTransactionAmount.TabIndex = 6;
            // 
            // AddTransactionName
            // 
            this.AddTransactionName.Location = new System.Drawing.Point(62, 98);
            this.AddTransactionName.Name = "AddTransactionName";
            this.AddTransactionName.Size = new System.Drawing.Size(100, 20);
            this.AddTransactionName.TabIndex = 5;
            // 
            // goalPriceLabel
            // 
            this.goalPriceLabel.AutoSize = true;
            this.goalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goalPriceLabel.Location = new System.Drawing.Point(5, 282);
            this.goalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalPriceLabel.Name = "goalPriceLabel";
            this.goalPriceLabel.Size = new System.Drawing.Size(67, 13);
            this.goalPriceLabel.TabIndex = 4;
            this.goalPriceLabel.Text = "Goal price: 0";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goalLabel.Location = new System.Drawing.Point(5, 268);
            this.goalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(32, 13);
            this.goalLabel.TabIndex = 3;
            this.goalLabel.Text = "Goal:";
            // 
            // MonthlySalaryLabel
            // 
            this.MonthlySalaryLabel.AutoSize = true;
            this.MonthlySalaryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthlySalaryLabel.Location = new System.Drawing.Point(158, 296);
            this.MonthlySalaryLabel.Name = "MonthlySalaryLabel";
            this.MonthlySalaryLabel.Size = new System.Drawing.Size(86, 13);
            this.MonthlySalaryLabel.TabIndex = 2;
            this.MonthlySalaryLabel.Text = "Monthly salary: 0";
            // 
            // CurrentSavingsLabel
            // 
            this.CurrentSavingsLabel.AutoSize = true;
            this.CurrentSavingsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentSavingsLabel.Location = new System.Drawing.Point(5, 296);
            this.CurrentSavingsLabel.Name = "CurrentSavingsLabel";
            this.CurrentSavingsLabel.Size = new System.Drawing.Size(92, 13);
            this.CurrentSavingsLabel.TabIndex = 1;
            this.CurrentSavingsLabel.Text = "Current savings: 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Enter info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTransactionButton.Location = new System.Drawing.Point(61, 132);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(131, 38);
            this.AddTransactionButton.TabIndex = 11;
            this.AddTransactionButton.Text = "Add transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
        private System.Windows.Forms.Label goalPriceLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddTransactionType;
        private System.Windows.Forms.TextBox AddTransactionAmount;
        private System.Windows.Forms.TextBox AddTransactionName;
        private System.Windows.Forms.Button AddTransactionButton;
    }
}

