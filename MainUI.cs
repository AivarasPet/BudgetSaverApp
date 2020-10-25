using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BudgetSaverApp.Goals;
using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Pricing;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
using static BudgetSaverApp.Pricing.APIFetcher;

namespace BudgetSaverApp
{
    public partial class MainUI : Form
    {
        private object sender;
        UserData userData;
        ITransactionService transactionService;
        IPosessionsService possessionsService;
        IStatisticsService statisticsService;
        IGoalsService goalsService;
        public MainUI(ITransactionService transactionService, IPosessionsService posessionsService, IStatisticsService statisticsService, IGoalsService goalService)
        {
            this.possessionsService = posessionsService;
            this.transactionService = transactionService;
            this.statisticsService = statisticsService;
            this.goalsService = goalService;
            userData = new UserData(goalsService);
            InitializeComponent();
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
            APIFetcher.AllAPIsDownloaded += new System.EventHandler(ReloadSavings);
            SetUserInfo();
            SetStatsInfo(new Stats());
            CleanTab();
        }
        public delegate void MethodInvoker();
        public void ReloadSavings(object sender, System.EventArgs e)
        {
            foreach (Possession possesion in possessionsService.GetPossessionsList()) Console.WriteLine("kaina:" + possesion.ValueInDollars);
            Delegate func = new MethodInvoker(LazyLoadSavingsOnUI);
            this.Invoke(func);
            //LoadSavingsOnUI(possessionsService.GetPossessionsList());
        }

        private void LazyLoadSavingsOnUI()
        {
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            TabControlPortfolio.SelectTab(3);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelFunctions.Controls.Add(childForm);
            PanelFunctions.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Transactions
        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            FlowLayoutPanelTransactions.Controls.Clear();
            Console.WriteLine("search " + list.Count);
            foreach (Transaction t in list)
            {
                if (t == null)
                {
                    continue;
                }
                ListItemTransactions item = new ListItemTransactions
                {
                    TransactionType = t.TransactionType,
                    Title = t.Title,
                    Amount = t.Amount.ToString() + " €",
                    Category = t.Category
                };
                item.MouseDown += OnTransactionTileClicked;
                FlowLayoutPanelTransactions.Controls.Add(item);
            }
        }
        private void OnTransactionTileClicked(object sender, MouseEventArgs e)
        {
            this.sender = sender;
        }
        private void TextBoxTransactionSearchBar_TextChanged(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetListWithTitleFiltered(TextBoxTransactionSearchBar.Text));
        }

