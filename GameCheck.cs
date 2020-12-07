using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class GameCheck
    {
        public bool win = false;
        public void WinnerCheck(ArrayList gameField, string player)
        {
            HorizontCheck(gameField, player);
            VerticalCheck(gameField, player);
            CrossCheck(gameField, player);
        }
        public void HorizontCheck(ArrayList gameField, string player)
        {
            for ( int i = 0; i < 6; i += 3)
            {
                if (gameField[i] == player && gameField[i+1] == player && gameField[i+2] == player)
                {
                    Console.WriteLine($"Победил {player}");
                    Console.ReadKey();
                    win = true;
                }
            }
            
        }
        public void VerticalCheck(ArrayList gameField, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameField[i] == player && gameField[i + 3] == player && gameField[i + 6] == player)
                {
                    Console.WriteLine($"Победил {player}");
                    Console.ReadKey();
                    win = true;
                }
            }

        }
        public void CrossCheck(ArrayList gameField, string player)
        {
            if (gameField[0] == player && gameField[4] == player && gameField[8] == player)
            {
                Console.WriteLine($"Победил {player}");
                Console.ReadKey();
                win = true;
            }
            if (gameField[2] == player && gameField[4] == player && gameField[6] == player)
            {
                Console.WriteLine($"Победил {player}");
                Console.ReadKey();
                win = true;
            }

        }
    }
}
