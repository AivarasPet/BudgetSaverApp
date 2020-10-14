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
            this.AddSavingsType = new System.Windows.Forms.ComboBox();
            this.textBoxSavingsAmount = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.AddSavingsButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxSavingsName
            // 
            this.TextBoxSavingsName.Location = new System.Drawing.Point(134, 84);
            this.TextBoxSavingsName.Name = "TextBoxSavingsName";
            this.TextBoxSavingsName.Size = new System.Drawing.Size(214, 22);
            this.TextBoxSavingsName.TabIndex = 0;
            // 
            // AddSavingsType
            // 
            this.AddSavingsType.BackColor = System.Drawing.Color.White;
            this.AddSavingsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddSavingsType.FormattingEnabled = true;
            this.AddSavingsType.Items.AddRange(new object[] {
            "Comodities",
            "Crypto",
            "Stocks",
            "Money"});
            this.AddSavingsType.Location = new System.Drawing.Point(24, 84);
            this.AddSavingsType.Margin = new System.Windows.Forms.Padding(4);
            this.AddSavingsType.Name = "AddSavingsType";
            this.AddSavingsType.Size = new System.Drawing.Size(103, 24);
            this.AddSavingsType.TabIndex = 24;
            // 
            // textBoxSavingsAmount
            // 
            this.textBoxSavingsAmount.Location = new System.Drawing.Point(354, 84);
            this.textBoxSavingsAmount.Name = "textBoxSavingsAmount";
            this.textBoxSavingsAmount.Size = new System.Drawing.Size(81, 22);
            this.textBoxSavingsAmount.TabIndex = 25;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(19, 56);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(63, 25);
            this.labelType.TabIndex = 26;
            this.labelType.Text = "Type:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(135, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(55, 25);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Title:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(351, 54);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(86, 25);
            this.labelAmount.TabIndex = 28;
            this.labelAmount.Text = "Amount:";
            // 
            // AddSavingsButton
            // 
            this.AddSavingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AddSavingsButton.FlatAppearance.BorderSize = 0;
            this.AddSavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSavingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddSavingsButton.Location = new System.Drawing.Point(24, 151);
            this.AddSavingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddSavingsButton.Name = "AddSavingsButton";
            this.AddSavingsButton.Size = new System.Drawing.Size(175, 47);
            this.AddSavingsButton.TabIndex = 34;
            this.AddSavingsButton.Text = "Add savings";
            this.AddSavingsButton.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(340, 151);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(175, 47);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // AddSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.AddSavingsButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxSavingsAmount);
            this.Controls.Add(this.AddSavingsType);
            this.Controls.Add(this.TextBoxSavingsName);
            this.Name = "AddSavings";
            this.Text = "Add savings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSavingsName;
        private System.Windows.Forms.ComboBox AddSavingsType;
        private System.Windows.Forms.TextBox textBoxSavingsAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button AddSavingsButton;
        private System.Windows.Forms.Button buttonClose;
    }
}