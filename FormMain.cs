using BudgetSaverApp.Transactions;
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
using BudgetSaverApp.Transactions;
using System.Collections;


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
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetTransactionsList());
        }

        void LoadTransactionsList()
        {
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");

            TransactionService instance = TransactionService.GetTransactionService();
            instance.InitListByStringArray(data);
           
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

        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            FlowLayoutTransactions.Controls.Clear();
            Console.WriteLine("search " + list.Count);
            foreach(Transaction t in list)
            {
                ListItemTransactions item = new ListItemTransactions
                {
                    TransactionType = t.TransactionType,
                    Title = t.Title,
                    Amount = t.Amount.ToString()
                };
                FlowLayoutTransactions.Controls.Add(item);
            }
        }

        private void FlowLayoutTransactions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTransactionSearchBar_TextChanged(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(TransactionService.GetTransactionService().GetListWithTitleFiltered(textBoxTransactionSearchBar.Text));
        }
    }
}
