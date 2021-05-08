//*****************************
// Programmer: Obie Burns
// Date: 7-5-2021
// Software: Visual Studio 2019
// Platform: Windows
// Purpose: To demonstrate nested classes for A2
//*****************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2NestedClass
{
    public class Player : IComparable<Player>
    {

        // the name of the player
        public string Name;

        // the object that encapsulates the player's stats
        public Stats PlayerStats;


        // constructor that takes arguments, to be instantiated in frmMain()
        public Player(string name, Stats playerStats)
        {
            // assigns variables
            Name = name;

            PlayerStats = playerStats;

        }

        public int CompareTo(Player player)
        {
            // if the player's levels are equal, sort by player name
            if (PlayerStats.Level == player.PlayerStats.Level)
            {
                return Name.CompareTo(player.Name);
            }

            // sorts by level otherwise
            return PlayerStats.Level.CompareTo(player.PlayerStats.Level);
        }


        public class Stats
        {
            // the level of the player
            public int Level;

            // the hit points of the player (higher value = more healthy)
            public int HitPoints;

            // the mana points of the player (higher value = easier to cast spells)
            public int ManaPoints;

            // constructor for Stats() that takes args so it can be instantiated in Player()
            public Stats(int level, int hitPoints, int manaPoints)
            {
                // assigns variables
                Level = level;

                HitPoints = hitPoints;

                ManaPoints = manaPoints;

            }
        }

    }


}
