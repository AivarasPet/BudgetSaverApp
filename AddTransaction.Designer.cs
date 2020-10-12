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
            this.label4 = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.AddTransactionAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTransactionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTransactionName = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTransactionCategory
            // 
            this.AddTransactionCategory.BackColor = System.Drawing.Color.DarkGray;
            this.AddTransactionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionCategory.FormattingEnabled = true;
            this.AddTransactionCategory.Location = new System.Drawing.Point(292, 65);
            this.AddTransactionCategory.Name = "AddTransactionCategory";
            this.AddTransactionCategory.Size = new System.Drawing.Size(122, 21);
            this.AddTransactionCategory.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(288, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Category:";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddTransactionButton.Location = new System.Drawing.Point(450, 11);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(131, 38);
            this.AddTransactionButton.TabIndex = 27;
            this.AddTransactionButton.Text = "Add transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AddTransactionAmount
            // 
            this.AddTransactionAmount.Location = new System.Drawing.Point(186, 67);
            this.AddTransactionAmount.Name = "AddTransactionAmount";
            this.AddTransactionAmount.Size = new System.Drawing.Size(62, 20);
            this.AddTransactionAmount.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Title:";
            // 
            // AddTransactionType
            // 
            this.AddTransactionType.BackColor = System.Drawing.Color.DarkGray;
            this.AddTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddTransactionType.FormattingEnabled = true;
            this.AddTransactionType.Items.AddRange(new object[] {
            "+",
            "-"});
            this.AddTransactionType.Location = new System.Drawing.Point(27, 66);
            this.AddTransactionType.Name = "AddTransactionType";
            this.AddTransactionType.Size = new System.Drawing.Size(44, 21);
            this.AddTransactionType.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(182, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount:";
            // 
            // AddTransactionName
            // 
            this.AddTransactionName.Location = new System.Drawing.Point(80, 67);
            this.AddTransactionName.Name = "AddTransactionName";
            this.AddTransactionName.Size = new System.Drawing.Size(100, 20);
            this.AddTransactionName.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(450, 85);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 38);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.AddTransactionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(593, 134);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.AddTransactionCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.AddTransactionAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTransactionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTransactionName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AddTransactionCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.TextBox AddTransactionAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddTransactionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddTransactionName;
        private System.Windows.Forms.Button buttonClose;
    }
}