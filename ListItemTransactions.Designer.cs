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
            this.LabelTitleTag = new System.Windows.Forms.Label();
            this.LabelAmountTag = new System.Windows.Forms.Label();
            this.LabelTitleVal = new System.Windows.Forms.Label();
            this.LabelAmountVal = new System.Windows.Forms.Label();
            this.LabelTransactionType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCategoryVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitleTag
            // 
            this.LabelTitleTag.AutoSize = true;
            this.LabelTitleTag.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleTag.Location = new System.Drawing.Point(60, 9);
            this.LabelTitleTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitleTag.Name = "LabelTitleTag";
            this.LabelTitleTag.Size = new System.Drawing.Size(85, 13);
            this.LabelTitleTag.TabIndex = 0;
            this.LabelTitleTag.Text = "Transaction title:";
            this.LabelTitleTag.Click += new System.EventHandler(this.LabelTitleTag_Click);
            // 
            // LabelAmountTag
            // 
            this.LabelAmountTag.AutoSize = true;
            this.LabelAmountTag.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountTag.Location = new System.Drawing.Point(60, 33);
            this.LabelAmountTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAmountTag.Name = "LabelAmountTag";
            this.LabelAmountTag.Size = new System.Drawing.Size(46, 13);
            this.LabelAmountTag.TabIndex = 1;
            this.LabelAmountTag.Text = "Amount:";
            this.LabelAmountTag.Click += new System.EventHandler(this.LabelAmountTag_Click);
            // 
            // LabelTitleVal
            // 
            this.LabelTitleVal.AutoSize = true;
            this.LabelTitleVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleVal.Location = new System.Drawing.Point(188, 9);
            this.LabelTitleVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitleVal.Name = "LabelTitleVal";
            this.LabelTitleVal.Size = new System.Drawing.Size(16, 13);
            this.LabelTitleVal.TabIndex = 2;
            this.LabelTitleVal.Text = "- -";
            this.LabelTitleVal.Click += new System.EventHandler(this.LabelTitleVal_Click);
            // 
            // LabelAmountVal
            // 
            this.LabelAmountVal.AutoSize = true;
            this.LabelAmountVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountVal.Location = new System.Drawing.Point(129, 33);
            this.LabelAmountVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAmountVal.Name = "LabelAmountVal";
            this.LabelAmountVal.Size = new System.Drawing.Size(16, 13);
            this.LabelAmountVal.TabIndex = 3;
            this.LabelAmountVal.Text = "- -";
            this.LabelAmountVal.Click += new System.EventHandler(this.LabelAmountVal_Click);
            // 
            // LabelTransactionType
            // 
            this.LabelTransactionType.AutoSize = true;
            this.LabelTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.LabelTransactionType.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTransactionType.Location = new System.Drawing.Point(20, 9);
            this.LabelTransactionType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTransactionType.Name = "LabelTransactionType";
            this.LabelTransactionType.Size = new System.Drawing.Size(32, 36);
            this.LabelTransactionType.TabIndex = 5;
            this.LabelTransactionType.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category:";
            // 
            // LabelCategoryVal
            // 
            this.LabelCategoryVal.AutoSize = true;
            this.LabelCategoryVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategoryVal.Location = new System.Drawing.Point(214, 33);
            this.LabelCategoryVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCategoryVal.Name = "LabelCategoryVal";
            this.LabelCategoryVal.Size = new System.Drawing.Size(16, 13);
            this.LabelCategoryVal.TabIndex = 7;
            this.LabelCategoryVal.Text = "- -";
            // 
            // ListItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LabelCategoryVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTransactionType);
            this.Controls.Add(this.LabelAmountVal);
            this.Controls.Add(this.LabelTitleVal);
            this.Controls.Add(this.LabelAmountTag);
            this.Controls.Add(this.LabelTitleTag);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListItemTransactions";
            this.Size = new System.Drawing.Size(323, 53);
            this.Load += new System.EventHandler(this.ListItemTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitleTag;
        private System.Windows.Forms.Label LabelAmountTag;
        private System.Windows.Forms.Label LabelTitleVal;
        private System.Windows.Forms.Label LabelAmountVal;
        private System.Windows.Forms.Label LabelTransactionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCategoryVal;
    }
}
