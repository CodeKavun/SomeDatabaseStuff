namespace ProductManager_WithDB
{
    partial class InsertProductForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            prNameBox = new TextBox();
            priceBox = new NumericUpDown();
            amountBox = new NumericUpDown();
            categoryList = new ComboBox();
            providerList = new ComboBox();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)priceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Original Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 94);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 126);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Provider";
            // 
            // prNameBox
            // 
            prNameBox.Location = new Point(57, 6);
            prNameBox.Name = "prNameBox";
            prNameBox.Size = new Size(100, 23);
            prNameBox.TabIndex = 5;
            // 
            // priceBox
            // 
            priceBox.DecimalPlaces = 2;
            priceBox.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            priceBox.Location = new Point(96, 61);
            priceBox.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(120, 23);
            priceBox.TabIndex = 6;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(69, 32);
            amountBox.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(120, 23);
            amountBox.TabIndex = 7;
            // 
            // categoryList
            // 
            categoryList.FormattingEnabled = true;
            categoryList.Location = new Point(74, 90);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(121, 23);
            categoryList.TabIndex = 8;
            // 
            // providerList
            // 
            providerList.FormattingEnabled = true;
            providerList.Location = new Point(70, 123);
            providerList.Name = "providerList";
            providerList.Size = new Size(121, 23);
            providerList.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(254, 152);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // InsertProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 187);
            Controls.Add(addBtn);
            Controls.Add(providerList);
            Controls.Add(categoryList);
            Controls.Add(amountBox);
            Controls.Add(priceBox);
            Controls.Add(prNameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InsertProductForm";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)priceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox prNameBox;
        private NumericUpDown priceBox;
        private NumericUpDown amountBox;
        private ComboBox categoryList;
        private ComboBox providerList;
        private Button addBtn;
    }
}