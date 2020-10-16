using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Pricing;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
using static BudgetSaverApp.Pricing.APIFetcher;

namespace BudgetSaverApp
{
    public partial class MainUI : Form
    {
        private object sender;
        UserData userData;
        ITransactionService transactionService;
        IPosessionsService posessionsService;
        IStatisticsService statisticsService;
        public MainUI(ITransactionService transactionService, IPosessionsService posessionsService, IStatisticsService statisticsService)
        {
            userData = new UserData();
            this.posessionsService = posessionsService;
            this.transactionService = transactionService;
            this.statisticsService = statisticsService;
            InitializeComponent();
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            LoadSavingsOnUI(posessionsService.GetPossessionsList());
            APIFetcher.AllAPIsDownloaded += new System.EventHandler(ReloadSavings);
            SetPortfolioInfo();
            SetStatsInfo();
        }

        public void ReloadSavings(object sender, System.EventArgs e)
        {
            LoadSavingsOnUI(posessionsService.GetPossessionsList());
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            TabControlPortfolio.SelectTab(3);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelFunctions.Controls.Add(childForm);
            PanelFunctions.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Transactions
        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            FlowLayoutPanelTransactions.Controls.Clear();
            Console.WriteLine("search " + list.Count);
            foreach (Transaction t in list)
            {
                if (t == null)
                {
                    continue;
                }
                ListItemTransactions item = new ListItemTransactions
                {
                    TransactionType = t.TransactionType,
                    Title = t.Title,
                    Amount = t.Amount.ToString() + " €",
                    Category = t.Category
                };
                item.MouseDown += OnTransactionTileClicked;
                FlowLayoutPanelTransactions.Controls.Add(item);
            }
        }
        private void OnTransactionTileClicked(object sender, MouseEventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetListWithTitleFiltered(textBoxTransactionSearchBar.Text));
        }
        private void TextBoxTransactionSearchBar_TextChanged(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetListWithTitleFiltered(TextBoxTransactionSearchBar.Text));
        }

        private void ButtonAddTransactions_Click(object sender, EventArgs e)
        {
            var AddTransaction = new AddTransaction(userData, transactionService);
            AddTransaction.FormClosed += AddTransaction_FormClosed;
            OpenChildForm(AddTransaction);
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            var AddCategory = new AddCategory();
            OpenChildForm(AddCategory);
        }
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            SetStatsInfo();
        }
        #endregion

        #region Portfolio
        private void SetPortfolioInfo()
        {
            LabelGoalName.Text = "Goal: " + userData.GoalItemName;
            LabelGoalPrice.Text = "Goal Price: " + userData.GoalItemPrice;
            LabelCurrentSavings.Text = "Current savings: " + userData.CurrentSavings;
            LabelMonthlySalary.Text = "Monthly salary: " + userData.MonthlySalary;
        }
        private void ButtonAddPortfolioValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox(userData);
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            OpenChildForm(EnterInfoBoxInstance);
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetPortfolioInfo();
        }
        #endregion

        #region Savings
        private void ButtonAddSavings_Click(object sender, EventArgs e)
        {
            var AddSavings = new AddSavings(userData);
            AddSavings.FormClosed += AddSavings_FormClosed;
            OpenChildForm(AddSavings);
        }
        private void AddSavings_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
        }
        private void LoadSavingsOnUI(List<Possession> possessions)
        {
            FlowLayoutPanelSavings.Controls.Clear();
            foreach(Possession p in possessions)
            {
                ListSavings item = new ListSavings
                {
                    Title = p.Name,
                    Amount = p.Amount.ToString(),
                    Value = p.ValueInDollars + " $",
                    ImageUrl = p.LinkOfImage
                };

                item.MouseDown += OnSavingsTileClicked;
                FlowLayoutPanelSavings.Controls.Add(item);
            }
        }
        private void OnSavingsTileClicked(object sender, MouseEventArgs e)
        {
            this.sender = sender;
        }
        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectAll);
        }
        private void ButtonSelectStocks_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectStocks);
        }
        private void ButtonSelectCrypto_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectCrypto);
        }
        private void ButtonSelectCommodities_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectCommodities);
        }
        private void ButtonSelectMoney_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectMoney);
        }
        private void ChangeColor(Button button)
        {
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Khaki;
                button.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            }
            else
            {
                button.BackColor = Color.White;
                button.FlatAppearance.BorderColor = Color.Black;
            }
        }


        #endregion

        #region Stats
        private void SetStatsInfo()
        {
            Stats stats = statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now);
            labelStatsWeeklyTransactionAmount.Text = "Week amount of transaction: " + stats.TransactionAmount;
            labelStatsWeeklyIncome.Text = "Weekly Income: " + stats.Income;
            labelStatsWeeklyExpenses.Text = "Weekly Spent: " + stats.Expenses;
            labelStatsFrequentCategory.Text = "Most frequent category: " + stats.FrequentCategory;
            labelStatsWeeklyBalance.Text = "Weekly balance: " + (stats.Income - stats.Expenses);

        }

        #endregion

        #region Data
        private void ToolStripMenuItemData_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            List<Transaction> list = transactionService.GetTransactionsList();
            foreach (Control o in FlowLayoutPanelTransactions.Controls.OfType<ListItemTransactions>().ToList())
            {
                if (o.GetHashCode() == this.sender.GetHashCode())
                {
                    TabControlPortfolio.SelectTab(4);
                    LabelName.Text = "Transaction: " + list[i].Title;
                    LabelAmount.Text = "Amount: " + list[i].Amount.ToString() + " €";
                    LabelCategory.Text = "Category: " + list[i].Category;
                    LabelDate.Text = "Date added: " + (list[i].Date).ToString("yyyy/MM/dd");
                    PictureBoxLogo.Visible = false;
                    LabelDate.Visible = true;
                }
                i++;
            }
        }
        private void ToolStripMenuItemSavingsData_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            List<Possession> list = possessionsService.GetPossessionsList();
            foreach (Control o in FlowLayoutPanelSavings.Controls.OfType<ListSavings>().ToList())
            {
                if (o.GetHashCode() == this.sender.GetHashCode())
                {
                    TabControlPortfolio.SelectTab(4);
                    LabelName.Text = "Saving: " + list[i].name;
                    LabelAmount.Text = "Amount: " + list[i].amount;
                    LabelCategory.Text = "Total value: " + list[i].valueInDollars + " $";
                    LabelDate.Visible = false;
                    PictureBoxLogo.Visible = true;
                    PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBoxLogo.LoadAsync(list[i].linkOfImage);
                }
                i++;
            }
        }
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            LabelName.Text = "Tile name: ";
            LabelAmount.Text = "Amount: ";
            LabelCategory.Text = "Category: ";
            LabelDate.Text = "Date added: ";
            LabelDate.Visible = true;
            PictureBoxLogo.Visible = false;
            TabControlPortfolio.SelectTab(0);
        }
        #endregion     
    }
}