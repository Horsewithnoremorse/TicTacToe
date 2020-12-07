using System;
using System.Collections;
using System.Text;

namespace TicTacToe
{
    class PvE
    {
        public void PvEgame()
        {
            string repeat = "y";
            while (repeat == "y")
            {
                repeat = "n";
                ArrayList gameField = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Cross cross = new Cross();
                GameCheck gameCheck = new GameCheck();
                GameField field = new GameField();
                AI aI = new AI();

                string player;
                string aiSide;
                Console.WriteLine("За кого будете играть Х или О? (1 - Х, 2 - О)");
                string answer = Console.ReadLine();
                if (answer == "1") { player = "X"; aiSide = "O"; }
                else if (answer == "2") { player = "O"; aiSide = "X"; }
                else { Console.WriteLine("Видимо рано еще тебе в такие сложные игры играть"); return; }

                field.ShowGameField(gameField);
                
                for (int i = 0; i < 9 && gameCheck.win == false; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (player == "X")
                        {
                            cross.GameMove(gameField, player);
                            field.ShowGameField(gameField);
                        }
                        else
                        {
                            aI.AiMove(gameField, aiSide, player);
                            field.ShowGameField(gameField);
                        }
                    }
                    else
                    {
                        if (player == "O")
                        {
                            cross.GameMove(gameField, player);
                            field.ShowGameField(gameField);
                        }
                        else
                        {
                            aI.AiMove(gameField, aiSide, player);
                            field.ShowGameField(gameField);
                        }
                    }
                    gameCheck.WinnerCheck(gameField, player);
                    gameCheck.WinnerCheck(gameField, aiSide);
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
