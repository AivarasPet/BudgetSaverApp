namespace BudgetSaverApp
{
    partial class ListItemTransactions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTransactionType = new System.Windows.Forms.Panel();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCategoryValue = new System.Windows.Forms.Label();
            this.LabelTransactionType = new System.Windows.Forms.Label();
            this.LabelTitleValue = new System.Windows.Forms.Label();
            this.LabelAmountValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelTransactionType
            // 
            this.PanelTransactionType.BackColor = System.Drawing.Color.LimeGreen;
            this.PanelTransactionType.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTransactionType.Location = new System.Drawing.Point(0, 0);
            this.PanelTransactionType.Name = "PanelTransactionType";
            this.PanelTransactionType.Size = new System.Drawing.Size(5, 65);
            this.PanelTransactionType.TabIndex = 18;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LabelCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategory.Location = new System.Drawing.Point(46, 38);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(58, 15);
            this.LabelCategory.TabIndex = 22;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelCategoryValue
            // 
            this.LabelCategoryValue.AutoSize = true;
            this.LabelCategoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LabelCategoryValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategoryValue.Location = new System.Drawing.Point(110, 38);
            this.LabelCategoryValue.Name = "LabelCategoryValue";
            this.LabelCategoryValue.Size = new System.Drawing.Size(18, 15);
            this.LabelCategoryValue.TabIndex = 23;
            this.LabelCategoryValue.Text = "- -";
            // 
            // LabelTransactionType
            // 
            this.LabelTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.LabelTransactionType.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTransactionType.Location = new System.Drawing.Point(7, 11);
            this.LabelTransactionType.Name = "LabelTransactionType";
            this.LabelTransactionType.Size = new System.Drawing.Size(40, 42);
            this.LabelTransactionType.TabIndex = 21;
            this.LabelTransactionType.Text = "+";
            this.LabelTransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTitleValue
            // 
            this.LabelTitleValue.AutoSize = true;
            this.LabelTitleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelTitleValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleValue.Location = new System.Drawing.Point(45, 16);
            this.LabelTitleValue.Name = "LabelTitleValue";
            this.LabelTitleValue.Size = new System.Drawing.Size(26, 20);
            this.LabelTitleValue.TabIndex = 20;
            this.LabelTitleValue.Text = "- -";
            // 
            // LabelAmountValue
            // 
            this.LabelAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelAmountValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountValue.Location = new System.Drawing.Point(233, 25);
            this.LabelAmountValue.Name = "LabelAmountValue";
            this.LabelAmountValue.Size = new System.Drawing.Size(107, 28);
            this.LabelAmountValue.TabIndex = 19;
            this.LabelAmountValue.Text = "- -";
            this.LabelAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelCategoryValue);
            this.Controls.Add(this.LabelTransactionType);
            this.Controls.Add(this.LabelTitleValue);
            this.Controls.Add(this.LabelAmountValue);
            this.Controls.Add(this.PanelTransactionType);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListItemTransactions";
            this.Size = new System.Drawing.Size(347, 65);
            this.Load += new System.EventHandler(this.ListItemTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelTransactionType;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelCategoryValue;
        private System.Windows.Forms.Label LabelTransactionType;
        private System.Windows.Forms.Label LabelTitleValue;
        private System.Windows.Forms.Label LabelAmountValue;
    }
}
