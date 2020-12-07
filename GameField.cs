using System;
using System.Collections;
using System.Text;

namespace TicTacToe
{
    class GameField
    {
        public void ShowGameField(ArrayList gameField)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gameField[0]}  |  {gameField[1]}  |  {gameField[2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gameField[3]}  |  {gameField[4]}  |  {gameField[5]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {gameField[6]}  |  {gameField[7]}  |  {gameField[8]}");
            Console.WriteLine("     |     |      ");
        }
    }
}
