using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Player : Pieces
    {
        private int targetX;//coordinates for which pieces you want to take on the x axis
        private int targetY;//coordinates for which pieces you want to take on the y axis
        private int destinationX;//coordinates for which pieces you want to place on the x axis
        private int destinationY;//coordinates for which pieces you want to place on the x axi
        
        public Player()//constructor
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }

        public bool Exit { get; set; }

        public void Move()
        {
            GetInput();//call

            if(!Exit == true)
            ReplacePieces();//call
            
        }

        private void GetInput()//get input and validate
        {
            if (!Exit)
            {
                Console.WriteLine("Enter targets X axis");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out targetX));
            }

            if (!Exit)//if it pass the validation move to next validation
            {
                Console.WriteLine("Enter targets Y axis");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out targetY));
            }

            if (!Exit)//if it pass the validation move to next validation
            {
                Console.WriteLine("Enter destination X axis");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out destinationX));
            }

            if (!Exit)//if it pass the validation move to next validation
            {
                Console.WriteLine("Enter destination Y axis");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out destinationY));
            }
        }//end method

        private void ReplacePieces()
        {
            piece[destinationY, destinationX] = piece[targetY, targetX];
            piece[targetY, targetX] = space;
        }

        private bool ValidateInput(bool pass)
        {
            bool error = false;

            if (!pass)
            {
                error = true;
            }
            else if (targetX < 0 || targetY < 0 | destinationX < 0 | destinationY < 0)//exit if under 0
            {
                error = true;
            }
            else if (targetX > Checkerboard.size - 1 || targetY > Checkerboard.size - 1 || destinationX > Checkerboard.size - 1 || destinationY > Checkerboard.size - 1)//exit if over 7
            {
                error = true;
            }

            string a;
            a = piece.ToString.GetValue(0,0);
            if(piece[targetX, targetY] == a)
            {
                Console.WriteLine("invalid");
            }

            if (error)
            {
                Console.WriteLine("invalid input. exiting program now! ");
            }

            return error;
        }
    }//end class
}//end namespace