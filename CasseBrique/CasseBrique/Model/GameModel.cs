using Breakout.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class GameModel : AbstractModel
    {
        public bool Pause { get; set; }

        public List<Player> Players { get; set; }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
            this.RefreshViews(new AddedPlayerEvent(this, player));
        }

        public void RemovePlayer(Player player)
        {
            this.Players.Remove(player);
            this.RefreshViews(new RemovedPlayerEvent(this, player));
        }

        public GameModel()
        {
            this.Pause = false;
            this.Players = new List<Player>();
        }
    }
}
