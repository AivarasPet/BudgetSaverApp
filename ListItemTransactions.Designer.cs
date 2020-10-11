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
            this.PanelTransactionType = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LabelTitleTag
            // 
            this.LabelTitleTag.AutoSize = true;
            this.LabelTitleTag.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleTag.Location = new System.Drawing.Point(62, 11);
            this.LabelTitleTag.Name = "LabelTitleTag";
            this.LabelTitleTag.Size = new System.Drawing.Size(113, 17);
            this.LabelTitleTag.TabIndex = 0;
            this.LabelTitleTag.Text = "Transaction title:";
            // 
            // LabelAmountTag
            // 
            this.LabelAmountTag.AutoSize = true;
            this.LabelAmountTag.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountTag.Location = new System.Drawing.Point(62, 41);
            this.LabelAmountTag.Name = "LabelAmountTag";
            this.LabelAmountTag.Size = new System.Drawing.Size(60, 17);
            this.LabelAmountTag.TabIndex = 1;
            this.LabelAmountTag.Text = "Amount:";
            // 
            // LabelTitleVal
            // 
            this.LabelTitleVal.AutoSize = true;
            this.LabelTitleVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleVal.Location = new System.Drawing.Point(220, 11);
            this.LabelTitleVal.Name = "LabelTitleVal";
            this.LabelTitleVal.Size = new System.Drawing.Size(22, 17);
            this.LabelTitleVal.TabIndex = 2;
            this.LabelTitleVal.Text = "- -";
            // 
            // LabelAmountVal
            // 
            this.LabelAmountVal.AutoSize = true;
            this.LabelAmountVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountVal.Location = new System.Drawing.Point(154, 41);
            this.LabelAmountVal.Name = "LabelAmountVal";
            this.LabelAmountVal.Size = new System.Drawing.Size(22, 17);
            this.LabelAmountVal.TabIndex = 3;
            this.LabelAmountVal.Text = "- -";
            // 
            // LabelTransactionType
            // 
            this.LabelTransactionType.AutoSize = true;
            this.LabelTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.LabelTransactionType.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTransactionType.Location = new System.Drawing.Point(16, 11);
            this.LabelTransactionType.Name = "LabelTransactionType";
            this.LabelTransactionType.Size = new System.Drawing.Size(40, 42);
            this.LabelTransactionType.TabIndex = 5;
            this.LabelTransactionType.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category:";
            // 
            // LabelCategoryVal
            // 
            this.LabelCategoryVal.AutoSize = true;
            this.LabelCategoryVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategoryVal.Location = new System.Drawing.Point(269, 41);
            this.LabelCategoryVal.Name = "LabelCategoryVal";
            this.LabelCategoryVal.Size = new System.Drawing.Size(22, 17);
            this.LabelCategoryVal.TabIndex = 7;
            this.LabelCategoryVal.Text = "- -";
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
            // ListItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.PanelTransactionType);
            this.Controls.Add(this.LabelCategoryVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTransactionType);
            this.Controls.Add(this.LabelAmountVal);
            this.Controls.Add(this.LabelTitleVal);
            this.Controls.Add(this.LabelAmountTag);
            this.Controls.Add(this.LabelTitleTag);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListItemTransactions";
            this.Size = new System.Drawing.Size(347, 65);
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
        private System.Windows.Forms.Panel PanelTransactionType;
    }
}
