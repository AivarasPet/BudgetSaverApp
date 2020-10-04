﻿using System;
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
    public partial class ListItemTransactions : UserControl
    {

        public ListItemTransactions()
        {
            InitializeComponent();
        }

        private string _title = "", _amount = "", _transactionType = "";


        private void ListItemTransactions_Load(object sender, EventArgs e)
        {
            LabelAmountVal.Text = _amount;
            LabelTitleVal.Text = _title;
            if(_transactionType.Contains("+"))
            {
                LabelTransactionType.Text = _transactionType;
                LabelTransactionType.ForeColor = Color.LimeGreen;
            }
            else if(_transactionType.Contains("-"))
            {
                LabelTransactionType.Text = _transactionType;
                LabelTransactionType.ForeColor = Color.Crimson;
            }
           
        }

        [Category("Custom Props")]
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }

        private void LabelTitleTag_Click(object sender, EventArgs e)
        {

        }

        private void LabelTitleVal_Click(object sender, EventArgs e)
        {

        }

        private void LabelAmountVal_Click(object sender, EventArgs e)
        {

        }

        private void LabelAmountTag_Click(object sender, EventArgs e)
        {

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
