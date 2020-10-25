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
