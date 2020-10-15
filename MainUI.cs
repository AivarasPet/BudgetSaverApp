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
            Console.WriteLine("paejo");
            LoadSavingsOnUI(posessionsService.GetPossessionsList());
        }

        #region Transactions
        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            flowLayoutPanelTransactions.Controls.Clear();
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
                    Amount = t.Amount.ToString(),
                    Category = t.Category
                };
                flowLayoutPanelTransactions.Controls.Add(item);
            }
        }
        private void textBoxTransactionSearchBar_TextChanged(object sender, EventArgs e)
        {
            //LoadTransactionsOnUI(TransactionService.GetTransactionService().GetListWithTitleFiltered(textBoxTransactionSearchBar.Text));
        }

        private void buttonAddTransactions_Click(object sender, EventArgs e)
        {
            var AddTransaction = new AddTransaction(userData, transactionService);
            AddTransaction.FormClosed += AddTransaction_FormClosed;
            AddTransaction.ShowDialog(this);
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var AddCategory = new AddCategory();
            AddCategory.ShowDialog(this);
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
            labelGoalName.Text = "Goal: " + userData.GoalItemName;
            labelGoalPrice.Text = "Goal Price: " + userData.GoalItemPrice;
            labelCurrentSavings.Text = "Current savings: " + userData.CurrentSavings;
            labelMonthlySalary.Text = "Monthly salary: " + userData.MonthlySalary;
        }
        private void buttonAddPortfolioValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox(userData);
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            EnterInfoBoxInstance.ShowDialog(this);
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetPortfolioInfo();
        }
        #endregion

        #region Savings
        private void LoadSavingsOnUI(List<Possession> possessions)
        {
            flowLayoutPanelSavings.Controls.Clear();
            foreach(Possession p in possessions)
            {
                ListSavings item = new ListSavings
                {
                    Title = p.Name,
                    Amount = p.Amount.ToString(),
                    Value = p.ValueInDollars + " $",
                    ImageUrl = p.LinkOfImage
                };
                flowLayoutPanelSavings.Controls.Add(item);
            }
        }
        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            ChangeColor(buttonSelectAll);
        }
        private void buttonSelectStocks_Click(object sender, EventArgs e)
        {
            ChangeColor(buttonSelectStocks);
        }
        private void buttonSelectCrypto_Click(object sender, EventArgs e)
        {
            ChangeColor(buttonSelectCrypto);
        }
        private void buttonSelectCommodities_Click(object sender, EventArgs e)
        {
            ChangeColor(buttonSelectCommodities);
        }
        private void buttonSelectMoney_Click(object sender, EventArgs e)
        {
            ChangeColor(buttonSelectMoney);
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
    }
}