using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Olimpic_Game_Application.Controls
{
    /// <summary>
    /// Interaction logic for SideMenuItem.xaml
    /// </summary>
    public partial class SideMenuItem : UserControl
    {
        private bool isSelected;
        public SideMenuItem()
        {
            InitializeComponent();


        }



        public double ClosedWidth
        {
            get { return (double)GetValue(ClosedWidthProperty); }
            set { SetValue(ClosedWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClosedWidthProperty =
            DependencyProperty.Register("ClosedWidth", typeof(double), typeof(SideMenuItem), new PropertyMetadata(OnClosedWidthChanged));

        private static void OnClosedWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SideMenuItem control = d as SideMenuItem;
            control.UpdateClosedWidth();
        }

        private void UpdateClosedWidth()
        {
            if (ClosedWidth - 5 > 0)
            {
                Image.Width = ClosedWidth - 5;
                Image.Height = ClosedWidth - 5;
            }
            else
            {
                Image.Width = ClosedWidth;
                Image.Height = ClosedWidth;
            }
            if (ClosedWidth > 0)
            {
                label.FontSize = ClosedWidth * 0.5;
            }
        }


        public static readonly DependencyProperty ImageSourceProperty =
        DependencyProperty.Register("ImageSource", typeof(string), typeof(SideMenuItem), new PropertyMetadata(OnImageSourceChanged));

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        private static void OnImageSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SideMenuItem control = d as SideMenuItem;
            control.UpdateImageSource();
        }

        private void UpdateImageSource()
        {
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(this.ImageSource, UriKind.RelativeOrAbsolute));
            this.Image.Background = brush;
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(SideMenuItem), new PropertyMetadata(string.Empty));



        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(SideMenuItem), new PropertyMetadata(OnIsSelectedChanged));

        private static void OnIsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SideMenuItem control = d as SideMenuItem;
            control.IsSelectedChanged();
        }

        private void IsSelectedChanged()
        {
            isSelected = IsSelected;
            if (isSelected)
            {
                Storyboard storyboard = new Storyboard();
                DoubleAnimation doubleAnimation = new DoubleAnimation();

                doubleAnimation.From = Indicator.Height;
                doubleAnimation.To = 15;
                doubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
                doubleAnimation.AutoReverse = false;

                doubleAnimation.EasingFunction = new SineEase();
                Storyboard.SetTargetName(doubleAnimation, "Indicator");
                Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Border.HeightProperty));
                storyboard.Children.Add(doubleAnimation);

                storyboard.Begin(this);
            }
            else
            {
                Storyboard storyboard = new Storyboard();
                DoubleAnimation doubleAnimation = new DoubleAnimation();

                doubleAnimation.From = Indicator.Height;
                doubleAnimation.To = 0;
                doubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
                doubleAnimation.AutoReverse = false;

                doubleAnimation.EasingFunction = new SineEase();
                Storyboard.SetTargetName(doubleAnimation, "Indicator");
                Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Border.HeightProperty));
                storyboard.Children.Add(doubleAnimation);

                storyboard.Begin(this);
            }
        }

        private void BaseGrid_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void BaseGrid_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }

}
