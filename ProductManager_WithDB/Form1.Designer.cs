namespace ProductManager_WithDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataTableView = new ListView();
            productId = new ColumnHeader();
            productName = new ColumnHeader();
            amount = new ColumnHeader();
            price = new ColumnHeader();
            category = new ColumnHeader();
            provider = new ColumnHeader();
            categoryFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            providersFilter = new ComboBox();
            SuspendLayout();
            // 
            // dataTableView
            // 
            dataTableView.Columns.AddRange(new ColumnHeader[] { productId, productName, amount, price, category, provider });
            dataTableView.Location = new Point(12, 105);
            dataTableView.Name = "dataTableView";
            dataTableView.Size = new Size(776, 333);
            dataTableView.TabIndex = 0;
            dataTableView.UseCompatibleStateImageBehavior = false;
            dataTableView.View = View.Details;
            // 
            // productId
            // 
            productId.Text = "ID";
            // 
            // productName
            // 
            productName.Text = "Name";
            productName.Width = 200;
            // 
            // amount
            // 
            amount.Text = "Amount";
            amount.Width = 70;
            // 
            // price
            // 
            price.Text = "Original Price";
            price.Width = 110;
            // 
            // category
            // 
            category.Text = "Category";
            category.Width = 150;
            // 
            // provider
            // 
            provider.Text = "Provider";
            provider.Width = 160;
            // 
            // categoryFilter
            // 
            categoryFilter.FormattingEnabled = true;
            categoryFilter.Items.AddRange(new object[] { "All" });
            categoryFilter.Location = new Point(73, 76);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(121, 23);
            categoryFilter.TabIndex = 1;
            categoryFilter.Text = "All";
            categoryFilter.SelectedIndexChanged += categoryFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Providers";
            // 
            // providersFilter
            // 
            providersFilter.FormattingEnabled = true;
            providersFilter.Items.AddRange(new object[] { "All" });
            providersFilter.Location = new Point(289, 76);
            providersFilter.Name = "providersFilter";
            providersFilter.Size = new Size(121, 23);
            providersFilter.TabIndex = 4;
            providersFilter.Text = "All";
            providersFilter.SelectedIndexChanged += providersFilter_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(providersFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoryFilter);
            Controls.Add(dataTableView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView dataTableView;
        private ColumnHeader productId;
        private ColumnHeader productName;
        private ColumnHeader price;
        private ColumnHeader category;
        private ColumnHeader provider;
        private ColumnHeader amount;
        private ComboBox categoryFilter;
        private Label label1;
        private Label label2;
        private ComboBox providersFilter;
    }
}
