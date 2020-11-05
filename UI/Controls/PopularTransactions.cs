using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class PopularTransactions : UserControl
    {
        public PopularTransactions()
        {
            InitializeComponent();
        }

        private string _title = "", _amount = "", _quantity = "", _transactionType = "";

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private void PopularTransactions_Load(object sender, EventArgs e)
        {
            LabelTitleValue.Text = _title;
            LabelAmountValue.Text = _amount;
            LabelQuantityValue.Text = _quantity;
            if (_transactionType.Contains("+"))
            {
                PanelTransactionType.BackColor = Color.LimeGreen;
            }
            else if (_transactionType.Contains("-"))
            {
                PanelTransactionType.BackColor = Color.Crimson;
            }
        }

        [Category("Custom Props")]
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [Category("Custom Props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [Category("Custom Props")]
        public string TransactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }
    }
}
