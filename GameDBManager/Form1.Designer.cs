namespace GameDBManager
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
            listView1 = new ListView();
            gameId = new ColumnHeader();
            gameName = new ColumnHeader();
            gameStudio = new ColumnHeader();
            gameStyle = new ColumnHeader();
            gameRelease = new ColumnHeader();
            addGameBtn = new Button();
            editGameBtn = new Button();
            delGameBtn = new Button();
            searchInput = new TextBox();
            searchBtn = new Button();
            searchOption = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { gameId, gameName, gameStudio, gameStyle, gameRelease });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 92);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 346);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // gameId
            // 
            gameId.Text = "ID";
            gameId.Width = 50;
            // 
            // gameName
            // 
            gameName.Text = "Name";
            gameName.Width = 250;
            // 
            // gameStudio
            // 
            gameStudio.Text = "Studio";
            gameStudio.Width = 160;
            // 
            // gameStyle
            // 
            gameStyle.Text = "Style";
            gameStyle.Width = 140;
            // 
            // gameRelease
            // 
            gameRelease.Text = "Release Date";
            gameRelease.Width = 150;
            // 
            // addGameBtn
            // 
            addGameBtn.Location = new Point(12, 12);
            addGameBtn.Name = "addGameBtn";
            addGameBtn.Size = new Size(61, 23);
            addGameBtn.TabIndex = 1;
            addGameBtn.Text = "Add";
            addGameBtn.UseVisualStyleBackColor = true;
            addGameBtn.Click += addGameBtn_Click;
            // 
            // editGameBtn
            // 
            editGameBtn.Location = new Point(79, 12);
            editGameBtn.Name = "editGameBtn";
            editGameBtn.Size = new Size(61, 23);
            editGameBtn.TabIndex = 2;
            editGameBtn.Text = "Edit";
            editGameBtn.UseVisualStyleBackColor = true;
            editGameBtn.Click += editGameBtn_Click;
            // 
            // delGameBtn
            // 
            delGameBtn.Location = new Point(146, 12);
            delGameBtn.Name = "delGameBtn";
            delGameBtn.Size = new Size(61, 23);
            delGameBtn.TabIndex = 3;
            delGameBtn.Text = "Delete";
            delGameBtn.UseVisualStyleBackColor = true;
            delGameBtn.Click += delGameBtn_Click;
            // 
            // searchInput
            // 
            searchInput.Location = new Point(338, 63);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(357, 23);
            searchInput.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(701, 63);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(87, 23);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchOption
            // 
            searchOption.FormattingEnabled = true;
            searchOption.Location = new Point(211, 63);
            searchOption.Name = "searchOption";
            searchOption.Size = new Size(121, 23);
            searchOption.TabIndex = 6;
            searchOption.SelectedIndexChanged += searchOption_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 66);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Search by";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(searchOption);
            Controls.Add(searchBtn);
            Controls.Add(searchInput);
            Controls.Add(delGameBtn);
            Controls.Add(editGameBtn);
            Controls.Add(addGameBtn);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader gameId;
        private ColumnHeader gameName;
        private ColumnHeader gameStyle;
        private ColumnHeader gameRelease;
        private ColumnHeader gameStudio;
        private Button addGameBtn;
        private Button editGameBtn;
        private Button delGameBtn;
        private TextBox searchInput;
        private Button searchBtn;
        private ComboBox searchOption;
        private Label label1;
    }
}
