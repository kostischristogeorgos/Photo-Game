using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thema1
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm(List<string> Usernames, List<string> Scores)
        {   // It fills the top 3 labels based on the length of the usernames list accordingly.
            InitializeComponent();
            if (Usernames.Count == 1)
            {
                first.Text = Usernames[0] + ":  " + Scores[0];
            }
            if (Usernames.Count == 2)
            {
                first.Text = Usernames[0] + ":  " + Scores[0];
                second.Text = Usernames[1] + ":  " + Scores[1];
            }
            if (Usernames.Count >= 3)
            {
                first.Text = Usernames[0] + ":  " + Scores[0];
                second.Text = Usernames[1] + ":  " + Scores[1];
                third.Text = Usernames[2] + ":  " + Scores[2];
            }
        }

        private void return_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
