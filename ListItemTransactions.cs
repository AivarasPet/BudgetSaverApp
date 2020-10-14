using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class ListItemTransactions : UserControl
    {

        public ListItemTransactions()
        {
            InitializeComponent();
        }

        private string _title = "", _amount = "", _category = "", _transactionType = "";


        private void ListItemTransactions_Load(object sender, EventArgs e)
        {
            LabelAmountVal.Text = _amount;
            LabelTitleVal.Text = _title;
            LabelCategoryVal.Text = _category;
            if(_transactionType.Contains("+"))
            {
                LabelTransactionType.Text = _transactionType;
                LabelTransactionType.ForeColor = Color.LimeGreen;
                PanelTransactionType.BackColor = Color.LimeGreen;
            }
            else if(_transactionType.Contains("-"))
            {
                LabelTransactionType.Text = _transactionType;
                LabelTransactionType.ForeColor = Color.Crimson;
                PanelTransactionType.BackColor = Color.Crimson;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
            get { return _title; }
            set { _amount = value; }
        }

        [Category("Custom Props")]
        public string TransactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }
    }
}
