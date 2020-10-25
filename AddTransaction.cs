using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class AddTransaction : Form
    {
        UserData userData;
        ITransactionService transactionService;
        public AddTransaction(UserData userData, ITransactionService transactionService)
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
