using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetSaverApp.Goals;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Possessions.Links;
using BudgetSaverApp.Pricing;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.UserData;
using Newtonsoft.Json;
using RestSharp;
using static BudgetSaverApp.Pricing.APIFetcher;

namespace BudgetSaverApp
{
    /// <summary>
    /// The main program window.
    /// </summary>
    public partial class MainUI : Form
    {
        private object sender;
        ITransactionService transactionService;
        IPosessionsService possessionsService;
        IStatisticsService statisticsService;
        IGoalsService goalsService;
        IUserDataService userDataService;
        ICategoryService categoryService;
        public MainUI(ServiceManager serviceManager)
        {
            this.possessionsService = serviceManager.posessionsService;
            this.transactionService = serviceManager.transactionService;
            this.statisticsService = serviceManager.statisticsService;
            this.goalsService = serviceManager.goalsService;
            this.userDataService = serviceManager.userDataService;
            this.categoryService = serviceManager.categoryService;
            InitializeComponent();
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
            APIFetcher.AllAPIsDownloaded += new System.EventHandler(ReloadSavings);
            SetUserInfo();
            SetDefaultStatsInfo();
            CleanTab();
            doStuff();
        }


        void doStuff()
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            List<Stats> list = new List<Stats>();
            var stat = statisticsService.GetStatistic(firstDayOfMonth, lastDayOfMonth);
            Console.WriteLine(stat.SubStatsMap["Food\r"].Expenses + " <- expenses");
            for (int x = 0; x < 12; x++)
            {
                firstDayOfMonth = firstDayOfMonth.AddMonths(-1);
                lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                stat = statisticsService.GetStatistic(firstDayOfMonth, lastDayOfMonth);
            }
            //if (list.Count>0) list.RemoveAt(list.Count-1);
            //foreach (Stats stats in list) Console.WriteLine("EXPENSES " + stats.Expenses);
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
        /// <summary>
        /// Opens a child form in the Functions tab.
        /// </summary>
        /// <param name="childForm">The form window to be opened.</param>
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
        /// <summary>
        /// Loads the transaction list on the MainUI window.
        /// </summary>
        /// <param name="list">List of transactions.</param>
        private void LoadTransactionsOnUI(List<Transaction> list)
        {
            FlowLayoutPanelTransactions.Controls.Clear();
            foreach (Transaction t in list)
            {
                if (t == null)
                {
                    continue;
                }
                ListItemTransactions item = new ListItemTransactions
                {
                    TransactType = t.TransactType,
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
            var AddTransaction = new AddTransaction(userDataService, transactionService, categoryService);
            AddTransaction.FormClosed += AddTransaction_FormClosed;
            OpenChildForm(AddTransaction);
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            var AddCategory = new AddCategory(categoryService);
            OpenChildForm(AddCategory);
        }
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
            SetUserInfo();
            SetDefaultStatsInfo();
        }

        private void DateTimePickerTransactions_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactionsOnUI(transactionService[DateTimePickerTransactions.Value.Date]);
        }
        private void ButtonTransactionRefresh_Click(object sender, EventArgs e)
        {
            RefreshTransactionsList();
        }
        private void RefreshTransactionsList()
        {
            ButtonFilterTransactions.BackColor = Color.Transparent;
            LoadTransactionsOnUI(transactionService.GetTransactionsList());
        }
        #endregion

