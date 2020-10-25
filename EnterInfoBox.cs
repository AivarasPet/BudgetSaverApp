using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            string numberPattern = @"(^\d*\.?\d*[1-9]+\d*$)|(^[1-9]+\d*\.\d*$)";
            bool isPriceValid = Regex.IsMatch(TextBoxGoalItemPrice.Text, numberPattern);
            bool isSavingsValid = Regex.IsMatch(TextBoxSavings.Text, numberPattern);
            bool isSalaryValid = Regex.IsMatch(TextBoxMonthlySalary.Text, numberPattern);
            //if (!isPriceValid) { return; }
            //if (!isSavingsValid) { return; }
            //if (!isSalaryValid) { return; }
            if (!isPriceValid || !isSavingsValid || !isSalaryValid) { return; }
            // Writes input values into UserData.txt   
            userData.SetAll(TextBoxGoalItemName.Text, float.Parse(TextBoxGoalItemPrice.Text), float.Parse(TextBoxSavings.Text), float.Parse(TextBoxMonthlySalary.Text));
            userData.SaveToFile();
            Close();
        }

        private void InfoBoxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
