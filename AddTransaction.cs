using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BudgetSaverApp.Transactions;

namespace BudgetSaverApp
{
    public partial class AddTransaction : Form
    {
        UserData userData;
        ITransactionService transactionService;
        public AddTransaction(UserData userData, ITransactionService transactionService)
        {
            this.userData = userData;
            InitializeComponent();
            ComboBoxTransactionCategory.Items.AddRange(CategoryService.GetCategoryService().GetCategories());
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            //TransactionService.GetTransactionService().AddNewTransaction(ComboBoxTransactionType.Text, TextBoxTitleName.Text, TextBoxTransactionAmount.Text, ComboBoxTransactionCategory.Text);
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
