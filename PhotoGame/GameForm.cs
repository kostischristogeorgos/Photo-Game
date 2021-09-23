using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Thema1
{
    public partial class GameForm : Form
    {   List<int> picture_list = new List<int>();
        Random random = new Random();
        int click_count,tries,time_elapsed, freeze_picture = 0;
        int pictures_left = 10;
        int previous;
        string Username;
        PictureBox previous_picturebox, current_picturebox = null;
        int image_replaced;
        public GameForm(string username)
        {
            InitializeComponent();
            this.Username = username;
            welcome_label.Text = "Welcome " + username + " !";
            end_game_username.Text = "Congratulations " + username + " !";
            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Load_Pictures();
            end_game_panel.Hide();
            pic_panel.Hide();
            addpic_panel.Show();
            temp_pictureBox.Hide();
            temp_pictureBox.Image = null;
        }
       

        // This function sorts the numbers from 1-5 randomly in a 10 index list.
        public void Load_Pictures()
        {
            for(int i = 1; i <=5;  i++)
            {
                picture_list.Add(i);
                picture_list.Add(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                var rand = random.Next(10);
                var rand2 = random.Next(10);
                var temp = picture_list[rand];
                picture_list[rand] = picture_list[rand2];
                picture_list[rand2] = temp;
            }
            image_replaced = random.Next(5) + 1; //Random number that will be removed when a user loads a picture.
        }
        
        public void check_images(int current, int previous, PictureBox current_picturebox, PictureBox previous_picturebox)
        {
           //If the previous clicked picturebox and the current one are the same it removes them both.
            if (current == previous)
            {
                current_picturebox.Hide();
                previous_picturebox.Hide();
                pictures_left = pictures_left - 2;
                // If there are no pictures left the player has won and it calls the WriteDb function and resets the timers.
                if(pictures_left == 0)
                {
                    WriteDB(tries);
                    end_game_panel.Show();
                    timer.Enabled = false;
                    end_game_tries.Text  = "Total tries: " + tries.ToString();
                    end_game_time.Text = "Total time: " + time_elapsed.ToString();
                    time_label.Hide();
                    tries_label.Hide();
                }
            }
            else
            {   // If they are not the same pictures it starts the freepicturetimer that freezes the pictures for 1 second.
                Freeze_picture_timer.Enabled = true;
                Freeze_picture_timer.Start();
            }
            tries++;
            tries_label.Text = "Tries " + tries.ToString(); 
            click_count = 0;
        }
        private void Freeze_picture_timer_Tick(object sender, EventArgs e)
        {
            // if 1 second has passed it sets both the picture boxes back to the questionmarks and stops the freeze timer.
            if (freeze_picture == 1)
            {
                current_picturebox.ImageLocation = "questionmark.png";
                previous_picturebox.ImageLocation = "questionmark.png";
                freeze_picture = 0;
                previous_picturebox = null;
                Freeze_picture_timer.Stop();
            }
            freeze_picture++;
        }
        private void no_button_Click(object sender, EventArgs e)
        {
            addpic_panel.Hide();
            pic_panel.Show();
            timer.Enabled = true;
            timer.Start();
        }
        private void yes_button_Click(object sender, EventArgs e)
        {   // If this button is pressed it asks for the user to put a picture that will remove one of the default picture of the game.
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                temp_pictureBox.Image = new Bitmap(openFileDialog.FileName);
                addpic_panel.Hide();
                pic_panel.Show();
                timer.Enabled = true;
                timer.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   if (previous_picturebox != pictureBox1) // if you haven't double clicked the same picturebox
            {
                current_picturebox= pictureBox1;
                click_count++;
                // If this picture is the random picture selected and the picture given from the user isn't null
                if (picture_list[0] == image_replaced && temp_pictureBox.Image != null) 
                {
                    pictureBox1.Image = temp_pictureBox.Image;
                }
                else
                {   // Else the user hasn't given a picture the default picture of the game is entered in each picturebox.
                    pictureBox1.ImageLocation = picture_list[0].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {   // if you've done 2 clicks it calls the checkimages function to check if the 2 picture boxes are the same.
                    check_images(picture_list[0], previous, current_picturebox, previous_picturebox);
                }
                else
                {   // the previous picturebox becomes the current one.
                    previous = picture_list[0];
                    previous_picturebox = pictureBox1;
                }
            }
        }
        
        //Same for all 10 pictureboxes.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox2)
            {
                click_count++;
                current_picturebox = pictureBox2;
                if (picture_list[1] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox2.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox2.ImageLocation = picture_list[1].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[1], previous, current_picturebox, previous_picturebox);
                }
                else
                {
                    previous = picture_list[1];
                    previous_picturebox = pictureBox2;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox3)
            {
                current_picturebox = pictureBox3;
                click_count++;
                if (picture_list[2] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox3.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox3.ImageLocation = picture_list[2].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[2], previous, pictureBox3, previous_picturebox);
                }
                else
                {
                    previous = picture_list[2];
                    previous_picturebox = pictureBox3;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox4)
            {
                current_picturebox = pictureBox4;
                click_count++;
                if (picture_list[3] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox4.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox4.ImageLocation = picture_list[3].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[3], previous, pictureBox4, previous_picturebox);
                }
                else
                {
                    previous = picture_list[3];
                    previous_picturebox = pictureBox4;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox5)
            {
                current_picturebox = pictureBox5;
                click_count++;
                if (picture_list[4] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox5.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox5.ImageLocation = picture_list[4].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[4], previous, pictureBox5, previous_picturebox);
                }
                else
                {
                    previous = picture_list[4];
                    previous_picturebox = pictureBox5;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox6)
            {
                current_picturebox = pictureBox6;
                click_count++;
                if (picture_list[5] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox6.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox6.ImageLocation = picture_list[5].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[5], previous, pictureBox6, previous_picturebox);
                }
                else
                {
                    previous = picture_list[5];
                    previous_picturebox = pictureBox6;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox7)
            {
                current_picturebox = pictureBox7;
                click_count++;
                if (picture_list[6] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox7.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox7.ImageLocation = picture_list[6].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[6], previous, pictureBox7, previous_picturebox);
                }
                else
                {
                    previous = picture_list[6];
                    previous_picturebox = pictureBox7;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox8)
            {
                current_picturebox = pictureBox8;
                click_count++;
                if (picture_list[7] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox8.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox8.ImageLocation = picture_list[7].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[7], previous, pictureBox8, previous_picturebox);
                }
                else
                {
                    previous = picture_list[7];
                    previous_picturebox = pictureBox8;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox9)
            {
                current_picturebox = pictureBox9;
                click_count++;
                if (picture_list[8] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox9.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox9.ImageLocation = picture_list[8].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[8], previous, pictureBox9, previous_picturebox);
                }
                else
                {
                    previous = picture_list[8];
                    previous_picturebox = pictureBox9;
                }
            }
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (previous_picturebox != pictureBox10)
            {
                current_picturebox = pictureBox10;
                click_count++;
                if (picture_list[9] == image_replaced && temp_pictureBox.Image != null)
                {
                    pictureBox10.Image = temp_pictureBox.Image;
                }
                else
                {
                    pictureBox10.ImageLocation = picture_list[9].ToString() + ".png";
                }
                if (click_count % 2 == 0)
                {
                    check_images(picture_list[9], previous, pictureBox10, previous_picturebox);
                }
                else
                {
                    previous = picture_list[9];
                    previous_picturebox = pictureBox10;
                }
            }
        }


        private void exit_picturebox_Click(object sender, EventArgs e)
        {   //Closes the menu form and this form.
            this.Close();
            Application.OpenForms[0].Close();
        }


        private void timer_Tick(object sender, EventArgs e)
        {   //A timer counting 1 second.
            time_label.Text = "Time : " + time_elapsed.ToString();
            time_elapsed++;
        }
        private void return_button_Click(object sender, EventArgs e)
        {   //Refreshes the menu form and closes this form.
            this.Close();
            Application.OpenForms[0].Show();
            Application.OpenForms[0].Refresh();
        }
        private void WriteDB(int Score)
        {
            try
            {   //It enters the current score with the username accordingly to the database.
                Leaderboard leaderboard = new Leaderboard(Username, Score);
                string connectionString = "Data Source=Database.db;Version=3;";
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                string query = "Insert into Scores (Username,Score) Values (@Username, @Score)";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("Username", leaderboard.Get_Username());
                command.Parameters.AddWithValue("Score", leaderboard.Get_Score());
                int return_value = command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error writing to the database");
            } 
        }
    }
}
