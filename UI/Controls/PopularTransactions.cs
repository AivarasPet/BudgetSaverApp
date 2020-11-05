using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetSaverApp.Transactions;

namespace BudgetSaverApp
{
    public partial class PopularTransactions : UserControl
    {
        public PopularTransactions()
        {
            InitializeComponent();
        }

        private string _title = "", _amount = "", _quantity = "";
        Transaction.TransactionType _transactType;

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
            if (_transactType == Transaction.TransactionType.INCOME)
            {
                PanelTransactionType.BackColor = Color.LimeGreen;
            }
            else if (_transactType == Transaction.TransactionType.EXPENSES)
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
        public Transaction.TransactionType TransactType
        {
            get { return _transactType; }
            set { _transactType = value; }
        }
    }
}
