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
    public partial class ListSavings : UserControl
    {
        public ListSavings()
        {
            InitializeComponent();
        }
        private string _title = "", _amount = "", _value = "";
        
        private void ListSavings_Load(object sender, EventArgs e)
        {
            LabelTitleInput.Text = _title;
            LabelAmountInput.Text = _amount;            
            LabelValueInput.Text = _value;
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Category("Custom Props")]
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [Category("Custom Props")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
