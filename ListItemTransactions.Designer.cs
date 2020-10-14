﻿namespace BudgetSaverApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCategoryVal = new System.Windows.Forms.Label();
            this.LabelTransactionType = new System.Windows.Forms.Label();
            this.LabelTitleVal = new System.Windows.Forms.Label();
            this.LabelAmountVal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category:";
            // 
            // LabelCategoryVal
            // 
            this.LabelCategoryVal.AutoSize = true;
            this.LabelCategoryVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LabelCategoryVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategoryVal.Location = new System.Drawing.Point(110, 38);
            this.LabelCategoryVal.Name = "LabelCategoryVal";
            this.LabelCategoryVal.Size = new System.Drawing.Size(18, 15);
            this.LabelCategoryVal.TabIndex = 23;
            this.LabelCategoryVal.Text = "- -";
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
            // LabelTitleVal
            // 
            this.LabelTitleVal.AutoSize = true;
            this.LabelTitleVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelTitleVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleVal.Location = new System.Drawing.Point(45, 16);
            this.LabelTitleVal.Name = "LabelTitleVal";
            this.LabelTitleVal.Size = new System.Drawing.Size(26, 20);
            this.LabelTitleVal.TabIndex = 20;
            this.LabelTitleVal.Text = "- -";
            // 
            // LabelAmountVal
            // 
            this.LabelAmountVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelAmountVal.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountVal.Location = new System.Drawing.Point(233, 25);
            this.LabelAmountVal.Name = "LabelAmountVal";
            this.LabelAmountVal.Size = new System.Drawing.Size(107, 28);
            this.LabelAmountVal.TabIndex = 19;
            this.LabelAmountVal.Text = "- -";
            this.LabelAmountVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 15);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelCategoryVal);
            this.Controls.Add(this.LabelTransactionType);
            this.Controls.Add(this.LabelTitleVal);
            this.Controls.Add(this.LabelAmountVal);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCategoryVal;
        private System.Windows.Forms.Label LabelTransactionType;
        private System.Windows.Forms.Label LabelTitleVal;
        private System.Windows.Forms.Label LabelAmountVal;
        private System.Windows.Forms.Button button1;
    }
}
