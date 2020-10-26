using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.UserData;

namespace BudgetSaverApp
{
    public partial class AddTransaction : Form
    {
        IUserDataService userData;
        ITransactionService transactionService;
        public AddTransaction(IUserDataService userData, ITransactionService transactionService)
        {
            this.transactionService = transactionService; 
            this.userData = userData;
            InitializeComponent();
            ComboBoxTransactionCategory.Items.AddRange(CategoryService.GetCategoryService().GetCategories());
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            transactionService.AddNewTransaction(ComboBoxTransactionType.Text, TextBoxTitleName.Text, TextBoxTransactionAmount.Text, ComboBoxTransactionCategory.Text);               
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
