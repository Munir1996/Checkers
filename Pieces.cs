using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Pieces
    {
        private const string playerSymbolB = "B";//player 1 character
        private const string playerSymbolW = "W";//player 2 character
        public const string space = " ";//spaces
        public static string[,] piece; //holds characters

        public Pieces()//constructor
        {
            piece = new string[Checkerboard.size, Checkerboard.size];
            StartPieces();//populate array
        }

        private void StartPieces()//populate the array with B and W or blanks
        {
            for (int row = 0; row < Checkerboard.size; row++)
            {
                for(int column = 0; column < Checkerboard.size; column++)
                {
                    if (row == 0 || row == 1 || row == 2)
                    {
                        piece[row, column] = playerSymbolB;//populate the first three row
                        BlankList();
                    }
                    else if(row == 5 || row == 6 || row == 7)
                    {
                        piece[row, column] = playerSymbolW;//populate the last three rows 
                        BlankList();
                    }
                    else
                    {
                        piece[row, column] = space;
                    }
                }
            }
        }//end method

        private void BlankList()
        {
            //playwer 2 side
            piece[5, 1] = space;//draw blank
            piece[5, 3] = space;
            piece[5, 5] = space;
            piece[5, 7] = space;
            piece[6, 0] = space;
            piece[6, 2] = space;
            piece[6, 4] = space;
            piece[6, 6] = space;
            piece[7, 1] = space;
            piece[7, 3] = space;
            piece[7, 5] = space;
            piece[7, 7] = space;
            

            //player 1 side
            piece[0, 0] = space;
            piece[0, 2] = space;
            piece[0, 4] = space;
            piece[0, 6] = space;
            piece[1, 1] = space;
            piece[1, 3] = space;
            piece[1, 5] = space;
            piece[1, 7] = space;
            piece[2, 0] = space;
            piece[2, 2] = space;
            piece[2, 4] = space;
            piece[2, 6] = space;
        }
    }//end class
}//end namespace