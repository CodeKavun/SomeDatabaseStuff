namespace StationaryStuffManager
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
            dataView = new ListView();
            idHeader = new ColumnHeader();
            stationaryName = new ColumnHeader();
            price = new ColumnHeader();
            stationaryType = new ColumnHeader();
            companyName = new ColumnHeader();
            managerName = new ColumnHeader();
            dateSell = new ColumnHeader();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.Columns.AddRange(new ColumnHeader[] { idHeader, stationaryName, price, stationaryType, companyName, managerName, dateSell });
            dataView.Location = new Point(12, 96);
            dataView.Name = "dataView";
            dataView.Size = new Size(776, 342);
            dataView.TabIndex = 0;
            dataView.UseCompatibleStateImageBehavior = false;
            dataView.View = View.Details;
            // 
            // idHeader
            // 
            idHeader.Text = "Id";
            // 
            // stationaryName
            // 
            stationaryName.Text = "Stationary Name";
            stationaryName.Width = 160;
            // 
            // price
            // 
            price.Text = "Price";
            price.Width = 70;
            // 
            // stationaryType
            // 
            stationaryType.Text = "Type";
            stationaryType.Width = 100;
            // 
            // companyName
            // 
            companyName.Text = "Company";
            companyName.Width = 140;
            // 
            // managerName
            // 
            managerName.Text = "Manager";
            managerName.Width = 140;
            // 
            // dateSell
            // 
            dateSell.Text = "Sell Date";
            dateSell.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataView);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ListView dataView;
        private ColumnHeader idHeader;
        private ColumnHeader stationaryName;
        private ColumnHeader price;
        private ColumnHeader stationaryType;
        private ColumnHeader companyName;
        private ColumnHeader managerName;
        private ColumnHeader dateSell;
    }
}
