using Breakout.Events;
using CasseBrique.Events;
using System.Collections.Generic;

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

        public void SetPause(bool pause)
        {
            this.Pause = pause;
            this.RefreshViews(new GamePause(this));
        }
    }
}
