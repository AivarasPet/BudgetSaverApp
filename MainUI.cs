﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
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
            SetPortfolioInfo();
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
            AddTransaction.Show();
        }
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetTransactionsList());
        }
        #endregion

        #region Portfolio
        private void buttonAddPortfolioValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox(userData);
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            EnterInfoBoxInstance.Show();
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetPortfolioInfo();
        }
        private void SetPortfolioInfo()
        {
            labelCurrentSavings.Text = "Current savings: " + userData.CurrentSavings;
            labelMonthlySalary.Text = "Monthly salary: " + userData.MonthlySalary;
            labelGoalName.Text = "Goal: " + userData.GoalItemName;
            labelGoalPrice.Text = "Goal Price: " + userData.GoalItemPrice;
        }
        #endregion
    }
}