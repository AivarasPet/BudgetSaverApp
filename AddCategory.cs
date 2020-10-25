using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService.GetCategoryService().AddCategory(TextBoxAddCategory.Text);
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
