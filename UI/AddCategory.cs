﻿using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    public partial class AddCategory : Form
    {
        ICategoryService categoryService;
        public AddCategory(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            InitializeComponent();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            categoryService.AddCategory(TextBoxAddCategory.Text);
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
