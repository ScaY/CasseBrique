using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Events;

namespace Breakout.Model
{
    public class Game : AbstractModel
    {
        public List<Player> Players { get; set; }

        public void addPlayer(Player player)
        {
            Players.Add(player);
            RefreshViews(new AddedPlayerEvent(this, player));
        }

        public void removePlayer(Player player)
        {
            Players.Remove(player);
            RefreshViews(new RemovedPlayerEvent(this, player));
        }

        public Game()
        {
            this.Players = new List<Player>();
        }
    }
}
