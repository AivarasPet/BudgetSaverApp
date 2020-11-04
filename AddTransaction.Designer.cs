namespace BudgetSaverApp
{
    partial class AddTransaction
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxTransactionCategory = new System.Windows.Forms.ComboBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.ButtonAddTransaction = new System.Windows.Forms.Button();
            this.TextBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ComboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.TextBoxTitleName = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxTransactionCategory
            // 
            this.ComboBoxTransactionCategory.BackColor = System.Drawing.Color.White;
            this.ComboBoxTransactionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTransactionCategory.FormattingEnabled = true;
            this.ComboBoxTransactionCategory.Location = new System.Drawing.Point(361, 82);
            this.ComboBoxTransactionCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxTransactionCategory.Name = "ComboBoxTransactionCategory";
            this.ComboBoxTransactionCategory.Size = new System.Drawing.Size(161, 24);
            this.ComboBoxTransactionCategory.TabIndex = 29;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.ForeColor = System.Drawing.Color.White;
            this.LabelCategory.Location = new System.Drawing.Point(356, 48);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(98, 25);
            this.LabelCategory.TabIndex = 28;
            this.LabelCategory.Text = "Category:";
            // 
            // ButtonAddTransaction
            // 
            this.ButtonAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonAddTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonAddTransaction.FlatAppearance.BorderSize = 0;
            this.ButtonAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTransaction.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTransaction.Location = new System.Drawing.Point(34, 170);
            this.ButtonAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddTransaction.Name = "ButtonAddTransaction";
            this.ButtonAddTransaction.Size = new System.Drawing.Size(175, 47);
            this.ButtonAddTransaction.TabIndex = 27;
            this.ButtonAddTransaction.Text = "Add transaction";
            this.ButtonAddTransaction.UseVisualStyleBackColor = false;
            this.ButtonAddTransaction.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // TextBoxTransactionAmount
            // 
            this.TextBoxTransactionAmount.BackColor = System.Drawing.Color.White;
            this.TextBoxTransactionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTransactionAmount.Location = new System.Drawing.Point(272, 83);
            this.TextBoxTransactionAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTransactionAmount.Name = "TextBoxTransactionAmount";
            this.TextBoxTransactionAmount.Size = new System.Drawing.Size(81, 22);
            this.TextBoxTransactionAmount.TabIndex = 22;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelType.ForeColor = System.Drawing.Color.White;
            this.LabelType.Location = new System.Drawing.Point(29, 48);
            this.LabelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(63, 25);
            this.LabelType.TabIndex = 24;
            this.LabelType.Text = "Type:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(127, 48);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(55, 25);
            this.LabelTitle.TabIndex = 25;
            this.LabelTitle.Text = "Title:";
            // 
            // ComboBoxTransactionType
            // 
            this.ComboBoxTransactionType.BackColor = System.Drawing.Color.White;
            this.ComboBoxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTransactionType.FormattingEnabled = true;
            this.ComboBoxTransactionType.Location = new System.Drawing.Point(36, 81);
            this.ComboBoxTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxTransactionType.Name = "ComboBoxTransactionType";
            this.ComboBoxTransactionType.Size = new System.Drawing.Size(88, 24);
            this.ComboBoxTransactionType.TabIndex = 23;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmount.ForeColor = System.Drawing.Color.White;
            this.LabelAmount.Location = new System.Drawing.Point(267, 48);
            this.LabelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(86, 25);
            this.LabelAmount.TabIndex = 26;
            this.LabelAmount.Text = "Amount:";
            // 
            // TextBoxTitleName
            // 
            this.TextBoxTitleName.BackColor = System.Drawing.Color.White;
            this.TextBoxTitleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTitleName.Location = new System.Drawing.Point(132, 83);
            this.TextBoxTitleName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTitleName.Name = "TextBoxTitleName";
            this.TextBoxTitleName.Size = new System.Drawing.Size(132, 22);
            this.TextBoxTitleName.TabIndex = 21;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(361, 170);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(175, 47);
            this.ButtonClose.TabIndex = 30;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.ButtonAddTransaction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ComboBoxTransactionCategory);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ButtonAddTransaction);
            this.Controls.Add(this.TextBoxTransactionAmount);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ComboBoxTransactionType);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.TextBoxTitleName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new transaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxTransactionCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Button ButtonAddTransaction;
        private System.Windows.Forms.TextBox TextBoxTransactionAmount;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxTransactionType;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.TextBox TextBoxTitleName;
        private System.Windows.Forms.Button ButtonClose;
    }
}