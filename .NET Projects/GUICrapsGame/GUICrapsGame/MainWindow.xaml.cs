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

namespace GUICrapsGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random diceRoller = new Random();
        private int roundNumber;
        private int pointNum;
        private int houseWins;
        private int playerWins;
        private int BankPool;
        private int betAmount;
        public MainWindow()
        {
            InitializeComponent();
            roundNumber = 0;
            pointNum = 0;
            houseWins = 0;
            playerWins = 0;
            HouseWinsBox.Text = houseWins.ToString();
            PlayerWinsBox.Text = playerWins.ToString();
            BankPool = -1;
            betAmount = -1;

        }

        private void RulesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("So you want to learn how to play Craps huh? Alright."+Environment.NewLine+"1. Roll two 6-sided dice"+Environment.NewLine+" - If the sum of the two numbers is 7 or 11, you win"+Environment.NewLine+"  - If the sum is 2, 3 or 12 then you lose"+Environment.NewLine+"   -If the sum is any other number (4, 5, 6, 8, 9, or 10), then things become more complex"+Environment.NewLine+Environment.NewLine+"2. If you didn't immediately win or lose the first round, you now have to roll the same number as you did previously.  That number is now refered to as the \"point\" value"+Environment.NewLine+" -For example: If you roll a 4 in the first round then it becomes the point value, and now you keep rolling until either you get another 4 or until you get a 7"+Environment.NewLine+ " -However, if you roll a 7 during this phase, then you lose");
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Craps_Game_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Are you sure you want to exit the game?", "Exit Application", MessageBoxButton.YesNo);
            if(res==MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void About_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Programmer: Maxwell Winston"+Environment.NewLine+"Version: 1.0.0.0"+Environment.NewLine+".NET Framework: 4.6"+Environment.NewLine+"32 Bit Application");
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {

            //Help with this part from http://stackoverflow.com/questions/5395630/how-to-validate-user-input-for-whether-its-an-integer
            if (!int.TryParse(BankAmountBox.Text, out BankPool))
            {
                BankAmountBox.Text = "Please enter an integer";
            }
            else if (int.TryParse(BankAmountBox.Text, out BankPool) && int.Parse(BankAmountBox.Text) < 0)
            {
                BankAmountBox.Text = "Please enter an integer greater than or equal to zero";
            }
            else
            {
                BankBox.Text = BankPool.ToString();
                StartGameButton.IsEnabled = false;
                StartGameButton1.IsEnabled = false;
                GameInfo.IsEnabled = false;
                GameInfo.Visibility = Visibility.Hidden;
                GameControls.Visibility = Visibility.Visible;
                Current_Roll.Visibility = Visibility.Visible;
                WinTotalsBox.Visibility = Visibility.Visible;
                WinnersLabel.Visibility = Visibility.Hidden;
                LosersLabel.Visibility = Visibility.Hidden;
                TotalLossLabel.Visibility = Visibility.Hidden;
            }
        }

        private void RollDiceButton_Click(object sender, RoutedEventArgs e)
        {
            int die1 = diceRoller.Next(1, 7);
            int die2 = diceRoller.Next(1, 7);
            int total = die1 + die2;
            Die1Box.Text = die1.ToString();
            Die2Box.Text = die2.ToString();
            TotalBox.Text = total.ToString();
            roundNumber++;
            if(roundNumber==1)
            {
                firstRoundRuling(total);
            }
            else
            {
                postFirstRoundRuling(total);
            }

        }

        private void firstRoundRuling(int total)
        {
            if (total == 7 || total == 11)
            {
                this.Win();
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                this.Lose();
            }
            else
            {
                PointLabel.Visibility = Visibility.Visible;
                PointBox.Visibility = Visibility.Visible;
                pointNum = total;
                PointBox.Text = pointNum.ToString();
            }

                
        }

        private void postFirstRoundRuling(int total)
        {
            if (total == pointNum)
                this.Win();
            else if (total == 7)
                this.Lose();
        }
        private void Win()
        {
            RollDiceButton.IsEnabled = false;
            playerWins++;
            BankPool = BankPool + (2 * betAmount);
            PlayerWinsBox.Text = playerWins.ToString();
            WinnersLabel.Visibility = Visibility.Visible;
            BankBox.Text = BankPool.ToString();
            PlayAgain.IsEnabled = true;
        }
        private void Lose()
        {
            RollDiceButton.IsEnabled = false;
            houseWins++;
            HouseWinsBox.Text = houseWins.ToString();
            LosersLabel.Visibility = Visibility.Visible;
            if(BankPool>0)
            {
                PlayAgain.IsEnabled = true;
            }
            else
            {
                TotalLossLabel.Visibility=Visibility.Visible;
                ResetSessionButton.Visibility = Visibility.Visible;
                ResetSessionButton.IsEnabled = true;
            }
        }

        private void _ProgramInfoItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1. Enter an integer amount greater than zero you'd like to use as your bank and hit the start game button or the start game button in the game menu" + Environment.NewLine + "2. Enter an amount you'd like to bet and hit the submit button"+"3. Play the game by pressing the roll dice button until you either win or lose"+"  -If you win, you get back double your bet."+Environment.NewLine+"4. If you wish to play again, hit the play again button"+Environment.NewLine+"5. You may play until either you run out of money in your bank"+Environment.NewLine+Environment.NewLine+"If at any time you wish to start over, feel free to hit the reset session button in the game menu");
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            PlayAgain.IsEnabled = false;
            SubmitBet.IsEnabled = true;
            SetBetBox.IsEnabled = true;
            roundNumber = 0;
            PointBox.Visibility = Visibility.Hidden;
            PointLabel.Visibility = Visibility.Hidden;
            LosersLabel.Visibility = Visibility.Hidden;
            WinnersLabel.Visibility = Visibility.Hidden;
            Die1Box.Text = "";
            Die2Box.Text = "";
            TotalBox.Text = "";

        }

        private void SubmitBet_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(SetBetBox.Text, out betAmount))
            {
                SetBetBox.Text = "Please enter an integer";
            }
            else if(int.TryParse(SetBetBox.Text, out betAmount) && betAmount>BankPool)
            {
                SetBetBox.Text = "You cannot bet more than your current bank";
            }
            else if(int.TryParse(SetBetBox.Text, out betAmount) && betAmount<=0)
            {
                SetBetBox.Text = "Please enter an amount more than zero";
            }
            else
            {
                SetBetBox.IsEnabled = false;
                SubmitBet.IsEnabled = false;
                BankPool = BankPool - betAmount;
                BankBox.Text = BankPool.ToString();
                RollDiceButton.IsEnabled = true;
            }
        }


        private void ResetSession_Click(object sender, RoutedEventArgs e)
        {
            ResetSessionButton.Visibility = Visibility.Visible;
            ResetSessionButton.IsEnabled = true;
            GameInfo.IsEnabled = true;
            GameInfo.Visibility = Visibility.Visible;
            Current_Roll.Visibility = Visibility.Hidden;
            WinTotalsBox.Visibility = Visibility.Hidden;
            GameControls.Visibility = Visibility.Hidden;
            StartGameButton.IsEnabled = true;
            roundNumber = 0;
            pointNum = 0;
            houseWins = 0;
            playerWins = 0;
            HouseWinsBox.Text = houseWins.ToString();
            PlayerWinsBox.Text = playerWins.ToString();
            BankPool = -1;
            betAmount = -1;
        }

        private void Res(object sender, RoutedEventArgs e)
        {

        }
    }
}
