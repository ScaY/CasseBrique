using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class GameModel : AbstractModel
    {
        public List<Player> Players { get; set; }

        public void addPlayer(Player player)
        {
            Players.Add(player);
            
        }

        public void removePlayer(Player player)
        {
            Players.Remove(player);
        }

        public GameModel()
        {
            this.Players = new List<Player>();
        }
    }
}
