using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Sean Mangala
//Date: 2024-04-12
//Purpose: Class defines a player
namespace Assignment2Final
{
    internal class Player
    {
        private string name;
        public string Color { get; set; }
        private int health;

        public string Name
        {
            get
            {
                return name;
            }
            set 
            {
                if (value != "")
                    name = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set 
            {
                health = value;
            }
        }

        //Non-Default Constructor
        public Player(string name, string color, int health) 
        { 
            this.name = name;
            this.Color = color;
            this.health = health;
        }

        //Default Constructor
        public Player()
        {
            Name = "Player";
            Color = "Red";
            Health = 100;
        }
    }
}
