namespace BudgetSaverApp
{
    partial class PopularTransactions
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
            this.LabelTitleValue = new System.Windows.Forms.Label();
            this.LabelQuantityValue = new System.Windows.Forms.Label();
            this.PanelTransactionType = new System.Windows.Forms.Panel();
            this.LabelAmountValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitleValue
            // 
            this.LabelTitleValue.AutoSize = true;
            this.LabelTitleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelTitleValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitleValue.Location = new System.Drawing.Point(38, 22);
            this.LabelTitleValue.Name = "LabelTitleValue";
            this.LabelTitleValue.Size = new System.Drawing.Size(26, 20);
            this.LabelTitleValue.TabIndex = 21;
            this.LabelTitleValue.Text = "- -";
            // 
            // LabelQuantityValue
            // 
            this.LabelQuantityValue.AutoSize = true;
            this.LabelQuantityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelQuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelQuantityValue.Location = new System.Drawing.Point(302, 22);
            this.LabelQuantityValue.Name = "LabelQuantityValue";
            this.LabelQuantityValue.Size = new System.Drawing.Size(26, 20);
            this.LabelQuantityValue.TabIndex = 23;
            this.LabelQuantityValue.Text = "- -";
            // 
            // PanelTransactionType
            // 
            this.PanelTransactionType.BackColor = System.Drawing.Color.LimeGreen;
            this.PanelTransactionType.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTransactionType.Location = new System.Drawing.Point(0, 0);
            this.PanelTransactionType.Name = "PanelTransactionType";
            this.PanelTransactionType.Size = new System.Drawing.Size(5, 65);
            this.PanelTransactionType.TabIndex = 24;
            // 
            // LabelAmountValue
            // 
            this.LabelAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelAmountValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAmountValue.Location = new System.Drawing.Point(156, 18);
            this.LabelAmountValue.Name = "LabelAmountValue";
            this.LabelAmountValue.Size = new System.Drawing.Size(107, 28);
            this.LabelAmountValue.TabIndex = 25;
            this.LabelAmountValue.Text = "- -";
            this.LabelAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PopularTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.LabelAmountValue);
            this.Controls.Add(this.PanelTransactionType);
            this.Controls.Add(this.LabelQuantityValue);
            this.Controls.Add(this.LabelTitleValue);
            this.Name = "PopularTransactions";
            this.Size = new System.Drawing.Size(347, 65);
            this.Load += new System.EventHandler(this.PopularTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitleValue;
        private System.Windows.Forms.Label LabelQuantityValue;
        private System.Windows.Forms.Panel PanelTransactionType;
        private System.Windows.Forms.Label LabelAmountValue;
    }
}
