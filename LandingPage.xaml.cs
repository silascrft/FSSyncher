using System;
using System.Windows.Controls;

namespace FSSyncher
{
    public partial class LandingPage : UserControl
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void SavegamesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Console.WriteLine("SavegamesButton_Click called"); // Add debug log

            if (this.Parent is MainWindow mainWindow)
            {
                mainWindow.AnimateTransitionToSaveGamePage();
            }
        }
    }
}
