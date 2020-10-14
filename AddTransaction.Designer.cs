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
            this.AddTransactionCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.AddTransactionAmount = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.AddTransactionType = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.AddTransactionName = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTransactionCategory
            // 
            this.AddTransactionCategory.BackColor = System.Drawing.Color.White;
            this.AddTransactionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionCategory.FormattingEnabled = true;
            this.AddTransactionCategory.Location = new System.Drawing.Point(342, 82);
            this.AddTransactionCategory.Margin = new System.Windows.Forms.Padding(4);
            this.AddTransactionCategory.Name = "AddTransactionCategory";
            this.AddTransactionCategory.Size = new System.Drawing.Size(161, 24);
            this.AddTransactionCategory.TabIndex = 29;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(337, 48);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(98, 25);
            this.labelCategory.TabIndex = 28;
            this.labelCategory.Text = "Category:";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AddTransactionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionButton.ForeColor = System.Drawing.Color.White;
            this.AddTransactionButton.Location = new System.Drawing.Point(34, 170);
            this.AddTransactionButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(175, 47);
            this.AddTransactionButton.TabIndex = 27;
            this.AddTransactionButton.Text = "Add transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AddTransactionAmount
            // 
            this.AddTransactionAmount.BackColor = System.Drawing.Color.White;
            this.AddTransactionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddTransactionAmount.Location = new System.Drawing.Point(248, 82);
            this.AddTransactionAmount.Margin = new System.Windows.Forms.Padding(4);
            this.AddTransactionAmount.Name = "AddTransactionAmount";
            this.AddTransactionAmount.Size = new System.Drawing.Size(81, 22);
            this.AddTransactionAmount.TabIndex = 22;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(29, 48);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(63, 25);
            this.labelType.TabIndex = 24;
            this.labelType.Text = "Type:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(101, 48);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(55, 25);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Title:";
            // 
            // AddTransactionType
            // 
            this.AddTransactionType.BackColor = System.Drawing.Color.White;
            this.AddTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionType.FormattingEnabled = true;
            this.AddTransactionType.Items.AddRange(new object[] {
            "+",
            "-"});
            this.AddTransactionType.Location = new System.Drawing.Point(36, 81);
            this.AddTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.AddTransactionType.Name = "AddTransactionType";
            this.AddTransactionType.Size = new System.Drawing.Size(57, 24);
            this.AddTransactionType.TabIndex = 23;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(243, 48);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(86, 25);
            this.labelAmount.TabIndex = 26;
            this.labelAmount.Text = "Amount:";
            // 
            // AddTransactionName
            // 
            this.AddTransactionName.BackColor = System.Drawing.Color.White;
            this.AddTransactionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddTransactionName.Location = new System.Drawing.Point(107, 82);
            this.AddTransactionName.Margin = new System.Windows.Forms.Padding(4);
            this.AddTransactionName.Name = "AddTransactionName";
            this.AddTransactionName.Size = new System.Drawing.Size(132, 22);
            this.AddTransactionName.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(361, 170);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(175, 47);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.AddTransactionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.AddTransactionCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.AddTransactionAmount);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.AddTransactionType);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.AddTransactionName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AddTransactionCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.TextBox AddTransactionAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox AddTransactionType;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox AddTransactionName;
        private System.Windows.Forms.Button buttonClose;
    }
}