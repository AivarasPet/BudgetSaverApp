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
    public partial class ListItemTransactions : UserControl
    {
        public ListItemTransactions()
        {
            InitializeComponent();
        }

        private string _title, _amount;

        [Category("Custom Props")]
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }



        [Category("Custom Props")]
        public string Amount  
        {
            get { return _title; }
            set { _amount = value; }
        }
    }
}
