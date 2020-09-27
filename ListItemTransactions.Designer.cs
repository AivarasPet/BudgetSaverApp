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
            this.SuspendLayout();
            // 
            // LabelTitleTag
            // 
            this.LabelTitleTag.AutoSize = true;
            this.LabelTitleTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelTitleTag.Location = new System.Drawing.Point(80, 11);
            this.LabelTitleTag.Name = "LabelTitleTag";
            this.LabelTitleTag.Size = new System.Drawing.Size(113, 17);
            this.LabelTitleTag.TabIndex = 0;
            this.LabelTitleTag.Text = "Transaction title:";
            // 
            // LabelAmountTag
            // 
            this.LabelAmountTag.AutoSize = true;
            this.LabelAmountTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelAmountTag.Location = new System.Drawing.Point(133, 41);
            this.LabelAmountTag.Name = "LabelAmountTag";
            this.LabelAmountTag.Size = new System.Drawing.Size(60, 17);
            this.LabelAmountTag.TabIndex = 1;
            this.LabelAmountTag.Text = "Amount:";
            // 
            // LabelTitleVal
            // 
            this.LabelTitleVal.AutoSize = true;
            this.LabelTitleVal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelTitleVal.Location = new System.Drawing.Point(250, 11);
            this.LabelTitleVal.Name = "LabelTitleVal";
            this.LabelTitleVal.Size = new System.Drawing.Size(22, 17);
            this.LabelTitleVal.TabIndex = 2;
            this.LabelTitleVal.Text = "- -";
            // 
            // LabelAmountVal
            // 
            this.LabelAmountVal.AutoSize = true;
            this.LabelAmountVal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelAmountVal.Location = new System.Drawing.Point(250, 41);
            this.LabelAmountVal.Name = "LabelAmountVal";
            this.LabelAmountVal.Size = new System.Drawing.Size(22, 17);
            this.LabelAmountVal.TabIndex = 3;
            this.LabelAmountVal.Text = "- -";
            // 
            // LabelTransactionType
            // 
            this.LabelTransactionType.AutoSize = true;
            this.LabelTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.LabelTransactionType.ForeColor = System.Drawing.Color.Green;
            this.LabelTransactionType.Location = new System.Drawing.Point(27, 11);
            this.LabelTransactionType.Name = "LabelTransactionType";
            this.LabelTransactionType.Size = new System.Drawing.Size(40, 42);
            this.LabelTransactionType.TabIndex = 5;
            this.LabelTransactionType.Text = "+";
            // 
            // ListItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LabelTransactionType);
            this.Controls.Add(this.LabelAmountVal);
            this.Controls.Add(this.LabelTitleVal);
            this.Controls.Add(this.LabelAmountTag);
            this.Controls.Add(this.LabelTitleTag);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Name = "ListItemTransactions";
            this.Size = new System.Drawing.Size(431, 65);
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
    }
}
