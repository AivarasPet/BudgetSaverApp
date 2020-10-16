namespace BudgetSaverApp
{
    partial class AddCategory
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
            this.TextBoxAddCategory = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAddCategory = new System.Windows.Forms.Button();
            this.LabelCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxAddCategory
            // 
            this.TextBoxAddCategory.Location = new System.Drawing.Point(34, 65);
            this.TextBoxAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAddCategory.Name = "TextBoxAddCategory";
            this.TextBoxAddCategory.Size = new System.Drawing.Size(491, 22);
            this.TextBoxAddCategory.TabIndex = 0;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClose.Location = new System.Drawing.Point(350, 112);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(175, 47);
            this.ButtonClose.TabIndex = 31;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonAddCategory
            // 
            this.ButtonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonAddCategory.FlatAppearance.BorderSize = 0;
            this.ButtonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonAddCategory.Location = new System.Drawing.Point(34, 112);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.Size = new System.Drawing.Size(175, 47);
            this.ButtonAddCategory.TabIndex = 32;
            this.ButtonAddCategory.Text = "Add category";
            this.ButtonAddCategory.UseVisualStyleBackColor = false;
            this.ButtonAddCategory.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // LabelCategoryName
            // 
            this.LabelCategoryName.AutoSize = true;
            this.LabelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategoryName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCategoryName.Location = new System.Drawing.Point(29, 23);
            this.LabelCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCategoryName.Name = "LabelCategoryName";
            this.LabelCategoryName.Size = new System.Drawing.Size(152, 25);
            this.LabelCategoryName.TabIndex = 33;
            this.LabelCategoryName.Text = "Category name:";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(561, 395);
            this.Controls.Add(this.LabelCategoryName);
            this.Controls.Add(this.ButtonAddCategory);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextBoxAddCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAddCategory;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAddCategory;
        private System.Windows.Forms.Label LabelCategoryName;
    }
}