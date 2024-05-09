using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Olimpic_Game_Application.Controls
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public ObservableCollection<SideMenuItem> Items { get; set; } = new ObservableCollection<SideMenuItem>();


        public SolidColorBrush Background
        {
            get { return (SolidColorBrush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(SolidColorBrush), typeof(SideMenu), new PropertyMetadata(new SolidColorBrush { Color = Color.FromArgb(255, 255, 255, 255) }));



        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SideMenu), new PropertyMetadata(new CornerRadius(0)));



        public double ClosedWidth
        {
            get { return (double)GetValue(ClosedWidthProperty); }
            set { SetValue(ClosedWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClosedWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClosedWidthProperty =
            DependencyProperty.Register("ClosedWidth", typeof(double), typeof(SideMenu), new PropertyMetadata(40d));

        public double OpenedWidth
        {
            get { return (double)GetValue(OpenedWidthProperty); }
            set { SetValue(OpenedWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OpenedWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OpenedWidthProperty =
            DependencyProperty.Register("OpenedWidth", typeof(double), typeof(SideMenu), new PropertyMetadata(110d));



        public int AnimationSpeed
        {
            get { return (int)GetValue(AnimationSpeedProperty); }
            set { SetValue(AnimationSpeedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AnimationSpeed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AnimationSpeedProperty =
            DependencyProperty.Register("AnimationSpeed", typeof(int), typeof(SideMenu), new PropertyMetadata(1000));



        private void BaseGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.From = BaseGrid.Width;
            doubleAnimation.To = ClosedWidth;
            doubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(AnimationSpeed));
            doubleAnimation.AutoReverse = false;

            doubleAnimation.EasingFunction = new SineEase();
            Storyboard.SetTargetName(doubleAnimation, "BaseGrid");
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Grid.WidthProperty));
            storyboard.Children.Add(doubleAnimation);

            storyboard.Begin(this);

        }

        private void BaseGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.From = BaseGrid.Width;
            doubleAnimation.To = OpenedWidth;
            doubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(AnimationSpeed));
            doubleAnimation.AutoReverse = false;

            doubleAnimation.EasingFunction = new SineEase();
            Storyboard.SetTargetName(doubleAnimation, "BaseGrid");
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Grid.WidthProperty));
            storyboard.Children.Add(doubleAnimation);

            storyboard.Begin(this);
        }
    }
}
