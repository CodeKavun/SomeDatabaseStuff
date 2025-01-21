using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager_WithDB
{
    public partial class InsertProductForm : Form
    {
        public InsertProductForm()
        {
            InitializeComponent();

            categoryList.Items.Clear();
            providerList.Items.Clear();

            DatabaseManager.DisplayToComboBox(categoryList, "CategoryName", "Categories");
            DatabaseManager.DisplayToComboBox(providerList, "ProviderName", "Providers");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.AddProduct(prNameBox.Text, (int)amountBox.Value, priceBox.Value,
                    categoryList.SelectedIndex + 1, providerList.SelectedIndex + 1);

                MessageBox.Show($"Product '{prNameBox.Text}' was successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show($"Server fault", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