        private void ButtonAddTransactions_Click(object sender, EventArgs e)
        {
            var AddTransaction = new AddTransaction(userData, transactionService);
            AddTransaction.FormClosed += AddTransaction_FormClosed;
            OpenChildForm(AddTransaction);
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            var AddCategory = new AddCategory();
            OpenChildForm(AddCategory);
        }
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            SetDefaultStatsInfo();
        }
        #endregion

        #region Portfolio
        private void SetUserInfo()
        {
            LabelGoalName.Text = "Goal: " + userData.GoalItemName;
            LabelGoalPrice.Text = "Goal Price: " + userData.GoalItemPrice + " €";
            LabelCurrentSavings.Text = "Current savings: " + userData.CurrentSavings + " €";
            LabelMonthlySalary.Text = "Monthly salary: " + userData.MonthlySalary + " €";
            LabelProfitMonthly.Text = "Monthly profit: " + goalsService.GetProfitMonthly() + " €";
            LabelDaysToGoForGoal.Text = "Days left until the goal is reached: " + goalsService.GetGoalDaysLeft();
        }
        private void ButtonAddPortfolioValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox(userData);
            EnterInfoBoxInstance.FormClosed += EnterInfoBox_FormClosed;
            OpenChildForm(EnterInfoBoxInstance);
        }
        private void EnterInfoBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetUserInfo();
        }
        #endregion

        #region Savings
        private void ButtonAddSavings_Click(object sender, EventArgs e)
        {
            var AddSavings = new AddSavings(userData);
            AddSavings.FormClosed += AddSavings_FormClosed;
            OpenChildForm(AddSavings);
        }
        private void AddSavings_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
        }
        private void LoadSavingsOnUI(List<Possession> possessions)
        {
            FlowLayoutPanelSavings.Controls.Clear();
            foreach(Possession p in possessions)
            {
                ListSavings item = new ListSavings
                {
                    Title = p.Name,
                    Amount = p.Amount.ToString(),
                    Value = p.ValueInDollars + " $",
                    ImageUrl = p.LinkOfImage
                };
                item.MouseDown += OnSavingsTileClicked;
                FlowLayoutPanelSavings.Controls.Add(item);
            }
        }
        private void OnSavingsTileClicked(object sender, MouseEventArgs e)
        {
            this.sender = sender;
        }
        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectAll);
        }
        private void ButtonSelectStocks_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectStocks);
        }
        private void ButtonSelectCrypto_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectCrypto);
        }
        private void ButtonSelectCommodities_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectCommodities);
        }
        private void ButtonSelectMoney_Click(object sender, EventArgs e)
        {
            ChangeColor(ButtonSelectMoney);
        }
        private void ChangeColor(Button button)
        {
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Khaki;
                button.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            }
            else
            {
                button.BackColor = Color.White;
                button.FlatAppearance.BorderColor = Color.Black;
            }
        }


        #endregion

        #region Stats
        private void SetDefaultStatsInfo()
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now));
        }

        private void SetStatsInfo(Stats stats)
        {
            
            LabelStatsWeeklyTransactionAmount.Text = "Week amount of transaction: " + stats.TransactionAmount;
            LabelStatsWeeklyIncome.Text = "Weekly Income: " + stats.Income + " €";
            LabelStatsWeeklyExpenses.Text = "Weekly spent: " + stats.Expenses + " €";
            LabelStatsFrequentCategory.Text = "Most frequent category: " + stats.FrequentCategory;
            LabelStatsWeeklyBalance.Text = "Weekly balance: " + (stats.Income - stats.Expenses) + " €";

        }

        private void ButtonStatsThisWeek_Click(object sender, EventArgs e)
        {
            SetDefaultStatsInfo();
        }

        private void ButtonStatsLastWeek_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6),DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1))); 
        }

        private void ButtonStatsThisMonth_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now));
        }

        private void ButtonStatsLastMonth_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            SetStatsInfo(statisticsService.GetStatistic(first,last));
        }

        private void ButtonStatsAdvancedShow_Click(object sender, EventArgs e)
        {
            if(ButtonStatsAdvancedStats.Visible == true)
            {
                DateTimePickerStatsStart.Visible = false;
                DateTimePickerStatsEnd.Visible = false;
                ButtonStatsAdvancedStats.Visible = false;
            }
            else
            {
                DateTimePickerStatsStart.Visible = true;
                DateTimePickerStatsEnd.Visible = true;
                ButtonStatsAdvancedStats.Visible = true;
            }
        }

        private void ButtonStatsAdvancedStats_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTimePickerStatsStart.Value,DateTimePickerStatsEnd.Value));
        }

        #endregion

        #region Data
        private void ToolStripMenuItemData_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            List<Transaction> list = transactionService.GetTransactionsList();
            foreach (Control o in FlowLayoutPanelTransactions.Controls.OfType<ListItemTransactions>().ToList())
            {
                if (o.GetHashCode() == this.sender.GetHashCode())
                {
                    TabControlPortfolio.SelectTab(4);
                    LabelName.Text = "Transaction: " + list[i].Title;
                    LabelAmount.Text = "Amount: " + list[i].Amount.ToString() + " €";
                    LabelCategory.Text = "Category: " + list[i].Category;
                    LabelDate.Text = "Date added: " + (list[i].Date).ToString("yyyy/MM/dd");
                    PictureBoxLogo.Visible = false;
                    LabelDate.Visible = true;
                }
                i++;
            }
        }
        private void ToolStripMenuItemSavingsData_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            List<Possession> list = possessionsService.GetPossessionsList();
            foreach (Control o in FlowLayoutPanelSavings.Controls.OfType<ListSavings>().ToList())
            {
                if (o.GetHashCode() == this.sender.GetHashCode())
                {
                    TabControlPortfolio.SelectTab(4);
                    LabelName.Text = "Saving: " + list[i].Name;
                    LabelAmount.Text = "Amount: " + list[i].Amount;
                    LabelCategory.Text = "Total value: " + list[i].ValueInDollars + " $";
                    LabelDate.Visible = false;
                    PictureBoxLogo.Visible = true;
                    PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBoxLogo.LoadAsync(list[i].LinkOfImage);
                }
                i++;
            }
        }
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            CleanTab();
        }
        private void CleanTab()
        {
            LabelName.Text = "Tile name: ";
            LabelAmount.Text = "Amount: ";
            LabelCategory.Text = "Category: ";
            LabelDate.Text = "Date added: ";
            LabelDate.Visible = true;
            PictureBoxLogo.Visible = false;
            TabControlPortfolio.SelectTab(0);
        }




        #endregion
    }
}