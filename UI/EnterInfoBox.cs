using BudgetSaverApp.UserData;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BudgetSaverApp
{
    public partial class EnterInfoBox : Form
    {

        IUserDataService userData;
        public EnterInfoBox(IUserDataService userData)
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
            string numberPatternRegex = @"(^\d*\.?\d*[1-9]+\d*$)|(^[1-9]+\d*\.\d*$)";
            string isPriceValid = "Price is not a number".ErrorMessageIfNotMatchesRegex(numberPatternRegex, TextBoxGoalItemPrice.Text);
            string isSavingsValid = "Savings has to be a number".ErrorMessageIfNotMatchesRegex(numberPatternRegex, TextBoxSavings.Text);
            string isSalaryValid = "Salary has to be a number".ErrorMessageIfNotMatchesRegex(numberPatternRegex, TextBoxMonthlySalary.Text);
            if (isPriceValid != ""  isSavingsValid != ""  isSalaryValid != "")
            {
                MessageBox.Show(isPriceValid + isSavingsValid + isSalaryValid);
                return;
            }
            // Writes input values into UserData.txt   
            userData.SetAll(TextBoxGoalItemName.Text, float.Parse(TextBoxGoalItemPrice.Text), float.Parse(TextBoxSavings.Text), float.Parse(TextBoxMonthlySalary.Text));
            userData.SaveToFile();
            Close();
        }

        private void InfoBoxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxGoalItemPrice_Click(object sender, EventArgs e)
        {
            if (TextBoxGoalItemPrice.Text == "Wrong input. Please enter positive numbers") { TextBoxGoalItemPrice.Text = ""; }
        }
        private void TextBoxSavings_Click(object sender, EventArgs e)
        {
            if (TextBoxSavings.Text == "Wrong input. Please enter positive numbers") { TextBoxSavings.Text = ""; }
        }

        private void TextBoxMonthlySalary_Click(object sender, EventArgs e)
        {
            if (TextBoxMonthlySalary.Text == "Wrong input. Please enter positive numbers") { TextBoxMonthlySalary.Text = ""; }
        }
    }
}
