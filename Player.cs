using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public int ID { get;  }
        public string PlayerName{ get; set; }
        public int Score { get; set; }

        public Player(int id, string playerName, int score)
        {
            ID = id;
            PlayerName = playerName;
            Score = score;
        }
    }
}
