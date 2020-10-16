using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class EnterInfoBox : Form
    {

        UserData userData;
        public EnterInfoBox(UserData userData)
        {
            this.userData = userData;
            InitializeComponent();
        }

        private void TextBoxSavingsEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBoxMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBoxGoalItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBoxGoalItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InfoBoxConfirm_Click(object sender, EventArgs e)
        {
            // Checks whether input values are numbers
            float price, savings, salary;
            bool valuesAreNumbers = float.TryParse(TextBoxGoalItemPrice.Text, out price) &
                                    float.TryParse(TextBoxSavings.Text, out savings) &
                                    float.TryParse(TextBoxMonthlySalary.Text, out salary);
            if (!valuesAreNumbers)
                return;
            // Writes input values into UserData.txt
            userData.SetAll(TextBoxGoalItemName.Text, price, savings, salary);                
            userData.SaveToFile();
            Close();
        }

        private void InfoBoxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
