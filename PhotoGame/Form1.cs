using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thema1
{
    public partial class Form1 : Form
    {
        Player player;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void play_button_Click(object sender, EventArgs e)
        {
            //If the textbox is empty it asks to fill it and then starts the game by creating a gameform object.
            if (String.IsNullOrEmpty(username_textbox.Text))
            {
                MessageBox.Show("Please enter a username!");
            }
            else
            {
                
                player = new Player(username_textbox.Text);
                username_textbox.Text = "";
                this.Hide();
                GameForm gameForm = new GameForm(player.Username);
                gameForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void top3_button_Click(object sender, EventArgs e)
        {
           //It calls the ReadDb method that fills two lists.
            ReadDb();
            
        }
        private void ReadDb()
        {
            try
            {   //It gets the username and the score by ascending order based on the score.
                List<string> Usernames = new List<string>();
                List<string> Scores = new List<string>();
                string connectionString = "Data Source=Database.db;Version=3;";
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                string query = "SELECT * from Scores Order By Score Asc";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Usernames.Add(reader.GetString(1));
                    Scores.Add(reader.GetInt32(2).ToString());

                }
                //It creates a leaderboardform object and displays the top3 tries.
                LeaderboardForm leaderboardForm = new LeaderboardForm(Usernames, Scores);
                leaderboardForm.Show();
                reader.Close();
                conn.Close();
                
            }
            catch
            {
                MessageBox.Show("Error reading from the Database.");
            }
        }
    }
}
