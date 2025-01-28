namespace StationaryStuffManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DatabaseManager.Init();
            DatabaseManager.DisplayData(dataView);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.Close();
        }
    }
}
