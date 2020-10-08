namespace BudgetSaverApp
{
    partial class MainUI
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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonAddPortfolioValues = new System.Windows.Forms.Button();
            this.buttonAddTransactions = new System.Windows.Forms.Button();
            this.flowLayoutPanelTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxTransactionSearchBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlPortfolio = new System.Windows.Forms.TabControl();
            this.tabPageSavings = new System.Windows.Forms.TabPage();
            this.tabPagePortfolio = new System.Windows.Forms.TabPage();
            this.labelGoalPrice = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelMonthlySalary = new System.Windows.Forms.Label();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlPortfolio.SuspendLayout();
            this.tabPagePortfolio.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMainMenu.Controls.Add(this.buttonAddPortfolioValues);
            this.panelMainMenu.Controls.Add(this.buttonAddTransactions);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(936, 35);
            this.panelMainMenu.TabIndex = 0;
            // 
            // buttonAddPortfolioValues
            // 
            this.buttonAddPortfolioValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddPortfolioValues.FlatAppearance.BorderSize = 0;
            this.buttonAddPortfolioValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPortfolioValues.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddPortfolioValues.Location = new System.Drawing.Point(126, 4);
            this.buttonAddPortfolioValues.Name = "buttonAddPortfolioValues";
            this.buttonAddPortfolioValues.Size = new System.Drawing.Size(142, 25);
            this.buttonAddPortfolioValues.TabIndex = 3;
            this.buttonAddPortfolioValues.Text = "Add starting values";
            this.buttonAddPortfolioValues.UseVisualStyleBackColor = false;
            this.buttonAddPortfolioValues.Click += new System.EventHandler(this.buttonAddPortfolioValues_Click);
            // 
            // buttonAddTransactions
            // 
            this.buttonAddTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddTransactions.FlatAppearance.BorderSize = 0;
            this.buttonAddTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransactions.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddTransactions.Location = new System.Drawing.Point(0, 3);
            this.buttonAddTransactions.Name = "buttonAddTransactions";
            this.buttonAddTransactions.Size = new System.Drawing.Size(120, 25);
            this.buttonAddTransactions.TabIndex = 1;
            this.buttonAddTransactions.Text = "Add transaction";
            this.buttonAddTransactions.UseVisualStyleBackColor = false;
            this.buttonAddTransactions.Click += new System.EventHandler(this.buttonAddTransactions_Click);
            // 
            // flowLayoutPanelTransactions
            // 
            this.flowLayoutPanelTransactions.AutoScroll = true;
            this.flowLayoutPanelTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTransactions.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanelTransactions.Name = "flowLayoutPanelTransactions";
            this.flowLayoutPanelTransactions.Size = new System.Drawing.Size(466, 442);
            this.flowLayoutPanelTransactions.TabIndex = 4;
            // 
            // textBoxTransactionSearchBar
            // 
            this.textBoxTransactionSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTransactionSearchBar.Location = new System.Drawing.Point(0, 0);
            this.textBoxTransactionSearchBar.Name = "textBoxTransactionSearchBar";
            this.textBoxTransactionSearchBar.Size = new System.Drawing.Size(466, 22);
            this.textBoxTransactionSearchBar.TabIndex = 0;
            this.textBoxTransactionSearchBar.TextChanged += new System.EventHandler(this.textBoxTransactionSearchBar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlPortfolio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(470, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 464);
            this.panel1.TabIndex = 5;
            // 
            // tabControlPortfolio
            // 
            this.tabControlPortfolio.Controls.Add(this.tabPageSavings);
            this.tabControlPortfolio.Controls.Add(this.tabPagePortfolio);
            this.tabControlPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPortfolio.Location = new System.Drawing.Point(0, 0);
            this.tabControlPortfolio.Name = "tabControlPortfolio";
            this.tabControlPortfolio.SelectedIndex = 0;
            this.tabControlPortfolio.Size = new System.Drawing.Size(466, 464);
            this.tabControlPortfolio.TabIndex = 0;
            // 
            // tabPageSavings
            // 
            this.tabPageSavings.AutoScroll = true;
            this.tabPageSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPageSavings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSavings.Name = "tabPageSavings";
            this.tabPageSavings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSavings.Size = new System.Drawing.Size(458, 435);
            this.tabPageSavings.TabIndex = 0;
            this.tabPageSavings.Text = "Savings";
            // 
            // tabPagePortfolio
            // 
            this.tabPagePortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPagePortfolio.Controls.Add(this.labelGoalPrice);
            this.tabPagePortfolio.Controls.Add(this.labelGoalName);
            this.tabPagePortfolio.Controls.Add(this.labelMonthlySalary);
            this.tabPagePortfolio.Controls.Add(this.labelCurrentSavings);
            this.tabPagePortfolio.Location = new System.Drawing.Point(4, 25);
            this.tabPagePortfolio.Name = "tabPagePortfolio";
            this.tabPagePortfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePortfolio.Size = new System.Drawing.Size(458, 435);
            this.tabPagePortfolio.TabIndex = 1;
            this.tabPagePortfolio.Text = "Portfolio";
            // 
            // labelGoalPrice
            // 
            this.labelGoalPrice.AutoSize = true;
            this.labelGoalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGoalPrice.Location = new System.Drawing.Point(25, 94);
            this.labelGoalPrice.Name = "labelGoalPrice";
            this.labelGoalPrice.Size = new System.Drawing.Size(122, 25);
            this.labelGoalPrice.TabIndex = 16;
            this.labelGoalPrice.Text = "Goal price: 0";
            // 
            // labelGoalName
            // 
            this.labelGoalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGoalName.Location = new System.Drawing.Point(25, 38);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(59, 25);
            this.labelGoalName.TabIndex = 15;
            this.labelGoalName.Text = "Goal:";
            // 
            // labelMonthlySalary
            // 
            this.labelMonthlySalary.AutoSize = true;
            this.labelMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlySalary.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMonthlySalary.Location = new System.Drawing.Point(25, 221);
            this.labelMonthlySalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonthlySalary.Name = "labelMonthlySalary";
            this.labelMonthlySalary.Size = new System.Drawing.Size(160, 25);
            this.labelMonthlySalary.TabIndex = 14;
            this.labelMonthlySalary.Text = "Monthly salary: 0";
            // 
            // labelCurrentSavings
            // 
            this.labelCurrentSavings.AutoSize = true;
            this.labelCurrentSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSavings.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentSavings.Location = new System.Drawing.Point(25, 156);
            this.labelCurrentSavings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentSavings.Name = "labelCurrentSavings";
            this.labelCurrentSavings.Size = new System.Drawing.Size(171, 25);
            this.labelCurrentSavings.TabIndex = 13;
            this.labelCurrentSavings.Text = "Current savings: 0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelTransactions);
            this.panel2.Controls.Add(this.textBoxTransactionSearchBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 464);
            this.panel2.TabIndex = 6;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(936, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMainMenu);
            this.MinimumSize = new System.Drawing.Size(954, 546);
            this.Name = "MainUI";
            this.Text = "Budget saver app";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlPortfolio.ResumeLayout(false);
            this.tabPagePortfolio.ResumeLayout(false);
            this.tabPagePortfolio.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonAddPortfolioValues;
        private System.Windows.Forms.Button buttonAddTransactions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTransactions;
        private System.Windows.Forms.TextBox textBoxTransactionSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlPortfolio;
        private System.Windows.Forms.TabPage tabPageSavings;
        private System.Windows.Forms.TabPage tabPagePortfolio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGoalPrice;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelMonthlySalary;
        private System.Windows.Forms.Label labelCurrentSavings;
    }
}