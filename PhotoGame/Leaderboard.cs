using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema1
{
    class Leaderboard
    {
        public string Username;
        public int Score;
        
        public Leaderboard(string Username, int Score)
        {
            this.Username = Username;
            this.Score = Score;
        }
        public string Get_Username()
        {
            return this.Username;
        }
        public int Get_Score()
        {
            return this.Score;
        }
    }
    
}
