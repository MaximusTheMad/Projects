using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer: Maxwell Winston
//Date Written: 3/5/2017
//Program Description: Allows 2 people to play a game of Tic-Tac-Toe displayed on a windows form
//Extra Credit Attempted: None
//Limitations: Player Shapes are hard-coded.  No against CPU play implemented. Board clears when someone wins(only way to prevent players from messing with PictureBox after someone wins)


namespace TicTacToeWinForm
{
    //Class Info: Contains info and methods needed to facilitate Tic-Tac-Toe play
    class TicTacToeSquare
    {
        private string Shape;
        Boolean occupied { get; set; }
        

        public TicTacToeSquare(String shape)
        {

            occupied = false;
            Shape = shape;
        }

        public Boolean FillSquare(String ShapeToSet)
        {
            if(!occupied)
            {
                Shape = ShapeToSet;
                occupied = true;
                return true;
            }

            else
            {
                return false;
            }
        }

        public String getShape()
        {
            return this.Shape;
        } 
    }
}
