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
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddPortfolioValues = new System.Windows.Forms.Button();
            this.buttonAddTransactions = new System.Windows.Forms.Button();
            this.textBoxTransactionSearchBar = new System.Windows.Forms.TextBox();
            this.tabControlPortfolio = new System.Windows.Forms.TabControl();
            this.tabPageSavings = new System.Windows.Forms.TabPage();
            this.panelPortfolioButtons = new System.Windows.Forms.Panel();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectCommodities = new System.Windows.Forms.Button();
            this.buttonSelectCrypto = new System.Windows.Forms.Button();
            this.buttonSelectStocks = new System.Windows.Forms.Button();
            this.buttonSelectMoney = new System.Windows.Forms.Button();
            this.flowLayoutPanelSavings = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelTotalValueSavings3 = new System.Windows.Forms.Label();
            this.labelAmountSavings3 = new System.Windows.Forms.Label();
            this.labelTitleSavings3 = new System.Windows.Forms.Label();
            this.labelTotalValueSavings2 = new System.Windows.Forms.Label();
            this.labelAmountSavings2 = new System.Windows.Forms.Label();
            this.labelTitleSavings2 = new System.Windows.Forms.Label();
            this.labelTotalValueSavings1 = new System.Windows.Forms.Label();
            this.labelAmountSavings1 = new System.Windows.Forms.Label();
            this.labelTitleSavings1 = new System.Windows.Forms.Label();
            this.tabPagePortfolio = new System.Windows.Forms.TabPage();
            this.labelGoalPrice = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelMonthlySalary = new System.Windows.Forms.Label();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.tabPageStats = new System.Windows.Forms.TabPage();
            this.labelStatsWeeklyBalance = new System.Windows.Forms.Label();
            this.labelStatsFrequentCategory = new System.Windows.Forms.Label();
            this.labelStatsWeeklyTransactionAmount = new System.Windows.Forms.Label();
            this.labelStatsWeeklyIncome = new System.Windows.Forms.Label();
            this.labelStatsWeeklyExpenses = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.tabPageFunctions = new System.Windows.Forms.TabPage();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.tabControlPortfolio.SuspendLayout();
            this.tabPageSavings.SuspendLayout();
            this.panelPortfolioButtons.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.tabPagePortfolio.SuspendLayout();
            this.tabPageStats.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
            this.panelTabControl.SuspendLayout();
            this.tabPageFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMainMenu.Controls.Add(this.buttonAddCategory);
            this.panelMainMenu.Controls.Add(this.buttonAddPortfolioValues);
            this.panelMainMenu.Controls.Add(this.buttonAddTransactions);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(936, 36);
            this.panelMainMenu.TabIndex = 0;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddCategory.FlatAppearance.BorderSize = 0;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddCategory.Location = new System.Drawing.Point(126, 3);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(141, 27);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.TabStop = false;
            this.buttonAddCategory.Text = "Add category";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddPortfolioValues
            // 
            this.buttonAddPortfolioValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddPortfolioValues.FlatAppearance.BorderSize = 0;
            this.buttonAddPortfolioValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPortfolioValues.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddPortfolioValues.Location = new System.Drawing.Point(273, 3);
            this.buttonAddPortfolioValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPortfolioValues.Name = "buttonAddPortfolioValues";
            this.buttonAddPortfolioValues.Size = new System.Drawing.Size(141, 27);
            this.buttonAddPortfolioValues.TabIndex = 3;
            this.buttonAddPortfolioValues.TabStop = false;
            this.buttonAddPortfolioValues.Text = "Add starting values";
            this.buttonAddPortfolioValues.UseVisualStyleBackColor = false;
            this.buttonAddPortfolioValues.Click += new System.EventHandler(this.buttonAddPortfolioValues_Click);
            // 
            // buttonAddTransactions
            // 
            this.buttonAddTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddTransactions.FlatAppearance.BorderSize = 0;
            this.buttonAddTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransactions.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddTransactions.Location = new System.Drawing.Point(0, 2);
            this.buttonAddTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTransactions.Name = "buttonAddTransactions";
            this.buttonAddTransactions.Size = new System.Drawing.Size(120, 27);
            this.buttonAddTransactions.TabIndex = 1;
            this.buttonAddTransactions.TabStop = false;
            this.buttonAddTransactions.Text = "Add transaction";
            this.buttonAddTransactions.UseVisualStyleBackColor = false;
            this.buttonAddTransactions.Click += new System.EventHandler(this.buttonAddTransactions_Click);
            // 
            // textBoxTransactionSearchBar
            // 
            this.textBoxTransactionSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransactionSearchBar.Location = new System.Drawing.Point(25, 4);
            this.textBoxTransactionSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTransactionSearchBar.Name = "textBoxTransactionSearchBar";
            this.textBoxTransactionSearchBar.Size = new System.Drawing.Size(325, 15);
            this.textBoxTransactionSearchBar.TabIndex = 0;
            this.textBoxTransactionSearchBar.TextChanged += new System.EventHandler(this.textBoxTransactionSearchBar_TextChanged);
            // 
            // tabControlPortfolio
            // 
            this.tabControlPortfolio.Controls.Add(this.tabPageSavings);
            this.tabControlPortfolio.Controls.Add(this.tabPagePortfolio);
            this.tabControlPortfolio.Controls.Add(this.tabPageStats);
            this.tabControlPortfolio.Controls.Add(this.tabPageFunctions);
            this.tabControlPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPortfolio.Location = new System.Drawing.Point(0, 0);
            this.tabControlPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPortfolio.Name = "tabControlPortfolio";
            this.tabControlPortfolio.SelectedIndex = 0;
            this.tabControlPortfolio.Size = new System.Drawing.Size(587, 471);
            this.tabControlPortfolio.TabIndex = 0;
            // 
            // tabPageSavings
            // 
            this.tabPageSavings.AutoScroll = true;
            this.tabPageSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPageSavings.Controls.Add(this.panelPortfolioButtons);
            this.tabPageSavings.Controls.Add(this.flowLayoutPanelSavings);
            this.tabPageSavings.Controls.Add(this.panelLabels);
            this.tabPageSavings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSavings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSavings.Name = "tabPageSavings";
            this.tabPageSavings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSavings.Size = new System.Drawing.Size(579, 442);
            this.tabPageSavings.TabIndex = 0;
            this.tabPageSavings.Text = "Savings";
            // 
            // panelPortfolioButtons
            // 
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectAll);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectCommodities);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectCrypto);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectStocks);
            this.panelPortfolioButtons.Controls.Add(this.buttonSelectMoney);
            this.panelPortfolioButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPortfolioButtons.Location = new System.Drawing.Point(516, 27);
            this.panelPortfolioButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPortfolioButtons.Name = "panelPortfolioButtons";
            this.panelPortfolioButtons.Size = new System.Drawing.Size(60, 413);
            this.panelPortfolioButtons.TabIndex = 2;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.BackColor = System.Drawing.Color.White;
            this.buttonSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectAll.FlatAppearance.BorderSize = 2;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectAll.Image")));
            this.buttonSelectAll.Location = new System.Drawing.Point(13, 189);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonSelectCommodities.Location = new System.Drawing.Point(13, 234);
            this.buttonSelectCommodities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonSelectCrypto.Location = new System.Drawing.Point(13, 279);
            this.buttonSelectCrypto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonSelectStocks.Location = new System.Drawing.Point(13, 325);
            this.buttonSelectStocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonSelectMoney.Location = new System.Drawing.Point(13, 369);
            this.buttonSelectMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectMoney.Name = "buttonSelectMoney";
            this.buttonSelectMoney.Size = new System.Drawing.Size(41, 39);
            this.buttonSelectMoney.TabIndex = 4;
            this.buttonSelectMoney.UseVisualStyleBackColor = false;
            this.buttonSelectMoney.Click += new System.EventHandler(this.buttonSelectMoney_Click);
            // 
            // flowLayoutPanelSavings
            // 
            this.flowLayoutPanelSavings.AutoScroll = true;
            this.flowLayoutPanelSavings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSavings.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanelSavings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelSavings.Name = "flowLayoutPanelSavings";
            this.flowLayoutPanelSavings.Size = new System.Drawing.Size(573, 413);
            this.flowLayoutPanelSavings.TabIndex = 6;
            // 
            // panelLabels
            // 
            this.panelLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLabels.Controls.Add(this.labelTotalValueSavings3);
            this.panelLabels.Controls.Add(this.labelAmountSavings3);
            this.panelLabels.Controls.Add(this.labelTitleSavings3);
            this.panelLabels.Controls.Add(this.labelTotalValueSavings2);
            this.panelLabels.Controls.Add(this.labelAmountSavings2);
            this.panelLabels.Controls.Add(this.labelTitleSavings2);
            this.panelLabels.Controls.Add(this.labelTotalValueSavings1);
            this.panelLabels.Controls.Add(this.labelAmountSavings1);
            this.panelLabels.Controls.Add(this.labelTitleSavings1);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabels.Location = new System.Drawing.Point(3, 2);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(573, 25);
            this.panelLabels.TabIndex = 0;
            // 
            // labelTotalValueSavings3
            // 
            this.labelTotalValueSavings3.AutoSize = true;
            this.labelTotalValueSavings3.ForeColor = System.Drawing.Color.White;
            this.labelTotalValueSavings3.Location = new System.Drawing.Point(1267, 3);
            this.labelTotalValueSavings3.Name = "labelTotalValueSavings3";
            this.labelTotalValueSavings3.Size = new System.Drawing.Size(82, 17);
            this.labelTotalValueSavings3.TabIndex = 14;
            this.labelTotalValueSavings3.Text = "Total value:";
            // 
            // labelAmountSavings3
            // 
            this.labelAmountSavings3.AutoSize = true;
            this.labelAmountSavings3.ForeColor = System.Drawing.Color.White;
            this.labelAmountSavings3.Location = new System.Drawing.Point(1170, 3);
            this.labelAmountSavings3.Name = "labelAmountSavings3";
            this.labelAmountSavings3.Size = new System.Drawing.Size(60, 17);
            this.labelAmountSavings3.TabIndex = 13;
            this.labelAmountSavings3.Text = "Amount:";
            // 
            // labelTitleSavings3
            // 
            this.labelTitleSavings3.AutoSize = true;
            this.labelTitleSavings3.ForeColor = System.Drawing.Color.White;
            this.labelTitleSavings3.Location = new System.Drawing.Point(1031, 3);
            this.labelTitleSavings3.Name = "labelTitleSavings3";
            this.labelTitleSavings3.Size = new System.Drawing.Size(43, 17);
            this.labelTitleSavings3.TabIndex = 12;
            this.labelTitleSavings3.Text = "Title: ";
            // 
            // labelTotalValueSavings2
            // 
            this.labelTotalValueSavings2.AutoSize = true;
            this.labelTotalValueSavings2.ForeColor = System.Drawing.Color.White;
            this.labelTotalValueSavings2.Location = new System.Drawing.Point(809, 3);
            this.labelTotalValueSavings2.Name = "labelTotalValueSavings2";
            this.labelTotalValueSavings2.Size = new System.Drawing.Size(82, 17);
            this.labelTotalValueSavings2.TabIndex = 11;
            this.labelTotalValueSavings2.Text = "Total value:";
            // 
            // labelAmountSavings2
            // 
            this.labelAmountSavings2.AutoSize = true;
            this.labelAmountSavings2.ForeColor = System.Drawing.Color.White;
            this.labelAmountSavings2.Location = new System.Drawing.Point(712, 3);
            this.labelAmountSavings2.Name = "labelAmountSavings2";
            this.labelAmountSavings2.Size = new System.Drawing.Size(60, 17);
            this.labelAmountSavings2.TabIndex = 10;
            this.labelAmountSavings2.Text = "Amount:";
            // 
            // labelTitleSavings2
            // 
            this.labelTitleSavings2.AutoSize = true;
            this.labelTitleSavings2.ForeColor = System.Drawing.Color.White;
            this.labelTitleSavings2.Location = new System.Drawing.Point(573, 3);
            this.labelTitleSavings2.Name = "labelTitleSavings2";
            this.labelTitleSavings2.Size = new System.Drawing.Size(43, 17);
            this.labelTitleSavings2.TabIndex = 9;
            this.labelTitleSavings2.Text = "Title: ";
            // 
            // labelTotalValueSavings1
            // 
            this.labelTotalValueSavings1.AutoSize = true;
            this.labelTotalValueSavings1.ForeColor = System.Drawing.Color.White;
            this.labelTotalValueSavings1.Location = new System.Drawing.Point(359, 3);
            this.labelTotalValueSavings1.Name = "labelTotalValueSavings1";
            this.labelTotalValueSavings1.Size = new System.Drawing.Size(82, 17);
            this.labelTotalValueSavings1.TabIndex = 8;
            this.labelTotalValueSavings1.Text = "Total value:";
            // 
            // labelAmountSavings1
            // 
            this.labelAmountSavings1.AutoSize = true;
            this.labelAmountSavings1.ForeColor = System.Drawing.Color.White;
            this.labelAmountSavings1.Location = new System.Drawing.Point(262, 3);
            this.labelAmountSavings1.Name = "labelAmountSavings1";
            this.labelAmountSavings1.Size = new System.Drawing.Size(60, 17);
            this.labelAmountSavings1.TabIndex = 7;
            this.labelAmountSavings1.Text = "Amount:";
            // 
            // labelTitleSavings1
            // 
            this.labelTitleSavings1.AutoSize = true;
            this.labelTitleSavings1.ForeColor = System.Drawing.Color.White;
            this.labelTitleSavings1.Location = new System.Drawing.Point(100, 3);
            this.labelTitleSavings1.Name = "labelTitleSavings1";
            this.labelTitleSavings1.Size = new System.Drawing.Size(43, 17);
            this.labelTitleSavings1.TabIndex = 3;
            this.labelTitleSavings1.Text = "Title: ";
            // 
            // tabPagePortfolio
            // 
            this.tabPagePortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPagePortfolio.Controls.Add(this.labelGoalPrice);
            this.tabPagePortfolio.Controls.Add(this.labelGoalName);
            this.tabPagePortfolio.Controls.Add(this.labelMonthlySalary);
            this.tabPagePortfolio.Controls.Add(this.labelCurrentSavings);
            this.tabPagePortfolio.Location = new System.Drawing.Point(4, 25);
            this.tabPagePortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePortfolio.Name = "tabPagePortfolio";
            this.tabPagePortfolio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePortfolio.Size = new System.Drawing.Size(579, 442);
            this.tabPagePortfolio.TabIndex = 1;
            this.tabPagePortfolio.Text = "Portfolio";
            // 
            // labelGoalPrice
            // 
            this.labelGoalPrice.AutoSize = true;
            this.labelGoalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalPrice.ForeColor = System.Drawing.Color.White;
            this.labelGoalPrice.Location = new System.Drawing.Point(25, 59);
            this.labelGoalPrice.Name = "labelGoalPrice";
            this.labelGoalPrice.Size = new System.Drawing.Size(122, 25);
            this.labelGoalPrice.TabIndex = 16;
            this.labelGoalPrice.Text = "Goal price: 0";
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.ForeColor = System.Drawing.Color.White;
            this.labelGoalName.Location = new System.Drawing.Point(25, 23);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(59, 25);
            this.labelGoalName.TabIndex = 15;
            this.labelGoalName.Text = "Goal:";
            // 
            // labelMonthlySalary
            // 
            this.labelMonthlySalary.AutoSize = true;
            this.labelMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlySalary.ForeColor = System.Drawing.Color.White;
            this.labelMonthlySalary.Location = new System.Drawing.Point(25, 130);
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
            this.labelCurrentSavings.ForeColor = System.Drawing.Color.White;
            this.labelCurrentSavings.Location = new System.Drawing.Point(25, 95);
            this.labelCurrentSavings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentSavings.Name = "labelCurrentSavings";
            this.labelCurrentSavings.Size = new System.Drawing.Size(171, 25);
            this.labelCurrentSavings.TabIndex = 13;
            this.labelCurrentSavings.Text = "Current savings: 0";
            // 
            // tabPageStats
            // 
            this.tabPageStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPageStats.Controls.Add(this.labelStatsWeeklyBalance);
            this.tabPageStats.Controls.Add(this.labelStatsFrequentCategory);
            this.tabPageStats.Controls.Add(this.labelStatsWeeklyTransactionAmount);
            this.tabPageStats.Controls.Add(this.labelStatsWeeklyIncome);
            this.tabPageStats.Controls.Add(this.labelStatsWeeklyExpenses);
            this.tabPageStats.Location = new System.Drawing.Point(4, 25);
            this.tabPageStats.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStats.Name = "tabPageStats";
            this.tabPageStats.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStats.Size = new System.Drawing.Size(579, 442);
            this.tabPageStats.TabIndex = 2;
            this.tabPageStats.Text = "Stats";
            // 
            // labelStatsWeeklyBalance
            // 
            this.labelStatsWeeklyBalance.AutoSize = true;
            this.labelStatsWeeklyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatsWeeklyBalance.ForeColor = System.Drawing.Color.White;
            this.labelStatsWeeklyBalance.Location = new System.Drawing.Point(15, 130);
            this.labelStatsWeeklyBalance.Name = "labelStatsWeeklyBalance";
            this.labelStatsWeeklyBalance.Size = new System.Drawing.Size(158, 25);
            this.labelStatsWeeklyBalance.TabIndex = 4;
            this.labelStatsWeeklyBalance.Text = "Weekly balance:";
            // 
            // labelStatsFrequentCategory
            // 
            this.labelStatsFrequentCategory.AutoSize = true;
            this.labelStatsFrequentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatsFrequentCategory.ForeColor = System.Drawing.Color.White;
            this.labelStatsFrequentCategory.Location = new System.Drawing.Point(15, 167);
            this.labelStatsFrequentCategory.Name = "labelStatsFrequentCategory";
            this.labelStatsFrequentCategory.Size = new System.Drawing.Size(217, 25);
            this.labelStatsFrequentCategory.TabIndex = 3;
            this.labelStatsFrequentCategory.Text = "Most frequent category:";
            // 
            // labelStatsWeeklyTransactionAmount
            // 
            this.labelStatsWeeklyTransactionAmount.AutoSize = true;
            this.labelStatsWeeklyTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatsWeeklyTransactionAmount.ForeColor = System.Drawing.Color.White;
            this.labelStatsWeeklyTransactionAmount.Location = new System.Drawing.Point(15, 22);
            this.labelStatsWeeklyTransactionAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatsWeeklyTransactionAmount.Name = "labelStatsWeeklyTransactionAmount";
            this.labelStatsWeeklyTransactionAmount.Size = new System.Drawing.Size(253, 25);
            this.labelStatsWeeklyTransactionAmount.TabIndex = 2;
            this.labelStatsWeeklyTransactionAmount.Text = "Total transactions in a week";
            // 
            // labelStatsWeeklyIncome
            // 
            this.labelStatsWeeklyIncome.AutoSize = true;
            this.labelStatsWeeklyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatsWeeklyIncome.ForeColor = System.Drawing.Color.White;
            this.labelStatsWeeklyIncome.Location = new System.Drawing.Point(15, 56);
            this.labelStatsWeeklyIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatsWeeklyIncome.Name = "labelStatsWeeklyIncome";
            this.labelStatsWeeklyIncome.Size = new System.Drawing.Size(152, 25);
            this.labelStatsWeeklyIncome.TabIndex = 1;
            this.labelStatsWeeklyIncome.Text = "Weekly income:";
            // 
            // labelStatsWeeklyExpenses
            // 
            this.labelStatsWeeklyExpenses.AutoSize = true;
            this.labelStatsWeeklyExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatsWeeklyExpenses.ForeColor = System.Drawing.Color.White;
            this.labelStatsWeeklyExpenses.Location = new System.Drawing.Point(15, 92);
            this.labelStatsWeeklyExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatsWeeklyExpenses.Name = "labelStatsWeeklyExpenses";
            this.labelStatsWeeklyExpenses.Size = new System.Drawing.Size(174, 25);
            this.labelStatsWeeklyExpenses.TabIndex = 0;
            this.labelStatsWeeklyExpenses.Text = "Weekly expenses:";
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.flowLayoutPanelTransactions);
            this.panelTransactions.Controls.Add(this.panel1);
            this.panelTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTransactions.Location = new System.Drawing.Point(0, 36);
            this.panelTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(349, 471);
            this.panelTransactions.TabIndex = 6;
            // 
            // flowLayoutPanelTransactions
            // 
            this.flowLayoutPanelTransactions.AutoScroll = true;
            this.flowLayoutPanelTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTransactions.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanelTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelTransactions.Name = "flowLayoutPanelTransactions";
            this.flowLayoutPanelTransactions.Size = new System.Drawing.Size(380, 449);
            this.flowLayoutPanelTransactions.TabIndex = 5;
            this.flowLayoutPanelTransactions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanelTransactions_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxSearchIcon);
            this.panel1.Controls.Add(this.textBoxTransactionSearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 22);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSearchIcon.Image = global::BudgetSaverApp.Properties.Resources.Webp_net_resizeimage__21_;
            this.pictureBoxSearchIcon.ImageLocation = "";
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSearchIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(25, 22);
            this.pictureBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSearchIcon.TabIndex = 1;
            this.pictureBoxSearchIcon.TabStop = false;
            // 
            // panelTabControl
            // 
            this.panelTabControl.Controls.Add(this.tabControlPortfolio);
            this.panelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabControl.Location = new System.Drawing.Point(349, 36);
            this.panelTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(587, 471);
            this.panelTabControl.TabIndex = 8;
            // 
            // tabPageFunctions
            // 
            this.tabPageFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.tabPageFunctions.Controls.Add(this.panelFunctions);
            this.tabPageFunctions.Location = new System.Drawing.Point(4, 25);
            this.tabPageFunctions.Name = "tabPageFunctions";
            this.tabPageFunctions.Size = new System.Drawing.Size(579, 442);
            this.tabPageFunctions.TabIndex = 3;
            this.tabPageFunctions.Text = "Functions";
            // 
            // panelFunctions
            // 
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(0, 0);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(579, 442);
            this.panelFunctions.TabIndex = 0;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(936, 507);
            this.Controls.Add(this.panelTabControl);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelMainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(954, 542);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget saver app";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.tabControlPortfolio.ResumeLayout(false);
            this.tabPageSavings.ResumeLayout(false);
            this.panelPortfolioButtons.ResumeLayout(false);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.tabPagePortfolio.ResumeLayout(false);
            this.tabPagePortfolio.PerformLayout();
            this.tabPageStats.ResumeLayout(false);
            this.tabPageStats.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            this.panelTabControl.ResumeLayout(false);
            this.tabPageFunctions.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelTabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTransactions;
        private System.Windows.Forms.PictureBox pictureBoxSearchIcon;
        private System.Windows.Forms.TabPage tabPageStats;
        private System.Windows.Forms.Label labelStatsWeeklyIncome;
        private System.Windows.Forms.Label labelStatsWeeklyExpenses;
        private System.Windows.Forms.Label labelStatsWeeklyTransactionAmount;
        private System.Windows.Forms.Label labelStatsFrequentCategory;
        private System.Windows.Forms.Label labelStatsWeeklyBalance;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSavings;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panelPortfolioButtons;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectCommodities;
        private System.Windows.Forms.Button buttonSelectCrypto;
        private System.Windows.Forms.Button buttonSelectStocks;
        private System.Windows.Forms.Button buttonSelectMoney;
        private System.Windows.Forms.Label labelTitleSavings1;
        private System.Windows.Forms.Label labelTotalValueSavings1;
        private System.Windows.Forms.Label labelAmountSavings1;
        private System.Windows.Forms.Label labelTotalValueSavings2;
        private System.Windows.Forms.Label labelAmountSavings2;
        private System.Windows.Forms.Label labelTitleSavings2;
        private System.Windows.Forms.Label labelTotalValueSavings3;
        private System.Windows.Forms.Label labelAmountSavings3;
        private System.Windows.Forms.Label labelTitleSavings3;
        private System.Windows.Forms.TabPage tabPageFunctions;
        private System.Windows.Forms.Panel panelFunctions;
    }
}