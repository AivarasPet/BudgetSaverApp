using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BudgetSaverApp.Transactions;

namespace BudgetSaverApp
{
    public partial class AddTransaction : Form
    {
        UserData userData;
        public AddTransaction(UserData userData)
        {
            this.userData = userData;
            InitializeComponent();
            AddTransactionCategory.Items.AddRange(CategoryService.GetTransactionService().GetCategories());
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionService.GetTransactionService().AddNewTransaction(AddTransactionType.Text, AddTransactionName.Text, AddTransactionAmount.Text, AddTransactionCategory.Text);
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
