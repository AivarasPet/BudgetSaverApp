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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonAddPortfolioValues = new System.Windows.Forms.Button();
            this.buttonAddTransactions = new System.Windows.Forms.Button();
            this.textBoxTransactionSearchBar = new System.Windows.Forms.TextBox();
            this.tabControlPortfolio = new System.Windows.Forms.TabControl();
            this.tabPageSavings = new System.Windows.Forms.TabPage();
            this.buttonSelectMoney = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectCommodities = new System.Windows.Forms.Button();
            this.buttonSelectCrypto = new System.Windows.Forms.Button();
            this.buttonSelectStocks = new System.Windows.Forms.Button();
            this.flowLayoutPanelSavings = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPagePortfolio = new System.Windows.Forms.TabPage();
            this.labelGoalPrice = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelMonthlySalary = new System.Windows.Forms.Label();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.panelPortfolioButtons = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectCommodities = new System.Windows.Forms.Button();
            this.buttonSelectCrypto = new System.Windows.Forms.Button();
            this.buttonSelectStocks = new System.Windows.Forms.Button();
            this.buttonSelectMoney = new System.Windows.Forms.Button();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.panelMainMenu.SuspendLayout();
            this.tabControlPortfolio.SuspendLayout();
            this.tabPageSavings.SuspendLayout();
            this.tabPagePortfolio.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.panelPortfolioButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
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
            this.panelMainMenu.Size = new System.Drawing.Size(936, 36);
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
            this.buttonAddPortfolioValues.Size = new System.Drawing.Size(142, 26);
            this.buttonAddPortfolioValues.TabIndex = 3;
            this.buttonAddPortfolioValues.Text = "Add starting values";
            this.buttonAddPortfolioValues.UseVisualStyleBackColor = false;
            this.buttonAddPortfolioValues.Click += new System.EventHandler(this.buttonAddPortfolioValues_Click);
            // 
            // buttonAddTransactions
            // 
            this.buttonAddTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddTransactions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddTransactions.FlatAppearance.BorderSize = 0;
            this.buttonAddTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransactions.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddTransactions.Location = new System.Drawing.Point(0, 3);
            this.buttonAddTransactions.Name = "buttonAddTransactions";
            this.buttonAddTransactions.Size = new System.Drawing.Size(120, 27);
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
            this.flowLayoutPanelTransactions.Size = new System.Drawing.Size(352, 441);
            this.flowLayoutPanelTransactions.TabIndex = 4;
            // 
            // textBoxTransactionSearchBar
            // 
            this.textBoxTransactionSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransactionSearchBar.Location = new System.Drawing.Point(25, 4);
            this.textBoxTransactionSearchBar.Name = "textBoxTransactionSearchBar";
            this.textBoxTransactionSearchBar.Size = new System.Drawing.Size(325, 15);
            this.textBoxTransactionSearchBar.TabIndex = 0;
            this.textBoxTransactionSearchBar.TextChanged += new System.EventHandler(this.textBoxTransactionSearchBar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlPortfolio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(358, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 463);
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
            this.tabControlPortfolio.Size = new System.Drawing.Size(586, 463);
            this.tabControlPortfolio.TabIndex = 0;
            // 
            // tabPageSavings
            // 
            this.tabPageSavings.AutoScroll = true;
            this.tabPageSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPageSavings.Controls.Add(this.buttonSelectMoney);
            this.tabPageSavings.Controls.Add(this.buttonSelectAll);
            this.tabPageSavings.Controls.Add(this.buttonSelectCommodities);
            this.tabPageSavings.Controls.Add(this.buttonSelectCrypto);
            this.tabPageSavings.Controls.Add(this.buttonSelectStocks);
            this.tabPageSavings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSavings.Name = "tabPageSavings";
            this.tabPageSavings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSavings.Size = new System.Drawing.Size(578, 434);
            this.tabPageSavings.TabIndex = 0;
            this.tabPageSavings.Text = "Savings";
            // 
            // buttonSelectMoney
            // 
            this.buttonSelectMoney.BackColor = System.Drawing.Color.White;
            this.buttonSelectMoney.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectMoney.FlatAppearance.BorderSize = 2;
            this.buttonSelectMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSelectMoney.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectMoney.Image")));
            this.buttonSelectMoney.Location = new System.Drawing.Point(521, 388);
            this.buttonSelectMoney.Name = "buttonSelectMoney";
            this.buttonSelectMoney.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectMoney.TabIndex = 4;
            this.buttonSelectMoney.UseVisualStyleBackColor = false;
            this.buttonSelectMoney.Click += new System.EventHandler(this.buttonSelectMoney_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.BackColor = System.Drawing.Color.White;
            this.buttonSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectAll.FlatAppearance.BorderSize = 2;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectAll.Image")));
            this.buttonSelectAll.Location = new System.Drawing.Point(521, 167);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonSelectCommodities
            // 
            this.buttonSelectCommodities.BackColor = System.Drawing.Color.White;
            this.buttonSelectCommodities.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectCommodities.FlatAppearance.BorderSize = 2;
            this.buttonSelectCommodities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCommodities.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__12_;
            this.buttonSelectCommodities.Location = new System.Drawing.Point(521, 332);
            this.buttonSelectCommodities.Name = "buttonSelectCommodities";
            this.buttonSelectCommodities.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectCommodities.TabIndex = 2;
            this.buttonSelectCommodities.UseVisualStyleBackColor = false;
            this.buttonSelectCommodities.Click += new System.EventHandler(this.buttonSelectCommodities_Click);
            // 
            // buttonSelectCrypto
            // 
            this.buttonSelectCrypto.BackColor = System.Drawing.Color.White;
            this.buttonSelectCrypto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectCrypto.FlatAppearance.BorderSize = 2;
            this.buttonSelectCrypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCrypto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectCrypto.Image")));
            this.buttonSelectCrypto.Location = new System.Drawing.Point(521, 278);
            this.buttonSelectCrypto.Name = "buttonSelectCrypto";
            this.buttonSelectCrypto.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectCrypto.TabIndex = 1;
            this.buttonSelectCrypto.UseVisualStyleBackColor = false;
            this.buttonSelectCrypto.Click += new System.EventHandler(this.buttonSelectCrypto_Click);
            // 
            // buttonSelectStocks
            // 
            this.buttonSelectStocks.BackColor = System.Drawing.Color.White;
            this.buttonSelectStocks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectStocks.FlatAppearance.BorderSize = 2;
            this.buttonSelectStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectStocks.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__13_;
            this.buttonSelectStocks.Location = new System.Drawing.Point(521, 222);
            this.buttonSelectStocks.Name = "buttonSelectStocks";
            this.buttonSelectStocks.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectStocks.TabIndex = 0;
            this.buttonSelectStocks.UseVisualStyleBackColor = false;
            this.buttonSelectStocks.Click += new System.EventHandler(this.buttonSelectStocks_Click);
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
            this.tabPagePortfolio.Size = new System.Drawing.Size(578, 434);
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
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.flowLayoutPanelTransactions);
            this.panelTransactions.Controls.Add(this.panel1);
            this.panelTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTransactions.Location = new System.Drawing.Point(0, 36);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(350, 463);
            this.panelTransactions.TabIndex = 6;
            // 
            // panelTabControl
            // 
            this.panelTabControl.Controls.Add(this.tabControlPortfolio);
            this.panelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabControl.Location = new System.Drawing.Point(350, 36);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(586, 463);
            this.panelTabControl.TabIndex = 8;
            // 
            // panelPortfolioButtons
            // 
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectAll);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectCommodities);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectCrypto);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectStocks);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectMoney);
            this.panelPortfolioButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPortfolioButtons.Location = new System.Drawing.Point(504, 3);
            this.panelPortfolioButtons.Name = "panelPortfolioButtons";
            this.panelPortfolioButtons.Size = new System.Drawing.Size(71, 428);
            this.panelPortfolioButtons.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxSearchIcon);
            this.panel1.Controls.Add(this.textBoxTransactionSearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 22);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanelTransactions
            // 
            this.flowLayoutPanelTransactions.AutoScroll = true;
            this.flowLayoutPanelTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTransactions.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanelTransactions.Name = "flowLayoutPanelTransactions";
            this.flowLayoutPanelTransactions.Size = new System.Drawing.Size(380, 441);
            this.flowLayoutPanelTransactions.TabIndex = 5;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.BackColor = System.Drawing.Color.White;
            this.buttonSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectAll.FlatAppearance.BorderSize = 2;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectAll.Image")));
            this.buttonSelectAll.Location = new System.Drawing.Point(24, 204);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonSelectCommodities
            // 
            this.buttonSelectCommodities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectCommodities.BackColor = System.Drawing.Color.White;
            this.buttonSelectCommodities.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectCommodities.FlatAppearance.BorderSize = 2;
            this.buttonSelectCommodities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCommodities.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__12_;
            this.buttonSelectCommodities.Location = new System.Drawing.Point(24, 249);
            this.buttonSelectCommodities.Name = "buttonSelectCommodities";
            this.buttonSelectCommodities.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectCommodities.TabIndex = 2;
            this.buttonSelectCommodities.UseVisualStyleBackColor = false;
            this.buttonSelectCommodities.Click += new System.EventHandler(this.buttonSelectCommodities_Click);
            // 
            // buttonSelectCrypto
            // 
            this.buttonSelectCrypto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectCrypto.BackColor = System.Drawing.Color.White;
            this.buttonSelectCrypto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectCrypto.FlatAppearance.BorderSize = 2;
            this.buttonSelectCrypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCrypto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectCrypto.Image")));
            this.buttonSelectCrypto.Location = new System.Drawing.Point(24, 294);
            this.buttonSelectCrypto.Name = "buttonSelectCrypto";
            this.buttonSelectCrypto.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectCrypto.TabIndex = 1;
            this.buttonSelectCrypto.UseVisualStyleBackColor = false;
            this.buttonSelectCrypto.Click += new System.EventHandler(this.buttonSelectCrypto_Click);
            // 
            // buttonSelectStocks
            // 
            this.buttonSelectStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectStocks.BackColor = System.Drawing.Color.White;
            this.buttonSelectStocks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectStocks.FlatAppearance.BorderSize = 2;
            this.buttonSelectStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectStocks.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__13_;
            this.buttonSelectStocks.Location = new System.Drawing.Point(24, 339);
            this.buttonSelectStocks.Name = "buttonSelectStocks";
            this.buttonSelectStocks.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectStocks.TabIndex = 0;
            this.buttonSelectStocks.UseVisualStyleBackColor = false;
            this.buttonSelectStocks.Click += new System.EventHandler(this.buttonSelectStocks_Click);
            // 
            // buttonSelectMoney
            // 
            this.buttonSelectMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectMoney.BackColor = System.Drawing.Color.White;
            this.buttonSelectMoney.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectMoney.FlatAppearance.BorderSize = 2;
            this.buttonSelectMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSelectMoney.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectMoney.Image")));
            this.buttonSelectMoney.Location = new System.Drawing.Point(24, 384);
            this.buttonSelectMoney.Name = "buttonSelectMoney";
            this.buttonSelectMoney.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectMoney.TabIndex = 4;
            this.buttonSelectMoney.UseVisualStyleBackColor = false;
            this.buttonSelectMoney.Click += new System.EventHandler(this.buttonSelectMoney_Click);
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSearchIcon.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__21_;
            this.pictureBoxSearchIcon.ImageLocation = "";
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(25, 22);
            this.pictureBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSearchIcon.TabIndex = 1;
            this.pictureBoxSearchIcon.TabStop = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(936, 499);
            this.Controls.Add(this.panelTabControl);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelMainMenu);
            this.MinimumSize = new System.Drawing.Size(954, 546);
            this.Name = "MainUI";
            this.Text = "Budget saver app";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.tabControlPortfolio.ResumeLayout(false);
            this.tabPageSavings.ResumeLayout(false);
            this.tabPagePortfolio.ResumeLayout(false);
            this.tabPagePortfolio.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTabControl.ResumeLayout(false);
            this.panelPortfolioButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonAddPortfolioValues;
        private System.Windows.Forms.Button buttonAddTransactions;
        private System.Windows.Forms.TextBox textBoxTransactionSearchBar;
        private System.Windows.Forms.TabControl tabControlPortfolio;
        private System.Windows.Forms.TabPage tabPageSavings;
        private System.Windows.Forms.TabPage tabPagePortfolio;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label labelGoalPrice;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelMonthlySalary;
        private System.Windows.Forms.Label labelCurrentSavings;
        private System.Windows.Forms.Button buttonSelectStocks;
        private System.Windows.Forms.Button buttonSelectMoney;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectCommodities;
        private System.Windows.Forms.Button buttonSelectCrypto;
        private System.Windows.Forms.Panel panelTabControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSavings;
        private System.Windows.Forms.Panel panelPortfolioButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTransactions;
        private System.Windows.Forms.PictureBox pictureBoxSearchIcon;
    }
}