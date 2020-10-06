﻿namespace BudgetSaverApp
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
            this.buttonAddTransactions = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelStartingValues = new System.Windows.Forms.Panel();
            this.buttonAddStartingValues = new System.Windows.Forms.Button();
            this.buttonShowStartingValues = new System.Windows.Forms.Button();
            this.buttonStartingValues = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelStartingValuesScreen = new System.Windows.Forms.Panel();
            this.labelGoalPrice = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelMonthlySalary = new System.Windows.Forms.Label();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.AddTransactionAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTransactionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTransactionName = new System.Windows.Forms.TextBox();
            this.textBoxTransactionSearchBar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTransactionCategory = new System.Windows.Forms.ComboBox();
            this.panelMainMenu.SuspendLayout();
            this.panelStartingValues.SuspendLayout();
            this.panelStartingValuesScreen.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddTransactions
            // 
            this.buttonAddTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonAddTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTransactions.FlatAppearance.BorderSize = 0;
            this.buttonAddTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonAddTransactions.Location = new System.Drawing.Point(0, 82);
            this.buttonAddTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTransactions.Name = "buttonAddTransactions";
            this.buttonAddTransactions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonAddTransactions.Size = new System.Drawing.Size(182, 32);
            this.buttonAddTransactions.TabIndex = 1;
            this.buttonAddTransactions.Text = "Add transaction";
            this.buttonAddTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTransactions.UseVisualStyleBackColor = false;
            this.buttonAddTransactions.Click += new System.EventHandler(this.buttonAddTransactions_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMainMenu.Controls.Add(this.panelStartingValues);
            this.panelMainMenu.Controls.Add(this.buttonStartingValues);
            this.panelMainMenu.Controls.Add(this.buttonAddTransactions);
            this.panelMainMenu.Controls.Add(this.panelLogo);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(182, 459);
            this.panelMainMenu.TabIndex = 2;
            // 
            // panelStartingValues
            // 
            this.panelStartingValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelStartingValues.Controls.Add(this.buttonAddStartingValues);
            this.panelStartingValues.Controls.Add(this.buttonShowStartingValues);
            this.panelStartingValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStartingValues.Location = new System.Drawing.Point(0, 146);
            this.panelStartingValues.Margin = new System.Windows.Forms.Padding(2);
            this.panelStartingValues.Name = "panelStartingValues";
            this.panelStartingValues.Size = new System.Drawing.Size(182, 67);
            this.panelStartingValues.TabIndex = 5;
            // 
            // buttonAddStartingValues
            // 
            this.buttonAddStartingValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddStartingValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStartingValues.FlatAppearance.BorderSize = 0;
            this.buttonAddStartingValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStartingValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStartingValues.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddStartingValues.Location = new System.Drawing.Point(0, 32);
            this.buttonAddStartingValues.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddStartingValues.Name = "buttonAddStartingValues";
            this.buttonAddStartingValues.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonAddStartingValues.Size = new System.Drawing.Size(182, 32);
            this.buttonAddStartingValues.TabIndex = 1;
            this.buttonAddStartingValues.Text = "Add starting values";
            this.buttonAddStartingValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStartingValues.UseVisualStyleBackColor = false;
            this.buttonAddStartingValues.Click += new System.EventHandler(this.buttonAddStartingValues_Click);
            // 
            // buttonShowStartingValues
            // 
            this.buttonShowStartingValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonShowStartingValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowStartingValues.FlatAppearance.BorderSize = 0;
            this.buttonShowStartingValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStartingValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStartingValues.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowStartingValues.Location = new System.Drawing.Point(0, 0);
            this.buttonShowStartingValues.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowStartingValues.Name = "buttonShowStartingValues";
            this.buttonShowStartingValues.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonShowStartingValues.Size = new System.Drawing.Size(182, 32);
            this.buttonShowStartingValues.TabIndex = 0;
            this.buttonShowStartingValues.Text = "Show values";
            this.buttonShowStartingValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowStartingValues.UseVisualStyleBackColor = false;
            this.buttonShowStartingValues.Click += new System.EventHandler(this.buttonShowStartingValues_Click);
            // 
            // buttonStartingValues
            // 
            this.buttonStartingValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonStartingValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStartingValues.FlatAppearance.BorderSize = 0;
            this.buttonStartingValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartingValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartingValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonStartingValues.Location = new System.Drawing.Point(0, 114);
            this.buttonStartingValues.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartingValues.Name = "buttonStartingValues";
            this.buttonStartingValues.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonStartingValues.Size = new System.Drawing.Size(182, 32);
            this.buttonStartingValues.TabIndex = 4;
            this.buttonStartingValues.Text = "Starting values";
            this.buttonStartingValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartingValues.UseVisualStyleBackColor = false;
            this.buttonStartingValues.Click += new System.EventHandler(this.buttonStartingValues_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(182, 82);
            this.panelLogo.TabIndex = 0;
            // 
            // panelStartingValuesScreen
            // 
            this.panelStartingValuesScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelStartingValuesScreen.Controls.Add(this.labelGoalPrice);
            this.panelStartingValuesScreen.Controls.Add(this.labelGoalName);
            this.panelStartingValuesScreen.Controls.Add(this.labelMonthlySalary);
            this.panelStartingValuesScreen.Controls.Add(this.labelCurrentSavings);
            this.panelStartingValuesScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStartingValuesScreen.Location = new System.Drawing.Point(182, 375);
            this.panelStartingValuesScreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelStartingValuesScreen.Name = "panelStartingValuesScreen";
            this.panelStartingValuesScreen.Size = new System.Drawing.Size(587, 84);
            this.panelStartingValuesScreen.TabIndex = 3;
            // 
            // labelGoalPrice
            // 
            this.labelGoalPrice.AutoSize = true;
            this.labelGoalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGoalPrice.Location = new System.Drawing.Point(61, 33);
            this.labelGoalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGoalPrice.Name = "labelGoalPrice";
            this.labelGoalPrice.Size = new System.Drawing.Size(98, 20);
            this.labelGoalPrice.TabIndex = 12;
            this.labelGoalPrice.Text = "Goal price: 0";
            // 
            // labelGoalName
            // 
            this.labelGoalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGoalName.Location = new System.Drawing.Point(61, 15);
            this.labelGoalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(47, 20);
            this.labelGoalName.TabIndex = 11;
            this.labelGoalName.Text = "Goal:";
            // 
            // labelMonthlySalary
            // 
            this.labelMonthlySalary.AutoSize = true;
            this.labelMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlySalary.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMonthlySalary.Location = new System.Drawing.Point(284, 50);
            this.labelMonthlySalary.Name = "labelMonthlySalary";
            this.labelMonthlySalary.Size = new System.Drawing.Size(126, 20);
            this.labelMonthlySalary.TabIndex = 10;
            this.labelMonthlySalary.Text = "Monthly salary: 0";
            // 
            // labelCurrentSavings
            // 
            this.labelCurrentSavings.AutoSize = true;
            this.labelCurrentSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSavings.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentSavings.Location = new System.Drawing.Point(61, 50);
            this.labelCurrentSavings.Name = "labelCurrentSavings";
            this.labelCurrentSavings.Size = new System.Drawing.Size(136, 20);
            this.labelCurrentSavings.TabIndex = 9;
            this.labelCurrentSavings.Text = "Current savings: 0";
            // 
            // panelTransactions
            // 
            this.panelTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTransactions.Controls.Add(this.AddTransactionCategory);
            this.panelTransactions.Controls.Add(this.label4);
            this.panelTransactions.Controls.Add(this.AddTransactionButton);
            this.panelTransactions.Controls.Add(this.AddTransactionAmount);
            this.panelTransactions.Controls.Add(this.label1);
            this.panelTransactions.Controls.Add(this.label2);
            this.panelTransactions.Controls.Add(this.AddTransactionType);
            this.panelTransactions.Controls.Add(this.label3);
            this.panelTransactions.Controls.Add(this.AddTransactionName);
            this.panelTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactions.Location = new System.Drawing.Point(182, 0);
            this.panelTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(587, 84);
            this.panelTransactions.TabIndex = 14;
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddTransactionButton.Location = new System.Drawing.Point(444, 22);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(131, 38);
            this.AddTransactionButton.TabIndex = 18;
            this.AddTransactionButton.Text = "Add transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AddTransactionAmount
            // 
            this.AddTransactionAmount.Location = new System.Drawing.Point(182, 41);
            this.AddTransactionAmount.Name = "AddTransactionAmount";
            this.AddTransactionAmount.Size = new System.Drawing.Size(62, 20);
            this.AddTransactionAmount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(72, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Title:";
            // 
            // AddTransactionType
            // 
            this.AddTransactionType.BackColor = System.Drawing.Color.DarkGray;
            this.AddTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionType.FormattingEnabled = true;
            this.AddTransactionType.Items.AddRange(new object[] {
            "+",
            "-"});
            this.AddTransactionType.Location = new System.Drawing.Point(23, 40);
            this.AddTransactionType.Name = "AddTransactionType";
            this.AddTransactionType.Size = new System.Drawing.Size(44, 21);
            this.AddTransactionType.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount:";
            // 
            // AddTransactionName
            // 
            this.AddTransactionName.Location = new System.Drawing.Point(76, 41);
            this.AddTransactionName.Name = "AddTransactionName";
            this.AddTransactionName.Size = new System.Drawing.Size(100, 20);
            this.AddTransactionName.TabIndex = 12;
            // 
            // textBoxTransactionSearchBar
            // 
            this.textBoxTransactionSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTransactionSearchBar.Location = new System.Drawing.Point(182, 84);
            this.textBoxTransactionSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTransactionSearchBar.Name = "textBoxTransactionSearchBar";
            this.textBoxTransactionSearchBar.Size = new System.Drawing.Size(587, 20);
            this.textBoxTransactionSearchBar.TabIndex = 16;
            this.textBoxTransactionSearchBar.TextChanged += new System.EventHandler(this.textBoxTransactionSearchBar_TextChanged);
            // 
            // flowLayoutPanelTransactions
            // 
            this.flowLayoutPanelTransactions.AutoScroll = true;
            this.flowLayoutPanelTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTransactions.Location = new System.Drawing.Point(182, 104);
            this.flowLayoutPanelTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelTransactions.Name = "flowLayoutPanelTransactions";
            this.flowLayoutPanelTransactions.Size = new System.Drawing.Size(587, 271);
            this.flowLayoutPanelTransactions.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(284, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Category:";
            // 
            // AddTransactionCategory
            // 
            this.AddTransactionCategory.BackColor = System.Drawing.Color.DarkGray;
            this.AddTransactionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionCategory.FormattingEnabled = true;
            this.AddTransactionCategory.Items.AddRange(new object[] {
            "Food",
            "Living",
            "Healthcare",
            "Transport"});
            this.AddTransactionCategory.Location = new System.Drawing.Point(288, 39);
            this.AddTransactionCategory.Name = "AddTransactionCategory";
            this.AddTransactionCategory.Size = new System.Drawing.Size(122, 21);
            this.AddTransactionCategory.TabIndex = 20;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 459);
            this.Controls.Add(this.flowLayoutPanelTransactions);
            this.Controls.Add(this.textBoxTransactionSearchBar);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelStartingValuesScreen);
            this.Controls.Add(this.panelMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelStartingValues.ResumeLayout(false);
            this.panelStartingValuesScreen.ResumeLayout(false);
            this.panelStartingValuesScreen.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAddTransactions;
        private System.Windows.Forms.Panel panelStartingValues;
        private System.Windows.Forms.Button buttonAddStartingValues;
        private System.Windows.Forms.Button buttonShowStartingValues;
        private System.Windows.Forms.Button buttonStartingValues;
        private System.Windows.Forms.Panel panelStartingValuesScreen;
        private System.Windows.Forms.Label labelGoalPrice;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelMonthlySalary;
        private System.Windows.Forms.Label labelCurrentSavings;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.TextBox AddTransactionAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddTransactionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddTransactionName;
        private System.Windows.Forms.TextBox textBoxTransactionSearchBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTransactions;
        private System.Windows.Forms.ComboBox AddTransactionCategory;
        private System.Windows.Forms.Label label4;
    }
}