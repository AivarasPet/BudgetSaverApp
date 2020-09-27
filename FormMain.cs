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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            String line = reader.ReadLine();
            if (line != null)
            {
                CurrentSavingsLabel.Text = "Current savings: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                MonthlySalaryLabel.Text = "Monthly salary: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                goalLabel.Text = "Goal: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                goalPriceLabel.Text = "Goal Price: " + line;
            }
            reader.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadTransactionsList();
        }

        void LoadTransactionsList()
        {
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (data == null) return;
            for (int x = 0; x < data.Length/4; x++)
            {
                Console.WriteLine(data[4*x] + x);
                listItems[x] = new ListItemTransactions
                {
                    TransactionType = data[4 * x],
                    Title = data[x * 4 + 1],
                    Amount = data[x * 4 + 2]
                };
                FlowLayoutTransactions.Controls.Add(listItems[x]);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox();
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            EnterInfoBoxInstance.Show();
        }

        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            String line = reader.ReadLine();
            if(line != null)
            {
                CurrentSavingsLabel.Text = "Current savings: " + line;
            }
            line = reader.ReadLine();
            if(line != null)
            {
                MonthlySalaryLabel.Text = "Monthly salary: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                goalLabel.Text = "Goal: " + line;
            }
            line = reader.ReadLine();
            if (line != null)
            {
                goalPriceLabel.Text = "Goal Price: " + line;
            }

            reader.Close();
        }

        private void FlowLayoutTransactions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
