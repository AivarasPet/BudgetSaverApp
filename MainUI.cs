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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            panelStartingValues.Visible = false;
            panelTransactions.Visible = false;
            panelStartingValuesScreen.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelStartingValues.Visible == true)
            {
                panelStartingValues.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Transactions
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsList();
        }
        void LoadTransactionsList()
        {
            flowLayoutPanelTransactions.Controls.Clear();
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (data == null) return;
            for (int x = 0; x < data.Length / 4; x++)
            {
                Console.WriteLine(data[4 * x] + x);
                listItems[x] = new ListItemTransactions
                {
                    TransactionType = data[4 * x],
                    Title = data[x * 4 + 1],
                    Amount = data[x * 4 + 2]
                };
                flowLayoutPanelTransactions.Controls.Add(listItems[x]);
            }

        }
        private void buttonAddTransactions_Click(object sender, EventArgs e)
        {
            if (panelStartingValues.Visible == true)
            {
                panelStartingValues.Visible = false;
                panelTransactions.Visible = true;
            }
            else if(panelTransactions.Visible == false)
            {
                panelTransactions.Visible = true;
            }
            else
            {
                panelTransactions.Visible = false;
            }
        }
        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (AddTransactionType.Text != "" &&
                AddTransactionName.Text != "" &&
                AddTransactionAmount.Text != "")
            {
                w.WriteLine(AddTransactionType.Text);
                w.WriteLine(AddTransactionName.Text);
                w.WriteLine(AddTransactionAmount.Text);
                w.WriteLine();
                w.Close();
                LoadTransactionsList();
            }
        }
        #endregion

        #region Starting values
        private void buttonStartingValues_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStartingValues);
        }
        private void buttonShowStartingValues_Click(object sender, EventArgs e)
        {
            if (panelStartingValuesScreen.Visible == false)
            {
                panelStartingValuesScreen.Visible = true;
                buttonShowStartingValues.Text = "Hide values";
                StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
                String line = reader.ReadLine();
                if (line != null)
                {
                    labelCurrentSavings.Text = "Current savings: " + line;
                }
                line = reader.ReadLine();
                if (line != null)
                {
                    labelMonthlySalary.Text = "Monthly salary: " + line;
                }
                line = reader.ReadLine();
                if (line != null)
                {
                    labelGoalName.Text = "Goal: " + line;
                }
                line = reader.ReadLine();
                if (line != null)
                {
                    labelGoalPrice.Text = "Goal Price: " + line;
                }
                reader.Close();
            }
            else
            {
                panelStartingValuesScreen.Visible = false;
                buttonShowStartingValues.Text = "Show values";
            }
        }
        private void buttonAddStartingValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox();
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            EnterInfoBoxInstance.Show();
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            String line = reader.ReadLine();
            if (line != null)
            {
                labelCurrentSavings.Text = "Current savings: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                labelMonthlySalary.Text = "Monthly salary: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                labelGoalName.Text = "Goal: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                labelGoalPrice.Text = "Goal Price: " + line;
            }

            reader.Close();
        }
        #endregion

    }
}
