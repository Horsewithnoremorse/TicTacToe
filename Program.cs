using System;
using System.Collections;
namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WAZZZZZZUUUUP!!!!");
            //PvP pvp = new PvP();
            //pvp.PvPgame();

            PvE pve = new PvE();
            pve.PvEgame();
        }
    }
}
