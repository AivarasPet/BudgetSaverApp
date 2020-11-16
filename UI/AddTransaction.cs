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

        public AddTransaction(IUserDataService userData, ITransactionService transactionService, ICategoryService categoryService)
        {
            this.transactionService = transactionService;
            this.userData = userData;
            InitializeComponent();
            ComboBoxTransactionCategory.Items.AddRange(categoryService.GetCategories());
        }
        private void AddTransaction_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Transaction.TransactionType)))
            {
                ComboBoxTransactionType.Items.Add(item);
            }
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            Transaction.TransactionType transactType = (float.Parse(TextBoxTransactionAmount.Text) >= 0) ? Transaction.TransactionType.INCOME : Transaction.TransactionType.EXPENSES;
            if (ComboBoxTransactionCategory.Text == "")
            {
                transactionService.AddNewTransaction(transactType: transactType, transactionName: TextBoxTitleName.Text, transactionAmount: TextBoxTransactionAmount.Text);
            }
            else
            {
                transactionService.AddNewTransaction(category: ComboBoxTransactionCategory.Text, transactType: transactType, transactionName: TextBoxTitleName.Text, transactionAmount: TextBoxTransactionAmount.Text);
            }
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
