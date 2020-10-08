using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
