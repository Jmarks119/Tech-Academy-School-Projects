﻿using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public string Name { get; set; }
        public abstract void Play();
        public Dictionary<Player, int> Bets { get; set; } = new Dictionary<Player, int>();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
