using GameDBManager.Data;
using GameDBManager.Models;

namespace GameDBManager
{
    public enum SearchBy
    {
        Name,
        Studio,
        Style,
        Year
    }

    public enum GameOrder
    {
        All,
        Singleplayer,
        Multiplayer,
        MostPopular,
        LeastPopular,
        Top3Popular,
        Top3Unpopular
    }

    public partial class Form1 : Form
    {
        private GameLibraryContext gameLibraryContext;
        private SearchBy searchBy = SearchBy.Name;
        private GameOrder gameOrder = GameOrder.All;

        public Form1()
        {
            InitializeComponent();

            gameLibraryContext = new GameLibraryContext();
            LoadDataToView(listView1);

            searchOption.DataSource = Enum.GetNames<SearchBy>();
            groupOrderSelection.DataSource = Enum.GetNames<GameOrder>();
        }

        private void LoadDataToView(ListView listView)
        {
            listView.Items.Clear();

            List<Game> games = [];
            switch (gameOrder)
            {
                case GameOrder.All:
                    games = [.. gameLibraryContext.Games];
                    break;
                case GameOrder.Singleplayer:
                    games = [.. gameLibraryContext.Games.Where(game => !game.HasMultiplayer)];
                    break;
                case GameOrder.Multiplayer:
                    games = [.. gameLibraryContext.Games.Where(game => game.HasMultiplayer)];
                    break;
                case GameOrder.MostPopular:
                    int maxUnits = gameLibraryContext.Games.Max(game => game.SoldUnits);
                    games = [gameLibraryContext.Games.Single(game => game.SoldUnits == maxUnits)];
                    break;
                case GameOrder.LeastPopular:
                    int minUnits = gameLibraryContext.Games.Min(game => game.SoldUnits);
                    games = [gameLibraryContext.Games.Single(game => game.SoldUnits == minUnits)];
                    break;
                case GameOrder.Top3Popular:
                    games = [.. gameLibraryContext.Games.OrderByDescending(game => game.SoldUnits).Take(3)];
                    break;
                case GameOrder.Top3Unpopular:
                    games = [.. gameLibraryContext.Games.OrderBy(game => game.SoldUnits).Take(3)];
                    break;
            }

            foreach (Game game in games)
            {
                ListViewItem listItem = new ListViewItem([
                    game.Id.ToString(),
                    game.Name,
                    game.StudioDeveloper,
                    game.Style,
                    game.ReleaseDate.ToString(),
                    game.HasMultiplayer ? "Yes" : "No",
                    game.SoldUnits.ToString()
                    ]);

                listView.Items.Add(listItem);
            }
        }

        private void LoadDataToView(ListView listView, List<Game> games)
        {
            listView.Items.Clear();

            foreach (Game game in games)
            {
                ListViewItem listItem = new ListViewItem([
                    game.Id.ToString(),
                    game.Name,
                    game.StudioDeveloper,
                    game.Style,
                    game.ReleaseDate.ToString()
                    ]);

                listView.Items.Add(listItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addGameBtn_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            AddGameForm addGameForm = new AddGameForm(game);

            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                gameLibraryContext.Games.Add(game);
                gameLibraryContext.SaveChanges();
                LoadDataToView(listView1);
            }
        }

        private void editGameBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 &&
                int.TryParse(listView1.SelectedItems[0].Text, out int id))
            {
                Game? selectedGame = gameLibraryContext.Games.Find(id);

                if (selectedGame != null)
                {
                    AddGameForm addGameForm = new AddGameForm(selectedGame);
                    if (addGameForm.ShowDialog() == DialogResult.OK)
                    {
                        gameLibraryContext.SaveChanges();
                        LoadDataToView(listView1);
                    }
                }
            }
        }

        private void delGameBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 &&
                int.TryParse(listView1.SelectedItems[0].Text, out int id))
            {
                Game? selectedGame = gameLibraryContext.Games.Find(id);

                if (selectedGame != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {selectedGame.Name} from database?",
                        "Deletion Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        gameLibraryContext.Games.Remove(selectedGame);
                        gameLibraryContext.SaveChanges();
                        LoadDataToView(listView1);
                    }
                }
            }
        }

        private void searchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchOption.SelectedIndex != -1)
            {
                searchBy = (SearchBy)searchOption.SelectedIndex;
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(searchInput.Text))
            {
                LoadDataToView(listView1);
                return;
            }

            switch (searchBy)
            {
                case SearchBy.Name:
                    {
                        IEnumerable<Game> games = gameLibraryContext.Games.Local
                            .Where(game => game.Name.Contains(searchInput.Text, StringComparison.CurrentCultureIgnoreCase));
                        LoadDataToView(listView1, games.ToList());
                        break;
                    }
                case SearchBy.Studio:
                    {
                        IEnumerable<Game> games = gameLibraryContext.Games.Local
                            .Where(game => game.StudioDeveloper.Contains(searchInput.Text, StringComparison.CurrentCultureIgnoreCase));
                        LoadDataToView(listView1, games.ToList());
                        break;
                    }
                case SearchBy.Style:
                    {
                        IEnumerable<Game> games = gameLibraryContext.Games.Local
                            .Where(game => game.Style.Contains(searchInput.Text, StringComparison.CurrentCultureIgnoreCase));
                        LoadDataToView(listView1, games.ToList());
                        break;
                    }
                case SearchBy.Year:
                    {
                        if (int.TryParse(searchInput.Text, out int year))
                        {
                            IEnumerable<Game> games = gameLibraryContext.Games.Local
                                .Where(game => game.ReleaseDate.Year == year);
                            LoadDataToView(listView1, games.ToList());
                        }
                        break;
                    }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void groupOrderSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupOrderSelection.SelectedIndex != -1)
            {
                gameOrder = (GameOrder)groupOrderSelection.SelectedIndex;
                LoadDataToView(listView1);
            }
        }
    }
}
