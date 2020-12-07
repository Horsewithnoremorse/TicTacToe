using System;
using System.Collections;
using System.Text;

namespace TicTacToe
{
    class AI
    {
        public bool moveDone;
        public void AiMove(ArrayList gameField, string aiSide, string player)
        {
            bool moveDone = false;
            //комп проверяет может ли он победить и побеждает
            if (HorizontCheck(gameField, aiSide, player)) { return; }
            if (VerticalCheck(gameField, aiSide, player)) { return; }
            if (CrossCheck(gameField, aiSide, player)) { return; }

            //комп проверяет на необходимость блокировать
            if (HorizontBlockCheck(gameField, aiSide, player)) { return; }
            if (VerticalBlockCheck(gameField, aiSide, player)) { return; }  
            if (CrossBlockCheck(gameField, aiSide, player)) { return; }

            //комп хз че делать 
            if (gameField[4] != player && gameField[4] != aiSide)
            {
                gameField[4] = aiSide;
                moveDone = true;
                return;
            }
            else
            {
                if (gameField[0] != player && gameField[0] != aiSide)
                {
                    gameField[0] = aiSide;
                    moveDone = true;
                    return;
                }
                if (gameField[2] != player && gameField[2] != aiSide)
                {
                    gameField[2] = aiSide;
                    moveDone = true;
                    return;
                }
                if (gameField[6] != player && gameField[6] != aiSide)
                {
                    gameField[6] = aiSide;
                    moveDone = true;
                    return;
                }
                if (gameField[8] != player && gameField[8] != aiSide)
                {
                    gameField[8] = aiSide;
                    moveDone = true;
                    return;
                }
            }





        }
        public bool HorizontCheck(ArrayList gameField, string aiSide, string player)
        {
            for ( int i = 0; i < 6; i += 3)
            {
                if (gameField[i] != player && gameField[i+1] == aiSide && gameField[i+2] == aiSide)                    
                {
                    gameField[i] = aiSide;
                    return true;
                }
                if (gameField[i] == aiSide && gameField[i + 1] != player && gameField[i + 2] == aiSide)
                {
                    gameField[i+1] = aiSide;
                    return true;
                }
                if (gameField[i] == aiSide && gameField[i + 1] == aiSide && gameField[i + 2] == player)
                {
                    gameField[i + 2] = aiSide;
                    return true;
                }
                
            }
            return false;
        }
        public bool VerticalCheck(ArrayList gameField, string aiSide, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((gameField[i] != player && gameField[i + 3] == aiSide && gameField[i + 6] == aiSide))
                {
                    gameField[i] = aiSide;
                    return true;
                }
                if (gameField[i] == aiSide && gameField[i+3] != player && gameField[i + 6] == aiSide)
                {
                    gameField[i+3] = aiSide;
                    return true;
                }
                if (gameField[i] == aiSide && gameField[i + 3] == aiSide && gameField[i+6] != player)
                {
                    gameField[i+6] = aiSide;
                    return true;
                }
            }
            return false;
        }
        public bool CrossCheck(ArrayList gameField, string aiSide, string player)
        {
            if (gameField[0] != player && gameField[4] == aiSide && gameField[8] == aiSide)
            {
                gameField[0] = aiSide;
                return true;
            }
            if (gameField[0] == aiSide && gameField[4] != player && gameField[8] == aiSide)
            {
                gameField[4] = aiSide;
                return true;
            }
            if (gameField[0] == aiSide && gameField[4] == aiSide && gameField[8] != player)
            {
                gameField[8] = aiSide;
                return true;
            }

            if (gameField[0] != player && gameField[4] == aiSide && gameField[6] == aiSide)
            {
                gameField[0] = aiSide;
                return true;
            }
            if (gameField[2] == aiSide && gameField[4] != player && gameField[6] == aiSide)
            {
                gameField[4] = aiSide;
                return true;
            }
            if (gameField[2] == aiSide && gameField[4] == aiSide && gameField[6] != player)
            {
                gameField[6] = aiSide;
                return true;
            }
            return false;
        }

        public bool HorizontBlockCheck(ArrayList gameField, string aiSide, string player)
        {
            for (int i = 0; i < 6; i += 3)
            {
                if (gameField[i] != aiSide && gameField[i + 1] == player && gameField[i + 2] == player)
                {
                    gameField[i] = aiSide;
                    return true;
                }
                if (gameField[i] == player && gameField[i + 1] != aiSide && gameField[i + 2] == player)
                {
                    gameField[i + 1] = aiSide;
                    return true;
                }
                if (gameField[i] == player && gameField[i + 1] == player && gameField[i + 2] == aiSide)
                {
                    gameField[i + 2] = aiSide;
                    return true;
                }
            }
            return false;
        }
        public bool VerticalBlockCheck(ArrayList gameField, string aiSide, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameField[i] != aiSide && gameField[i + 3] == player && gameField[i + 6] == player)
                {
                    gameField[i] = aiSide;
                    return true;
                }
                if (gameField[i] == player && gameField[i + 3] != aiSide && gameField[i + 6] == player)
                {
                    gameField[i + 3] = aiSide;
                    return true;
                }
                if (gameField[i] == player && gameField[i + 3] == player && gameField[i + 6] != aiSide)
                {
                    gameField[i + 6] = aiSide;
                    return true;
                }
            }
            return false;
        }
        public bool CrossBlockCheck(ArrayList gameField, string aiSide, string player)
        {
            if (gameField[0] != aiSide && gameField[4] == player && gameField[8] == player)
            {
                gameField[0] = aiSide;
                return true;
            }
            if (gameField[0] == player && gameField[4] != aiSide && gameField[8] == player)
            {
                gameField[4] = aiSide;
                return true;
            }
            if (gameField[0] == player && gameField[4] == player && gameField[8] != aiSide)
            {
                gameField[8] = aiSide;
                return true;
            }

            if (gameField[0] != aiSide && gameField[4] == player && gameField[6] == player)
            {
                gameField[0] = aiSide;
                return true;
            }
            if (gameField[2] == player && gameField[4] != aiSide && gameField[6] == player)
            {
                gameField[4] = aiSide;
                return true;
            }
            if (gameField[2] == player && gameField[4] == player && gameField[6] != aiSide)
            {
                gameField[6] = aiSide;
                return true;
            }
            return false;

        }
    }
}
