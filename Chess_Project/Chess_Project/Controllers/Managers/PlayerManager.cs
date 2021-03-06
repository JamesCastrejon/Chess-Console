﻿using Chess_Project.Models.Helper;
using Chess_Project.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Project.Controllers.Managers
{
    internal class PlayerManager
    {
        internal Player Player1 { get; set; }
        internal Player Player2 { get; set; }
        internal Player CurrentP { get; set; }
        internal PlayerManager()
        {
            Player1 = new Player("Player 1", Color.white);
            Player2 = new Player("Player 2", Color.black);
        }
        internal void SwitchPlayer()
        {
            if(CurrentP.Name == Player1.Name)
                CurrentP = Player2;
            else
                CurrentP = Player1;
        }
    }
}
