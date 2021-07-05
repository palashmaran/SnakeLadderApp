
namespace SnakeLadderApp.Services
{
    using SnakeLadderApp.Contracts;
    using SnakeLadderApp.Models;
    using SplitwiseApp.contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SnakeLadderGameService : ISnakeLadderGame
    {

        List<Player> players;
        Board board;
        IDice dice;
        
        public SnakeLadderGameService(Board board, List<Player> players, IDice dice)
        {
            this.dice = dice;
            this.board = board;
            this.players = players;
        }

        public void EndGame(Player player)
        {
            Console.WriteLine(player.Name + " " + "wins the game");
        }

        public void StartGame()
        {
            board.IntitalizeBoard();
            
            PlayerService playerService = new PlayerService();

            while (true)
            {
                foreach (var player in players)
                {
                    int newPostion = dice.Throw();
                    //Console.WriteLine("Expected postion " +  newPostion);
                    int oldpostion = player.Postion;
                    Box box = board.GetBox(oldpostion + newPostion);
                    playerService.Move(player, box);

                   // Console.WriteLine("Player Name " + player.Name + "old Postion " + oldpostion + " " + "new Postion " + player.Postion);
                    if (player.IsReached)
                    {
                        EndGame(player);
                        return;
                    }
                }
            }
        }
    }
}
