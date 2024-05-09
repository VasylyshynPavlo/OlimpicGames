using OlimpicDb.Data;
using OlimpicDb.Repository;
using System.Windows;
using System.Windows.Media;

namespace Olimpic_Game_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 

    public partial class MainWindow : Window
    {
        public static UnitOfWork db = new();
        private double NormalWidth;
        private double NormalHeight;
        private bool maximized = false;
        private double NormalLeft;
        private double NormalTop;
        public MainWindow()
        {
            InitializeComponent();
            ResourceDictionary resources = Application.Current.Resources;
            sideMenu.Items[0].ImageSource = @"https://img.icons8.com/ios-filled/500/" + resources["FontColor"].ToString().Remove(0, 3) + @"/database.png";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (maximized)
            {
                this.Width = NormalWidth;
                this.Height = NormalHeight;
                this.Left = NormalLeft;
                this.Top = NormalTop;
                maximized = false;
                ResourceDictionary resources = Application.Current.Resources;
                resources["CloseButtonThickness"] = new Thickness(0, 5, 0, 0);
                SolidColorBrush brush = resources["ElementColor2"] as SolidColorBrush;
                BackgroundElement.BorderBrush = brush;
                BackgroundElement.CornerRadius = new CornerRadius(5);
            }
            else
            {
                NormalHeight = this.Height;
                NormalWidth = this.Width;
                NormalLeft = this.Left;
                NormalTop = this.Top;
                this.Width = SystemParameters.WorkArea.Width;
                this.Height = SystemParameters.WorkArea.Height;
                this.Left = 0;
                this.Top = 0;
                maximized = true;
                ResourceDictionary resources = Application.Current.Resources;
                resources["CloseButtonThickness"] = new Thickness(0);
                SolidColorBrush brush = new(Color.FromArgb(255, 0, 0, 0));
                BackgroundElement.BorderBrush = brush;
                BackgroundElement.CornerRadius = new CornerRadius(0);
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (maximized)
            {
                this.Width = NormalWidth;
                this.Height = NormalHeight;
                maximized = false;
                ResourceDictionary resources = Application.Current.Resources;
                resources["CloseButtonThickness"] = new Thickness(0, 5, 0, 0);
                SolidColorBrush brush = resources["ElementColor2"] as SolidColorBrush;
                BackgroundElement.BorderBrush = brush;
                BackgroundElement.CornerRadius = new CornerRadius(5);
            }
            this.DragMove();
        }


        private void SideMenuItem_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            foreach (var item in sideMenu.Items)
            {
                item.IsSelected = false;
            }
            sideMenu.Items[0].IsSelected = true;
            dataPage.Visibility = Visibility.Visible;
            SettingsMenu.Visibility = Visibility.Hidden;
        }

        private void SideMenuItem_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            foreach (var item in sideMenu.Items)
            {
                item.IsSelected = false;
            }
            sideMenu.Items[1].IsSelected = true;
            dataPage.Visibility = Visibility.Hidden;
            SettingsMenu.Visibility = Visibility.Hidden;
        }

        private void SideMenuItem_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            foreach (var item in sideMenu.Items)
            {
                item.IsSelected = false;
            }
            sideMenu.Items[2].IsSelected = true;
            dataPage.Visibility = Visibility.Hidden;
            SettingsMenu.Visibility = Visibility.Visible;


        }
    }
}