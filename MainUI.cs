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
using BudgetSaverApp.Transactions;
using static BudgetSaverApp.Pricing.APIFetcher;

namespace BudgetSaverApp
{
    public partial class MainUI : Form
    {
        UserData userData;
        public MainUI()
        {
            userData = new UserData();
            InitializeComponent();
            Main main = new Main();//Don't comment, it's actually doing something
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetTransactionsList());
            LoadSavingsOnUI(PossessionsService.GetPossessionsService().GetPossessionsList());
            APIFetcher.AllAPIsDownloaded += new System.EventHandler(ReloadSavings);
            SetPortfolioInfo();
        }

        public void ReloadSavings(object sender, System.EventArgs e)
        {
            LoadSavingsOnUI(PossessionsService.GetPossessionsService().GetPossessionsList());
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
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetListWithTitleFiltered(textBoxTransactionSearchBar.Text));
        }

        private void buttonAddTransactions_Click(object sender, EventArgs e)
        {
            var AddTransaction = new AddTransaction(userData);
            AddTransaction.FormClosed += AddTransaction_FormClosed;
            AddTransaction.ShowDialog(this);
        }
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetTransactionsList());
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
                    Title = p.name,
                    Amount = p.amount.ToString(),
                    Value = p.valueInDollars + " $",
                    ImageUrl = p.linkOfImage
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
    }
}