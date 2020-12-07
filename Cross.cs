using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Cross
    {
        public void GameMove(ArrayList gameField, string player)
        {
            bool okcheck = false;
            while (okcheck == false)
            {
                Console.WriteLine($"Ход игрока {player}, введите номер клетки");
                string input = Console.ReadLine();
                int index;
                bool result = int.TryParse(input, out index);
                if (result == true)
                {
                    if (index < 1 || index > 9 ||gameField[index - 1] == "O" || gameField[index - 1] == "X")
                    {
                        Console.WriteLine("Не пытайся наебать систему;)");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("ok");
                        gameField[index - 1] = player;
                        okcheck = true;
                    }

                }
                else
                {
                    Console.WriteLine("Преобразование завершилось неудачно");
                }
            }
        }
    }
}
