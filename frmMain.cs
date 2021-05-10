//*****************************
// Programmer: Obie Burns
// Date: 7-5-2021
// Software: Visual Studio 2019
// Platform: Windows
// Purpose: Main form for the program. Demonstrates use of nested classes for A2, use of IComparable for A2 and drag and drop for A2
//*****************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2NestedClass
{
    public partial class frmMain : Form
    {
        // instance of Random() that generates (psuedo)random stats
        static Random statPicker = new Random();

        // contains all the players in the game
        List<Player> allPlayers = new List<Player>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // sets allow drop to true
            AllowDrop = true;
        }




        private void btnCreateRandomPlayer_Click(object sender, EventArgs e)
        {
            // picks random stats to display
            int statLevel = statPicker.Next(1, 300);
            int statHitPoints = statPicker.Next(1, 300);
            int statManaPoints = statPicker.Next(5, 45);

            // creates the stat object with the variables defined before
            Player.Stats newStats = new Player.Stats(statLevel, statHitPoints, statManaPoints);

            // creates a new player and assigns the stats, and generates a random name for it
            Player newPlayer = new Player(GenerateRandomName(), newStats);

            // adds the new player to the players list
            allPlayers.Add(newPlayer);

            // adds the players to the listbox
            AddPlayersListToListbox();

        }

        // adds players in the players list to the listbox
        private void AddPlayersListToListbox()
        {
            // clears the list box items so players don't stack
            lstboxPlayers.Items.Clear();

            // prints stats of each player in player list to screen
            foreach (var player in allPlayers)
            {
                lstboxPlayers.Items.Add($"Level: {player.PlayerStats.Level} " +
                    $"Name: {player.Name} " +
                    $"HP: {player.PlayerStats.HitPoints} " +
                    $"MP: {player.PlayerStats.ManaPoints}");
            }
        }


        // generates a random name for a player
        private string GenerateRandomName()
        {
            // inspired by https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings

            // all the allowed characters for the name
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // gets a random name length between 1 and 8
            int nameLength = statPicker.Next(1, 8);

            // initates the empty name variable
            string name = "";

            // picks random characters for the name
            for (int i = 0; i < nameLength; i++)
            {
                // gets random character id
                int randomCharId = statPicker.Next(1, allowedChars.Length);

                // adds character to name
                name += allowedChars[randomCharId];
            }

            // returns the result
            return name;
        }

        private void btnSortPlayers_Click(object sender, EventArgs e)
        {
            // if there are no players in the players list, an error is displayed
            if (allPlayers.Count == 0)
            {
                MessageBox.Show("You have to create some players first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // sorts the players list
            allPlayers.Sort();

            // adds the newly sorted list to the listbox
            AddPlayersListToListbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in fileList)
            {
                // assigns text to filename
                lblFileDrop.Text = file;
            }
        }

    }
}

