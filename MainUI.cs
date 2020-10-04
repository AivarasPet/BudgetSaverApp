using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Transactions;

namespace BudgetSaverApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            Main main = new Main();
            customDesign();
        }
        private void customDesign()
        {
            panelStartingValues.Visible = false;
            panelTransactions.Visible = false;
            panelStartingValuesScreen.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelStartingValues.Visible == true)
            {
                panelStartingValues.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Transactions
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetTransactionsList());
        }

    
        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            flowLayoutPanelTransactions.Controls.Clear();
            Console.WriteLine("search " + list.Count);
            foreach (Transaction t in list)
            {
                ListItemTransactions item = new ListItemTransactions
                {
                    TransactionType = t.TransactionType,
                    Title = t.Title,
                    Amount = t.Amount.ToString()
                };
                flowLayoutPanelTransactions.Controls.Add(item);
            }
        }
        private void buttonAddTransactions_Click(object sender, EventArgs e)
        {
            if (panelStartingValues.Visible == true)
            {
                panelStartingValues.Visible = false;
                panelTransactions.Visible = true;
            }
            else if(panelTransactions.Visible == false)
            {
                panelTransactions.Visible = true;
            }
            else
            {
                panelTransactions.Visible = false;
            }
        }
        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionService.GetTransactionService().AddNewTransaction(AddTransactionType.Text, AddTransactionName.Text, AddTransactionAmount.Text);
        }
        private void textBoxTransactionSearchBar_TextChanged(object sender, EventArgs e)
        {
             LoadTransactionsOnUI(TransactionService.GetTransactionService().GetListWithTitleFiltered(textBoxTransactionSearchBar.Text));
        }
            #endregion

            #region Starting values
            private void buttonStartingValues_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStartingValues);
        }
        private void buttonShowStartingValues_Click(object sender, EventArgs e)
        {
            SetPortfolioInfo();
        }
        private void buttonAddStartingValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox();
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            EnterInfoBoxInstance.Show();
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetPortfolioInfo();
        }

        private void SetPortfolioInfo()
        {
            if (panelStartingValuesScreen.Visible == false)
            {
                panelStartingValuesScreen.Visible = true;
                buttonShowStartingValues.Text = "Hide values";

                labelCurrentSavings.Text = "Current savings: " + PortfolioService.currentSavings.ToString();

                labelMonthlySalary.Text = "Monthly salary: " + PortfolioService.salaryMonthly.ToString();

                labelGoalName.Text = "Goal: " + PortfolioService.mainGoalName;

                labelGoalPrice.Text = "Goal Price: " + PortfolioService.mainGoalPrice.ToString();
            }
            else
            {
                panelStartingValuesScreen.Visible = false;
                buttonShowStartingValues.Text = "Show values";
            }
        }
        #endregion

        
    }
}
