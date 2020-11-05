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
        [Flags]
        enum Type
        {
            Income = 0,
            Expenses = 1
        }
        public AddTransaction(IUserDataService userData, ITransactionService transactionService)
        {
            this.transactionService = transactionService; 
            this.userData = userData;
            InitializeComponent();
            ComboBoxTransactionCategory.Items.AddRange(CategoryService.GetCategoryService().GetCategories());
        }
        private void AddTransaction_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Type)))
            {
                ComboBoxTransactionType.Items.Add(item);
            }
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            if(ComboBoxTransactionCategory.Text == "")
            {
                transactionService.AddNewTransaction(transactionType: ComboBoxTransactionType.Text, transactionName: TextBoxTitleName.Text, transactionAmount: TextBoxTransactionAmount.Text);
            }
            else
            {
                transactionService.AddNewTransaction(category: ComboBoxTransactionCategory.Text, transactionType: ComboBoxTransactionType.Text, transactionName: TextBoxTitleName.Text, transactionAmount: TextBoxTransactionAmount.Text);
            }
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
