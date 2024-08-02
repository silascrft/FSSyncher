using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FSSyncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new LandingPage();
        }

        private void OnDraggableBarMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void AnimateTransitionToSaveGamePage()
        {
            Console.WriteLine("AnimateTransitionToSaveGamePage called"); // Add debug log

            var slideOutAnimation = (Storyboard)FindResource("SlideOut");

            slideOutAnimation.Completed += (s, e) =>
            {
                Console.WriteLine("Slide out animation completed"); // Add debug log
                MainContent.Content = new SaveGamePage();
                var slideInAnimation = (Storyboard)FindResource("SlideIn");
                slideInAnimation.Begin(MainContent);
            };

            slideOutAnimation.Begin(MainContent);
        }
    }
}
