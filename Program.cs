using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkerboard board = new Checkerboard();         
            board.Display();

            Console.ReadKey();
        }
    }
}
