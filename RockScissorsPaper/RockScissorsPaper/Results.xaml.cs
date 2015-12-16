using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RockScissorsPaper
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Results : Page
    {
        public Results()
        {
            this.InitializeComponent();
            Uri uri;
            BitmapImage imgSource;

            if (MainPage.playerwin == true)
            {
                uri = new Uri(BaseUri, "/Assets/Winner.png");
                imgSource = new BitmapImage(uri);
                this.image.Source = imgSource;
                ResultsTextBox.Text = "CONGRATULATION!!!\n";
            }
            else
            {
                uri = new Uri(BaseUri, "/Assets/Lost.png");
                imgSource = new BitmapImage(uri);
                this.image.Source = imgSource;
                ResultsTextBox.Text = "Try again...\n";
            }
            ResultsTextBox.Text += "Games Played: " + MainPage.games + "\nYour Score: " + MainPage.playerPoints + "\nComputer Score: " + MainPage.computerPoints;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }
    }
}
