using System;

namespace MvcTicTacToe.Models
{
    public class Board
    {
        public string[,] BoardMatrix { get; set; }
        public string PlayerSelected { get; set; }
        public bool PlayerStarts { get; set; }
        public int WinsHuman { get; set; }
        public int WinsIA { get; set; }
        public int Draws { get; set; }

        public Board()
        {
            BoardMatrix = new string[3, 3];
            clearBoard();
        }

        public void clearBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BoardMatrix[i, j] = "";
                }
            }
        }

        public void cellSelectedAction(int i, int j)
        {
            // si la celda selecciona ya contiene un valor, no se realiza ninguna accion
            if (isCellEmpty(i, j) == false)
            {
                return;
            }
            // si la celda esta vacia, se asigna el valor del jugador
            BoardMatrix[i, j] = PlayerSelected;
            // se pasa al turno de la IA
            doIaTurnMove();
        }

        public void doIaTurnMove()
        {
            // se verifica que aun nadie haya ganado la partida, luego se pone la ficha y se vuelve a verificar
            if (checkForWinner() == false)
            {
                // verifica el estado actual del tablero y selecciona la mejor movida posible
                int f = 0, c = 0;
                int v = int.MinValue;
                int aux;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (string.IsNullOrEmpty(BoardMatrix[i, j]))
                        {
                            BoardMatrix[i, j] = getIaSelected();
                            aux = min();
                            if (aux > v)
                            {
                                v = aux;
                                f = i;
                                c = j;
                            }
                            BoardMatrix[i, j] = "";
                        }
                    }
                }
                BoardMatrix[f, c] = getIaSelected();
                checkForWinner();
            }
        }

        private int max()
        {
            if (isGameFinished())
            {
                if (getGameWinner() != -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            int v = int.MinValue;
            int aux;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(BoardMatrix[i, j]))
                    {
                        BoardMatrix[i, j] = getIaSelected();
                        aux = min();
                        if (aux > v)
                        {
                            v = aux;
                        }
                        BoardMatrix[i, j] = "";
                    }
                }
            }
            return v;
        }

        private int min()
        {
            if (isGameFinished())
            {
                if (getGameWinner() != -1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            int v = int.MaxValue;
            int aux;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(BoardMatrix[i, j]))
                    {
                        BoardMatrix[i, j] = PlayerSelected;
                        aux = max();
                        if (aux < v)
                        {
                            v = aux;
                        }
                        BoardMatrix[i, j] = "";
                    }
                }
            }
            return v;
        }

        private int getGameWinner()
        {
            // devuelve -1 si nadie gano, 0 si gano el jugador, 1 si gano la IA
            if (isPlayerWinner(PlayerSelected))
            {
                return 0;
            }
            else if (isPlayerWinner(getIaSelected()))
            {
                return 1;
            }
            return -1;
        }

        private bool isGameFinished()
        {
            if (isPlayerWinner(PlayerSelected))
            {
                return true;
            }
            else if (isPlayerWinner(getIaSelected()))
            {
                return true;
            }
            else if (isBoardFull())
            {
                return true;
            }
            return false;
        }

        private bool isCellEmpty(int row, int col)
        {
            if (string.IsNullOrEmpty(BoardMatrix[row, col]))
            {
                return true;
            }
            return false;
        }

        private string getIaSelected()
        {
            if (String.Equals(PlayerSelected, "X"))
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        private bool checkForWinner()
        {
            bool gameFinished = false;
            // verifica si alguien ya gano la partida, o si llego a empate, en ese caso se aumenta la respectiva variable,
            // se limpia el tablero y se inicia una nueva partida
            if (isPlayerWinner(PlayerSelected))
            {
                WinsHuman = WinsHuman + 1;
                gameFinished = true;
            }
            else if (isPlayerWinner(getIaSelected()))
            {
                WinsIA = WinsIA + 1;
                gameFinished = true;
            }
            else if (isBoardFull())
            {
                // si se lleno el tablero y no gano ninguno de los 2, es empate
                Draws = Draws + 1;
                gameFinished = true;
            }
            if (gameFinished)
            {
                clearBoard();
                if (PlayerStarts.Equals(false))
                {
                    doIaTurnMove();
                }
                return true;
            }
            return false;
        }

        private bool isBoardFull()
        {
            // devuelve verdadero si todas las celdas del tablero tienen un valor distinto de vacio
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(BoardMatrix[i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isPlayerWinner(string player)
        {
            // verifica si el jugador pasado por parametro es el ganador
            // filas
            if (String.Equals(BoardMatrix[0, 0], player) && String.Equals(BoardMatrix[0, 1], player) && String.Equals(BoardMatrix[0, 2], player)) { return true; }
            if (String.Equals(BoardMatrix[1, 0], player) && String.Equals(BoardMatrix[1, 1], player) && String.Equals(BoardMatrix[1, 2], player)) { return true; }
            if (String.Equals(BoardMatrix[2, 0], player) && String.Equals(BoardMatrix[2, 1], player) && String.Equals(BoardMatrix[2, 2], player)) { return true; }
            // columnas
            if (String.Equals(BoardMatrix[0, 0], player) && String.Equals(BoardMatrix[1, 0], player) && String.Equals(BoardMatrix[2, 0], player)) { return true; }
            if (String.Equals(BoardMatrix[0, 1], player) && String.Equals(BoardMatrix[1, 1], player) && String.Equals(BoardMatrix[2, 1], player)) { return true; }
            if (String.Equals(BoardMatrix[0, 2], player) && String.Equals(BoardMatrix[1, 2], player) && String.Equals(BoardMatrix[2, 2], player)) { return true; }
            // diagonales
            if (String.Equals(BoardMatrix[0, 0], player) && String.Equals(BoardMatrix[1, 1], player) && String.Equals(BoardMatrix[2, 2], player)) { return true; }
            if (String.Equals(BoardMatrix[0, 2], player) && String.Equals(BoardMatrix[1, 1], player) && String.Equals(BoardMatrix[2, 0], player)) { return true; }
            return false;
        }

    }
}