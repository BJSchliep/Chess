﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    Public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; }
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }



    }
}