using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "John", 0);
            Player player2 = new Player(2, "Robert", 0);
            Player player3 = new Player(3, "David", 0);
            Player player4 = new Player(4, "Jason", 0);
            Player player5 = new Player(5, "Emmett", 0);

            List<Player> allPlayers = new List<Player>();

            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);
 
            Display(allPlayers);
            GetScores(allPlayers);
            DisplayPlayerDetails(allPlayers);

            allPlayers.Sort();
            allPlayers.Reverse();
            DisplayPlayerDetails(allPlayers);

            Console.WriteLine($"The highest score is {Player.HighScore}");
        }

        private static void GetScores(List<Player> allPlayers)
        {
            Console.WriteLine("Please enter number of player you wish to add score for : ");
            string response = Console.ReadLine();
            int playerNumber = int.Parse(response);

            while (playerNumber != 0)
            {
                Player selectedPlayer = allPlayers.ElementAt(playerNumber - 1);

                selectedPlayer.IncreaseScore(1);

                Display(allPlayers);

                Console.WriteLine("Please enter number of player you wish to add score for");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);
            }
        }

        private static void Display(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");
            
            foreach (Player player in players)
            {
                Console.Write("{0,-10}", player.Score);
            }

            Console.WriteLine();
        }

        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");
            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
