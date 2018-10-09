using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kortSpilConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UnoGame game = new UnoGame();
            Console.WriteLine(game.player1.ToString());
            Console.WriteLine();
            Console.WriteLine(game.player2.ToString());

        }
    }
}
