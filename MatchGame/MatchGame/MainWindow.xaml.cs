using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates a timer
        DispatcherTimer timer = new DispatcherTimer();
        //creates an empty integer variable
        int tenthsOfSecondsElasped;
        //creates an empty integer variable
        int matchesFound;

        int bestTime = 0;
        public MainWindow()
        {
            InitializeComponent();
            //Sets the timer equal to a timeSpan that starts from 1 second
            timer.Interval = TimeSpan.FromSeconds(1);
            //Sets the timer.Tick and makes it equal to and joined to the Timer_Tick method
            timer.Tick += Timer_Tick;
            //Calls the SetUpGame method
            SetUpGame();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Increases the variable by 1
            tenthsOfSecondsElasped++;
            bestTime = tenthsOfSecondsElasped;
            //Makes the textBlock = to the tenthsOfSecondsElasped variable and converts it to a string.
            timeTextBlock.Text = (tenthsOfSecondsElasped).ToString("0s");
            if (matchesFound == 8)
            {
                //Stops the timer
                timer.Stop();
                //timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
                //Shows the timer when all the matches are done and adds a new text to it to play again.
                timeTextBlock.Text += " - Play again?";
                mainGrid.Background = new SolidColorBrush(Colors.SkyBlue);
                bestTimeText.Visibility = Visibility.Visible;
                bestTimeText.Text += bestTime.ToString($"Best Time - {bestTime}");
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐙","🐙",
                "🐟","🐟",
                "🐘","🐘",
                "🐊","🐊",
                "🐪","🐪",
                "🦕","🦕",
                "🦘","🦘",
                "🦔","🦔",
            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock" && textBlock.Name != "bestTimeText")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }
            bestTimeText.Visibility = Visibility.Hidden;

            timer.Start();
            //Sets the variable to 0
            tenthsOfSecondsElasped = 0;
            //Sets the variable to 0
            matchesFound = 0;
        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;

            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        //Makes the timer and play again text clickable. Then resets the game when the play again text has been selected
        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (matchesFound == 8)
            {
                SetUpGame();
                mainGrid.Background = new SolidColorBrush(Colors.White);
                bestTimeText.Visibility = Visibility.Hidden;
                bestTimeText.Text = "";
            }
        }
    }
}
