using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Game
{
    public class Player : IComparable
    {
        public int ID { get;  }
        public string PlayerName{ get; set; }
        public int Score { get; private set; }
        public static int HighScore { get; private set; }

        public Player(int id, string playerName, int score)
        {
            ID = id;
            PlayerName = playerName;
            Score = score;
        }

        public void IncreaseScore(int valueToAdd)
        {
            if (Score < 100)
                Score += valueToAdd;

            if (Score > HighScore)
                HighScore = Score;
        }

        public override string ToString()
        {
            return $"{ID}\t{PlayerName}\t{Score}";
        }

        public int CompareTo(object obj)
        {
            Player objectThatIAmComparingTo = obj as Player;

            int returnValue = this.Score.CompareTo(objectThatIAmComparingTo.Score);

            return returnValue;
        }
    }
}
