namespace BudgetSaverApp
{
    partial class AddSavings
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
            this.TextBoxSavingsName = new System.Windows.Forms.TextBox();
            this.ComboBoxSavingsType = new System.Windows.Forms.ComboBox();
            this.TextBoxSavingsAmount = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.ButtonAddSavings = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxSavingsName
            // 
            this.TextBoxSavingsName.Location = new System.Drawing.Point(134, 84);
            this.TextBoxSavingsName.Name = "TextBoxSavingsName";
            this.TextBoxSavingsName.Size = new System.Drawing.Size(214, 22);
            this.TextBoxSavingsName.TabIndex = 0;
            // 
            // ComboBoxSavingsType
            // 
            this.ComboBoxSavingsType.BackColor = System.Drawing.Color.White;
            this.ComboBoxSavingsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSavingsType.FormattingEnabled = true;
            this.ComboBoxSavingsType.Items.AddRange(new object[] {
            "Comodities",
            "Crypto",
            "Stocks",
            "Money"});
            this.ComboBoxSavingsType.Location = new System.Drawing.Point(24, 84);
            this.ComboBoxSavingsType.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxSavingsType.Name = "ComboBoxSavingsType";
            this.ComboBoxSavingsType.Size = new System.Drawing.Size(103, 24);
            this.ComboBoxSavingsType.TabIndex = 24;
            // 
            // TextBoxSavingsAmount
            // 
            this.TextBoxSavingsAmount.Location = new System.Drawing.Point(354, 84);
            this.TextBoxSavingsAmount.Name = "TextBoxSavingsAmount";
            this.TextBoxSavingsAmount.Size = new System.Drawing.Size(81, 22);
            this.TextBoxSavingsAmount.TabIndex = 25;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelType.ForeColor = System.Drawing.Color.White;
            this.LabelType.Location = new System.Drawing.Point(19, 56);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(63, 25);
            this.LabelType.TabIndex = 26;
            this.LabelType.Text = "Type:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(135, 56);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(55, 25);
            this.LabelTitle.TabIndex = 27;
            this.LabelTitle.Text = "Title:";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelAmount.ForeColor = System.Drawing.Color.White;
            this.LabelAmount.Location = new System.Drawing.Point(351, 54);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(86, 25);
            this.LabelAmount.TabIndex = 28;
            this.LabelAmount.Text = "Amount:";
            // 
            // ButtonAddSavings
            // 
            this.ButtonAddSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonAddSavings.FlatAppearance.BorderSize = 0;
            this.ButtonAddSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddSavings.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonAddSavings.Location = new System.Drawing.Point(24, 151);
            this.ButtonAddSavings.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddSavings.Name = "ButtonAddSavings";
            this.ButtonAddSavings.Size = new System.Drawing.Size(175, 47);
            this.ButtonAddSavings.TabIndex = 34;
            this.ButtonAddSavings.Text = "Add savings";
            this.ButtonAddSavings.UseVisualStyleBackColor = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClose.Location = new System.Drawing.Point(340, 151);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(175, 47);
            this.ButtonClose.TabIndex = 33;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.ButtonAddSavings);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.TextBoxSavingsAmount);
            this.Controls.Add(this.ComboBoxSavingsType);
            this.Controls.Add(this.TextBoxSavingsName);
            this.Name = "AddSavings";
            this.Text = "Add savings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSavingsName;
        private System.Windows.Forms.ComboBox ComboBoxSavingsType;
        private System.Windows.Forms.TextBox TextBoxSavingsAmount;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Button ButtonAddSavings;
        private System.Windows.Forms.Button ButtonClose;
    }
}