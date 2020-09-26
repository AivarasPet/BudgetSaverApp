using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class EnterInfoBox : Form
    {
        public EnterInfoBox()
        {
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
            Double currentSavings = Convert.ToDouble(TextBoxSavingsEnter.Text);
            Double monthlySalary = Convert.ToDouble(TextBoxMonthlySalary.Text);
            String goalItemName = Convert.ToString(textBoxGoalItemName.Text);
            Double goalItemPrice = Convert.ToDouble(textBoxGoalItemPrice.Text);
            StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            writer.WriteLine(currentSavings);
            writer.WriteLine(monthlySalary);
            writer.WriteLine(goalItemName);
            writer.WriteLine(goalItemPrice);
            writer.Close();
            Close();
        }

        private void InfoBoxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
