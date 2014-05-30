using Breakout.Bonus;
using CasseBrique.Controler;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represents a player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the bar.
        /// </summary>
        /// <value>
        /// The bar.
        /// </value>
        public Bar Bar
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the controler.
        /// </summary>
        /// <value>
        /// The controler.
        /// </value>
        public NameControlerBar ControlGame
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bonuses.
        /// </summary>
        /// <value>
        /// The bonuses.
        /// </value>
        public List<AbstractBonus> Bonuses { get; set; }

        /// <summary>
        /// Gets or sets the move left key.
        /// </summary>
        /// <value>
        /// The move left key.
        /// </value>
        public Keys MoveLeftKey { get; set; }

        /// <summary>
        /// Gets or sets the move right key.
        /// </summary>
        /// <value>
        /// The move right key.
        /// </value>
        public Keys MoveRightKey { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player() : this("")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="_name">The _name.</param>
        public Player(String _name)
        {
            this.Name = _name;
            this.Bar = new Bar();
            this.Bonuses = new List<AbstractBonus>();
        }
    }
}
