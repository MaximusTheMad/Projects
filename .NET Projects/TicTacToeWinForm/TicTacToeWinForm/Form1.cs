//Programmer: Maxwell Winston
//Date Written: 3/5/2017
//Program Description: Allows 2 people to play a game of Tic-Tac-Toe displayed on a windows form
//Extra Credit Attempted: None
//Limitations: Player Shapes are hard-coded.  No against CPU play implemented. Board clears when someone wins(only way to prevent players from messing with PictureBox after someone wins)

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToeWinForm
{
    public partial class Form1 : Form
    {
        private enum Player { X, O};
        private Player curPlayer;
        private Graphics GraphicsGen;
        private int NumberOfSquaresOccupied;
        private int Player1Wins;
        private int Player2Wins;
        private int CatsGames;
        private Random coinTossGen=new Random();
        //Idea to use Tuple from http://stackoverflow.com/questions/12570444/dictionary-where-the-key-is-a-pair-of-integers
        private Dictionary<Tuple<int,int>, TicTacToeSquare> squares;
        private Pen Pen1 = new Pen(Color.Black, 1);
        public Form1()
        {
            InitializeComponent();
            Player1Wins = 0;
            Player2Wins = 0;
            CatsGames = 0;
            Player1WinCount.Text = Player1Wins.ToString();
            Player2WinCount.Text = Player2Wins.ToString();
            CatsGameCounter.Text = CatsGames.ToString();
            squares = new Dictionary<Tuple<int,int>, TicTacToeSquare>();
            for(int x=0; x<3; x++)
                for(int y=0; y<3; y++)
                {
                    //Precautionary measure for dealing with the IsThereAWinner method
                    squares.Add(new Tuple<int, int>(x, y), new TicTacToeSquare(x.ToString() + y.ToString()));
                }
            NumberOfSquaresOccupied = 0;
            int coinToss = coinTossGen.Next(1, 100);
            if(coinToss%2==0)
            {
                curPlayer = Player.X;
                CurrentPlayerTurn.Text = "Player 1";
            }
            else
            {
                curPlayer = Player.O;
                CurrentPlayerTurn.Text = "Player 2";
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsGen = e.Graphics;
            GraphicsGen.DrawLine(Pen1, 120, 0, 120, 360);
            GraphicsGen.DrawLine(Pen1, 240, 0, 240, 360);
            GraphicsGen.DrawLine(Pen1, 0, 120, 360, 120);
            GraphicsGen.DrawLine(Pen1, 0, 240, 360, 240);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.X != 360 || e.Y != 360)
            {
                if (curPlayer == Player.X)
                {
                    PlayerXPlay(e.X, e.Y);
                }
                else if(curPlayer==Player.O)
                {
                    PlayerOPlay(e.X, e.Y);
                }
                
            }

            if (!IsThereAWinner() && NumberOfSquaresOccupied == 9)
            {
                CatsGames++;
                CatsGameCounter.Text = CatsGames.ToString();
                CatsGameLabel.Visible = true;
                PlayAgainButton.Visible = true;
            }
        }

        private void PlayerXPlay(int xCoordinate, int yCoordinate)
        {
            Tuple<int, int> squareCoordinates = new Tuple<int, int>((xCoordinate / 120), (yCoordinate / 120));
            if(squares[squareCoordinates].FillSquare("X"))
            {
                using (GraphicsGen = pictureBox1.CreateGraphics())
                {
                    Brush brush = new SolidBrush(pictureBox1.BackColor);
                    GraphicsGen.DrawLine(Pen1, (xCoordinate / 120) * 120 + 20, (yCoordinate / 120) * 120 + 20, (xCoordinate / 120) * 120 + 100, (yCoordinate / 120) * 120 + 100);
                    GraphicsGen.DrawLine(Pen1, (xCoordinate / 120) * 120 + 100, (yCoordinate / 120) * 120 + 20, (xCoordinate / 120) * 120 + 20, (yCoordinate / 120) * 120 + 100);
                }
                curPlayer = Player.O;
                CurrentPlayerTurn.Text = "Player 2";
                NumberOfSquaresOccupied++;
            }
            if (IsThereAWinner())
            {
                Player1Wins++;
                Player1WinCount.Text = Player1Wins.ToString();
                Player1WinsLabel.Visible = true;
                PlayAgainButton.Visible = true;
                pictureBox1.Enabled = false;
            }
            
        }

        private void PlayerOPlay(int xCoordinate, int yCoordinate)
        {
            Tuple<int, int> squareCoordinates = new Tuple<int, int>((xCoordinate / 120), (yCoordinate / 120));
            if (squares[squareCoordinates].FillSquare("O"))
            {
                using (GraphicsGen = pictureBox1.CreateGraphics())
                {
                    Brush brush = new SolidBrush(pictureBox1.BackColor);
                    GraphicsGen.DrawEllipse(Pen1, (xCoordinate / 120) * 120 + 20, (yCoordinate / 120) * 120 + 20, 80, 80);
                }
                curPlayer = Player.X;
                CurrentPlayerTurn.Text = "Player 1";
               
                NumberOfSquaresOccupied++;
            }

            if(IsThereAWinner())
            {
                Player2Wins++;
                Player2WinCount.Text = Player2Wins.ToString();
                Player2WinsLabel.Visible = true;
                pictureBox1.Enabled = false;
                PlayAgainButton.Visible = true;
            }
        }

        private bool IsThereAWinner()
        {
            Tuple<int, int> square1 = new Tuple<int, int>(0, 0);
            Tuple<int, int> square2 = new Tuple<int, int>(1, 0);
            Tuple<int, int> square3 = new Tuple<int, int>(2, 0);
            Tuple<int, int> square4 = new Tuple<int, int>(0, 1);
            Tuple<int, int> square5 = new Tuple<int, int>(1, 1);
            Tuple<int, int> square6 = new Tuple<int, int>(2, 1);
            Tuple<int, int> square7 = new Tuple<int, int>(0, 2);
            Tuple<int, int> square8 = new Tuple<int, int>(1, 2);
            Tuple<int, int> square9 = new Tuple<int, int>(2, 2);
            /*
            X-X-X
            *-*-*
            *-*-*
            */
            if (squares[square1].getShape().Equals(squares[square2].getShape()) && squares[square1].getShape().Equals(squares[square3].getShape()))
            {
                return true;
            }

            /*
            *-*-*
            X-X-X
            *-*-*
            */
            else if (squares[square4].getShape().Equals(squares[square5].getShape()) && squares[square4].getShape().Equals(squares[square6].getShape()))
            {
                return true;
            }

            /*
            *-*-*
            *-*-*
            X-X-X
            */
            else if (squares[square7].getShape().Equals(squares[square8].getShape()) && squares[square7].getShape().Equals(squares[square9].getShape()))
            {
                return true;
            }

            /*
            X-*-*
            X-*-*
            X-*-*
            */
            else if (squares[square1].getShape().Equals(squares[square4].getShape()) && squares[square1].getShape().Equals(squares[square7].getShape()))
            {
                return true;
            }
            /*
            *-X-*
            *-X-*
            *-X-*
            */
            else if (squares[square2].getShape().Equals(squares[square5].getShape()) && squares[square2].getShape().Equals(squares[square8].getShape()))
            {
                return true;
            }
            /*
            *-*-X
            *-*-X
            *-*-X
            */
            else if ((squares[square3].getShape().Equals(squares[square6].getShape()) && (squares[square3].getShape().Equals(squares[square9].getShape()))))
            {
                return true;
            }
            /*
            X-*-*
            *-X-*
            *-*-X
            */
            else if (squares[square1].getShape().Equals(squares[square5].getShape()) && squares[square1].getShape().Equals(squares[square9].getShape()))
            {
                return true;
            }
            /*
            *-*-X
            *-X-*
            X-*-*
            */
            else if (squares[square3].getShape().Equals(squares[square5].getShape()) && squares[square3].getShape().Equals(squares[square7].getShape()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            pictureBox1.Enabled = true;
            CatsGameLabel.Visible = false;
            Player2WinsLabel.Visible = false;
            PlayAgainButton.Visible = false;
            Player1WinsLabel.Visible = false;
            Player1WinCount.Text = Player1Wins.ToString();
            Player2WinCount.Text = Player2Wins.ToString();
            CatsGameCounter.Text = CatsGames.ToString();
            squares.Clear();
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    //Precautionary measure for dealing with the IsThereAWinner method
                    squares.Add(new Tuple<int, int>(x, y), new TicTacToeSquare(x.ToString() + y.ToString()));
                }
            NumberOfSquaresOccupied = 0;
            int coinToss = coinTossGen.Next(1, 100);
            if (coinToss % 2 == 0)
            {
                curPlayer = Player.X;
                CurrentPlayerTurn.Text = "X";
            }
            else
            {
                curPlayer = Player.O;
                CurrentPlayerTurn.Text = "O";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to exit the game?", "Exit Game", MessageBoxButtons.YesNo);
            if(dr==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Programmer: Maxwell Winston" + Environment.NewLine + "Current Version: 1.0.0.0" + Environment.NewLine + "This program allows two players to play a game of Tic-Tac-Toe with wins kept track of each time someone wins a game" + Environment.NewLine), "Program Details",
            MessageBoxButtons.OK);
        }

        private void rulesOfPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("1. A coin toss done by the program will determine who goes first" + Environment.NewLine + "2. Whichever player's turn it is, click on the square you wish to claim as your own.  Please note that you cannot claim a square that has already been claimed" + Environment.NewLine + "3. Pass the mouse to the next player so that they can make their move" + Environment.NewLine + "4. Continue until one player gets 3 in a row (either horizontally, vertically, or diagonally), or until no squares are left to claim" + Environment.NewLine + "5. Play again, or exit at your leisure"), "How To Play",MessageBoxButtons.OK);
        }
    }

}
