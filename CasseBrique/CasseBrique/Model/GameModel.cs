using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class GameModel : AbstractModel
    {
        private Player currentPlayer;
        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set {
                if (Players.Contains(value))
                {
                    currentPlayer = value;
                }
            }
        }

        public List<Player> Players { get; set; }

        public GameModel()
        {
            this.Players = new List<Player>();
        }
    }
}
