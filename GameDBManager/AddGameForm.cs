using GameDBManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDBManager
{
    public partial class AddGameForm : Form
    {
        private readonly Game game;

        public AddGameForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text) && string.IsNullOrEmpty(studioInput.Text)
                && string.IsNullOrEmpty(styleInput.Text) && string.IsNullOrEmpty(releaseDatePicker.Value.ToString()))
            {
                MessageBox.Show("One of the fields are empty!", "Unable to add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            game.Name = nameInput.Text;
            game.StudioDeveloper = studioInput.Text;
            game.Style = styleInput.Text;
            game.ReleaseDate = releaseDatePicker.Value;
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {
            nameInput.Text = game.Name;
            studioInput.Text = game.StudioDeveloper;
            styleInput.Text = game.Style;

            if (game.ReleaseDate >= releaseDatePicker.MinDate)
                releaseDatePicker.Value = game.ReleaseDate;
        }
    }
}
