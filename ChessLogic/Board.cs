using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Board
    {
        private readonly Piece[,] Pieces = new Piece[8, 8];
        public Piece this[int row, int col]
        {
            get { return Pieces[row, col]; }
            set { Pieces[row, col] = value; }
        }

        public Piece this[Position pos]
        {
            get { return Pieces[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }

        // Left off here

    }
}
