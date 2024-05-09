using System.Windows;
using OlimpicDb.Repository;
using System.Windows.Controls;

namespace Olimpic_Game_Application.Controls
{
    /// <summary>
    /// Interaction logic for DataPage.xaml
    /// </summary>
    public partial class DataPage : UserControl
    {
        public DataPage()
        {
            InitializeComponent();

        }

        public async Task LoadDataAsync(int mode)
        {
            //data.Items.Clear();
            progressBar.Visibility = Visibility.Visible;
            switch (mode)
            {
                case 0:
                    var dataCountries = await Task.Run(() => MainWindow.db.CountryRepo.Get().Select(x => new
                    {
                        x.Id,
                        x.Name,
                        CountryFlagLink = x.CountryFlagLink ?? "NULL",
                    }));
                    data.ItemsSource = dataCountries;
                    break;
                case 1:
                    var dataOlimpGames = await Task.Run(() => MainWindow.db.OlimpicGameRepo
                    .Get(includeProperties: "Place.Country")
                    .Select(x => new
                    {
                        x.Id,
                        City = x.Place.City ?? "NULL",
                        Country = (x.Place != null && x.Place.Country != null ? x.Place.Country.Name : "NULL"),
                        Date = x.Place.Date ?? "NULL",
                    }));
                    data.ItemsSource = dataOlimpGames;
                    break;
                case 3:
                    var dataPlayers = await Task.Run(() => MainWindow.db.PlayerRepo
                    .Get(includeProperties: "Country")
                    .Select(x => new
                    {
                        x.Id,
                        x.Name,
                        Sex = x.Sex ?? "NULL",
                        Height = x.Height ?? "NULL",
                        Birthday = x.Birthday ?? "NULL",
                        Country = x.Country.Name,
                        PersonPhoto = x.ImageLink ?? "NULL",
                    }));
                    data.ItemsSource = dataPlayers;
                    break;
                case 4:
                    var dataSports = await Task.Run(() => MainWindow.db.SportRepo
                    .Get(includeProperties: "")
                    .Select(x => new
                    {
                        x.Id,
                        x.Name,
                        Description = x.Description ?? "NULL",
                    }));
                    data.ItemsSource = dataSports;
                    break;
                case 5:
                    var dataStatistics = await Task.Run(() => MainWindow.db.StatisticRepo
                    .Get(includeProperties: "PlayerStatistics.Player,Sport")
                    .Select(x => new
                    {
                        x.Id,
                        Player = x.PlayerStatistics.Select(ps => ps.Player.Name ?? "not found"),
                        Sport = x.Sport.Name ?? "NULL",
                        x.Place,
                    }));
                    data.ItemsSource = dataStatistics;
                    break;
                default:
                    MessageBox.Show("Unknow error in `LoadData`", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    break;
            }
            progressBar.Visibility = Visibility.Hidden;
            
        }

        private async void CountriesButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync(0);
        }

        private async void OlimpicGamesButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync(1);
        }

        private async void PlayersButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync(3);
        }

        private async void SportsButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync(4);
        }

        private async void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync(5);
        }
    }
}