        #region Portfolio
        /// <summary>
        /// Loads data in the Goals tab.
        /// </summary>
        private void SetUserInfo()
        {
            LabelGoalName.Text = "Goal: " + userDataService.GetGoalItemName();
            LabelGoalPrice.Text = "Goal Price: " + userDataService.GetGoalItemPrice() + " €";
            LabelCurrentSavings.Text = "Current savings: " + userDataService.GetCurrentSavings() + " €";
            LabelMonthlySalary.Text = "Monthly salary: " + userDataService.GetMonthlySalary() + " €";
            LabelProfitMonthly.Text = "Monthly profit: " + goalsService.GetProfitMonthly() + " €";
            LabelDaysToGoForGoal.Text = "Days left until the goal is reached: " + goalsService.GetGoalDaysLeft();
        }
        private void ButtonAddPortfolioValues_Click(object sender, EventArgs e)
        {
            var EnterInfoBoxInstance = new EnterInfoBox(userDataService);
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
            var AddSavings = new AddSavings(userDataService);
            AddSavings.FormClosed += AddSavings_FormClosed;
            OpenChildForm(AddSavings);
        }
        private void AddSavings_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSavingsOnUI(possessionsService.GetPossessionsList());
        }
        /// <summary>
        /// Loads the possession list in the Savings tab.
        /// </summary>
        /// <param name="possessions">List of possessions.</param>
        private void LoadSavingsOnUI(List<Possession> possessions)
        {
            FlowLayoutPanelSavings.Controls.Clear();
            foreach (Possession p in possessions)
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
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now), "This Week's ");
            ButtonStatsThisWeek.BackColor = Color.Black;
            ButtonStatsThisWeek.FlatAppearance.BorderColor = Color.Black;
        }
        /// <summary>
        /// Loads data in the Stats tab.
        /// </summary>
        /// <param name="sta
        /// 
        private void SetStatsInfo(Stats stats, string setting)
        {
            LabelStatsWeeklyTransactionAmount.Text = setting + "transaction amount: " + stats.TransactionAmount;
            LabelStatsWeeklyIncome.Text = setting + "income: " + ((double)stats.TotalIncome) + " €";
            LabelStatsWeeklyExpenses.Text = setting + "expenses: " + stats.TotalExpenses + " €";
            //LabelStatsFrequentCategory.Text = setting + "most frequent category: " + stats.FrequentCategory;
            LabelStatsWeeklyBalance.Text = setting + "balance: " + (stats.TotalIncome - stats.TotalExpenses) + " €";

        }

        private void ButtonStatsThisWeek_Click(object sender, EventArgs e)
        {
            SetDefaultStatsInfo();
            ClearButtonSelection();
            ButtonStatsThisWeek.BackColor = Color.Black;
            ButtonStatsThisWeek.FlatAppearance.BorderColor = Color.Black;
        }

        private void ButtonStatsLastWeek_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6), DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1)), "Last Week's ");
            ClearButtonSelection();
            ButtonStatsLastWeek.BackColor = Color.Black;
            ButtonStatsLastWeek.FlatAppearance.BorderColor = Color.Black;
        }

        private void ButtonStatsThisMonth_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now), "This Month's ");
            ClearButtonSelection();
            ButtonStatsThisMonth.BackColor = Color.Black;
            ButtonStatsThisMonth.FlatAppearance.BorderColor = Color.Black;
        }

        private void ButtonStatsLastMonth_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            SetStatsInfo(statisticsService.GetStatistic(first, last), "Last Month's ");
            ClearButtonSelection();
            ButtonStatsLastMonth.BackColor = Color.Black;
            ButtonStatsLastMonth.FlatAppearance.BorderColor = Color.Black;
        }

        private void ButtonStatsAdvancedShow_Click(object sender, EventArgs e)
        {
            if (ButtonStatsAdvancedStats.Visible == true)
            {
                DateTimePickerStatsStart.Visible = false;
                DateTimePickerStatsEnd.Visible = false;
                ButtonStatsAdvancedStats.Visible = false;
                ButtonStatsAdvancedShow.BackColor = Color.FromArgb(45, 45, 48);
                ButtonStatsAdvancedShow.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            }
            else
            {
                DateTimePickerStatsStart.Visible = true;
                DateTimePickerStatsEnd.Visible = true;
                ButtonStatsAdvancedStats.Visible = true;
                ButtonStatsAdvancedShow.BackColor = Color.Black;
                ButtonStatsAdvancedShow.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void ButtonStatsAdvancedStats_Click(object sender, EventArgs e)
        {
            SetStatsInfo(statisticsService.GetStatistic(DateTimePickerStatsStart.Value, DateTimePickerStatsEnd.Value), "Set Range's ");
            ClearButtonSelection();
        }

        private void ClearButtonSelection()
        {
            ButtonStatsThisWeek.BackColor = Color.FromArgb(45, 45, 48);
            ButtonStatsThisWeek.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            ButtonStatsLastWeek.BackColor = Color.FromArgb(45, 45, 48);
            ButtonStatsLastWeek.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            ButtonStatsThisMonth.BackColor = Color.FromArgb(45, 45, 48);
            ButtonStatsThisMonth.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            ButtonStatsLastMonth.BackColor = Color.FromArgb(45, 45, 48);
            ButtonStatsLastMonth.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
        }

        #endregion

        #region Data
        private void ToolStripMenuItemData_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            List<Transaction> list = transactionService.GetTransactionsList();
            foreach (Control o in FlowLayoutPanelTransactions.Controls.OfType<ListItemTransactions>().ToList())
            {
                if (this.sender != null && o.GetHashCode() == this.sender.GetHashCode())
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

        #region PopularTransactions

        private void ButtonFilterTransactions_Click(object sender, EventArgs e)
        {
            if (ButtonFilterTransactions.BackColor == Color.Transparent)
            {
                ButtonFilterTransactions.BackColor = Color.LightGray;
                LoadPopularTransactionsOnUI();
            }
            else
            {
                ButtonFilterTransactions.BackColor = Color.Transparent;
                RefreshTransactionsList();
            }
        }
        private void LoadPopularTransactionsOnUI()
        {
            FlowLayoutPanelTransactions.Controls.Clear();
            foreach (Tuple<Transaction, int> tuple in transactionService.GetPopularTransactionTuples())
            {
                if (tuple == null)
                {
                    continue;
                }
                PopularTransactions item = new PopularTransactions
                {
                    Title = tuple.Item1.Title,
                    Amount = tuple.Item1.Amount.ToString() + " €",
                    Quantity = "Transaction was used " + tuple.Item2.ToString() + " times",
                    TransactType = tuple.Item1.TransactType
                };
                FlowLayoutPanelTransactions.Controls.Add(item);
            }
        }
        #endregion
    }
}