using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Checkerboard
    {
        private string[,] board;
        public const int size = 8; //8x8 board

        private Player player;


        public Checkerboard()//constructor
        {
            player = new Player();

            board = new string[size, size];
            BoardXAxis = "+---";//draws the x axis for the board
            BoardYAxis = "| ";//draws the y axis for the board

        }

        //property
        public string BoardXAxis { get; set; }
        public string BoardYAxis { get; set; }

        public void Display()
        {
            while (!player.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");//x axis header

                for (int row = 0; row < size; row++)
                {
                    Console.Write("  ");//top-left spacing
                    for (int column = 0; column < size; column++)
                    {
                        Console.Write(BoardXAxis);//write the  BoardXAxis symbol
                    }

                    Console.Write("+\n");

                    for (int column = 0; column < size; column++)
                    {
                        if (column == 0)
                            Console.Write(row + " ");//y axis header
                        Console.Write(BoardYAxis + Pieces.piece[row, column] + " "); //write the BoardYAxis and character
                    }

                    Console.Write("|\n");
                }
            
            //the bottom line needs to be printed separatley
            Console.Write("  ");// left spacing
            for(int column = 0; column < size; column++)
            {
                Console.Write(BoardXAxis); 
            }

            Console.Write("+\n\n");
                player.Move();

            }//end while
        }//end method
    }//end class
}//end namespace