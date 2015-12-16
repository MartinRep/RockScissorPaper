using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace RockScissorsPaper
{
    
    public sealed partial class MainPage : Page
    {
        public string playerChoice, computerChoice;
        public static int playerPoints = 0, computerPoints = 0, games = 0;
        public static Boolean playerwin = false;
        private Random randomComp = new Random();

        
        public MainPage()
        {
            this.InitializeComponent();
            NewGame();
        }


        public void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri;
            BitmapImage imgSource;
            games++;
            GamesPlayed.Text = games.ToString();
            switch (randomComp.Next(0, 3))
            {
                case 0:
                    computerChoice = "rock";
                    uri = new Uri(BaseUri, "/Assets/Rock.png");
                    imgSource = new BitmapImage(uri);
                    this.ComputerImage.Source = imgSource;
                    break;


                case 1:
                    computerChoice = "paper";
                    uri = new Uri(BaseUri, "/Assets/Paper.png");
                    imgSource = new BitmapImage(uri);
                    this.ComputerImage.Source = imgSource;
                    break;

                case 2:
                    computerChoice = "scissors";
                    uri = new Uri(BaseUri, "/Assets/Scissors.png");
                    imgSource = new BitmapImage(uri);
                    this.ComputerImage.Source = imgSource;
                    break;
                default:
                    break;
            }
            if (playerChoice == computerChoice)
            {
                LastGame.Text = "Draw!";
            }
            else if ((computerChoice == "rock" && playerChoice == "scissors") || (computerChoice == "scissors" && playerChoice == "paper") || (computerChoice == "paper" && playerChoice == "rock"))
            {
                LastGame.Text = "You lose!";
                computerPoints++;
                ComputerProgressBar.Value += 10;
            }
            else
            {
                LastGame.Text = "You Win!";
                playerPoints++;
                PlayerProgressBar.Value +=10;
            }
            PlayerScore.Text = playerPoints.ToString();
            ComputerScore.Text = computerPoints.ToString();
            if (ComputerProgressBar.Value == 100)
            {
                playerwin = false;
                Frame.Navigate(typeof(Results), UriKind.Relative);
            }
            else if (PlayerProgressBar.Value == 100)
            {
                playerwin = true;
                Frame.Navigate(typeof(Results), UriKind.Relative);
            }

        }

        private void NewGame()
        {
            Uri uri;
            BitmapImage imgSource;
            
            uri = new Uri(BaseUri, "/Assets/QuestionMark.jpg");
            imgSource = new BitmapImage(uri);
            this.ComputerImage.Source = imgSource;

            LastGame.Text = "";
            games = 0;
            playerPoints = 0;
            computerPoints = 0;
            GamesPlayed.Text = games.ToString();
            PlayerScore.Text = playerPoints.ToString();
            ComputerScore.Text = computerPoints.ToString();
            PlayerProgressBar.Value = 0;
            ComputerProgressBar.Value = 0;
        }

     
        private async void BottomLabel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var mailto = new Uri("mailto:rbethamcharla@hotmail.com");
            await Windows.System.Launcher.LaunchUriAsync(mailto);
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }


        private void ScissorsRadio_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(BaseUri, "/Assets/Scissors.png");
            BitmapImage imgSource = new BitmapImage(uri);
            this.PlayerImage.Source = imgSource;
            playerChoice = "scissors";
        }

        private void Rock_Checked(object sender, RoutedEventArgs e)
        {

           Uri uri = new Uri(BaseUri, "/Assets/Rock.png");
           BitmapImage imgSource = new BitmapImage(uri);
           this.PlayerImage.Source = imgSource;
           playerChoice = "rock";

        }

        private void PaperRadio_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(BaseUri, "/Assets/Paper.png");
            BitmapImage imgSource = new BitmapImage(uri);
            this.PlayerImage.Source = imgSource;
            playerChoice = "paper";

        }

    }
}
