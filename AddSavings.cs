using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class AddSavings : Form
    {
        public AddSavings(UserData userData)
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
