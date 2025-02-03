namespace GameDBManager
{
    partial class AddGameForm
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
            nameInput = new TextBox();
            studioInput = new TextBox();
            styleInput = new TextBox();
            releaseDatePicker = new DateTimePicker();
            doneBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Studio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Style";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Release Date";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(57, 28);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(165, 23);
            nameInput.TabIndex = 4;
            // 
            // studioInput
            // 
            studioInput.Location = new Point(59, 65);
            studioInput.Name = "studioInput";
            studioInput.Size = new Size(163, 23);
            studioInput.TabIndex = 5;
            // 
            // styleInput
            // 
            styleInput.Location = new Point(50, 102);
            styleInput.Name = "styleInput";
            styleInput.Size = new Size(172, 23);
            styleInput.TabIndex = 6;
            // 
            // releaseDatePicker
            // 
            releaseDatePicker.Location = new Point(91, 144);
            releaseDatePicker.Name = "releaseDatePicker";
            releaseDatePicker.Size = new Size(200, 23);
            releaseDatePicker.TabIndex = 7;
            // 
            // doneBtn
            // 
            doneBtn.DialogResult = DialogResult.OK;
            doneBtn.Location = new Point(12, 294);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(75, 23);
            doneBtn.TabIndex = 8;
            doneBtn.Text = "OK";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(284, 294);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 329);
            Controls.Add(button1);
            Controls.Add(doneBtn);
            Controls.Add(releaseDatePicker);
            Controls.Add(styleInput);
            Controls.Add(studioInput);
            Controls.Add(nameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddGameForm";
            Text = "AddGameForm";
            Load += AddGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameInput;
        private TextBox studioInput;
        private TextBox styleInput;
        private DateTimePicker releaseDatePicker;
        private Button doneBtn;
        private Button button1;
    }
}