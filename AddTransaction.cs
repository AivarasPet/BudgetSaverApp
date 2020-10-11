using System;
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
