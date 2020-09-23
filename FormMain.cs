using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadTransactionsList();
        }

        void LoadTransactionsList()
        {
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"\TextFiles\Transactions.txt");
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
    }
}
