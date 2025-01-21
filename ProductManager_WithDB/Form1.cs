namespace ProductManager_WithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DatabaseManager.Init();
            DatabaseManager.DisplayData(dataTableView);

            DatabaseManager.DisplayToComboBox(categoryFilter, "CategoryName", "Categories");
            DatabaseManager.DisplayToComboBox(providersFilter, "ProviderName", "Providers");
        }

        private void categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseManager.CategoryFilterId = categoryFilter.SelectedIndex;
            DatabaseManager.DisplayData(dataTableView);
        }

        private void providersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseManager.ProviderFilterId = providersFilter.SelectedIndex;
            DatabaseManager.DisplayData(dataTableView);
        }
    }
}
