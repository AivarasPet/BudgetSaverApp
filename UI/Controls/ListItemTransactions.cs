using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static BudgetSaverApp.Transactions.Transaction;

namespace BudgetSaverApp
{
    public partial class ListItemTransactions : UserControl
    {
        public ListItemTransactions()
        {
            InitializeComponent();
        }

        private string _title = "", _amount = "", _category = "";
        TransactionType _transactType;

        private void ListItemTransactions_Load(object sender, EventArgs e)
        {
            LabelAmountValue.Text = _amount;
            LabelTitleValue.Text = _title;
            LabelCategoryValue.Text = _category;
            if(_transactType == Transactions.Transaction.TransactionType.INCOME)
            {
                LabelTransactionType.Text = "+";
                LabelTransactionType.ForeColor = Color.LimeGreen;
                PanelTransactionType.BackColor = Color.LimeGreen;
            }
            else if(_transactType == Transactions.Transaction.TransactionType.EXPENSES)
            {
                LabelTransactionType.Text = "-";
                LabelTransactionType.ForeColor = Color.Crimson;
                PanelTransactionType.BackColor = Color.Crimson;
            }
        }

        [Category("Custom Props")]
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }

        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [Category("Custom Props")]
        public string Amount  
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [Category("Custom Props")]
        public TransactionType TransactType
        {
            get { return _transactType; }
            set { _transactType = value; }
        }
    }
}
