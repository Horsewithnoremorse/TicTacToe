using System;
using System.Collections;
using System.Text;

namespace TicTacToe
{
    public class PvP
    {
        public void PvPgame()
        {
            string repeat = "y";
            while (repeat == "y")
            {
                repeat = "n";
                ArrayList gameField = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Cross cross = new Cross();
                GameCheck gameCheck = new GameCheck();
                GameField field = new GameField();
                field.ShowGameField(gameField);
                string player;
                for (int i = 0; i < 9 && gameCheck.win == false; i++)
                {
                    if (i % 2 == 0)
                    {
                        player = "X";
                        cross.GameMove(gameField, player);
                        field.ShowGameField(gameField);
                    }
                    else
                    {
                        player = "O";
                        cross.GameMove(gameField, player);
                        field.ShowGameField(gameField);
                    }
                    gameCheck.WinnerCheck(gameField, player);
                }
                if (gameCheck.win == false)
                {
                    Console.WriteLine("Ничья");
                }
                Console.WriteLine("Желаете продолжить ? (y/n)");
                repeat = Console.ReadLine();
            }
        }
    }
}
