
namespace SplitwiseApp
{
    using SnakeLadderApp.Contracts;
    using SnakeLadderApp.Models;
    using SnakeLadderApp.Services;
    using SplitwiseApp.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Client
    {
        public static void Main(string[] args)
        {
            int noOfSnakes;
            int noOfLadders;
            int noOfDice = 1;

            List<Snake> snakes = new List<Snake>();
            List<Ladder> ladders = new List<Ladder>();
            List<Player> players = new List<Player>();

            noOfSnakes = Int32.Parse(Console.ReadLine());
            string[] snakePostions = Console.ReadLine().Split(' ');

            noOfLadders = Int32.Parse(Console.ReadLine());
            string[] ladderPostions = Console.ReadLine().Split(' ');

            
            for (int i=0; i < 2 * noOfSnakes; i+=2)
            {
                int start = Int32.Parse(snakePostions[i]);
                int end = Int32.Parse(snakePostions[i+1]);
                Snake snake = new Snake(start, end);
                snakes.Add(snake);
            }

            for (int i = 0; i < 2 * noOfLadders; i+=2)
            {
                int start = Int32.Parse(ladderPostions[i]);
                int end = Int32.Parse(ladderPostions[i+1]);
                Ladder ladder = new Ladder(start, end);
                ladders.Add(ladder);
            }

            players.Add(new Player("P01", "Player1", 1));
            players.Add(new Player("P02", "Player2", 1));
            IDice dice = new Dice(noOfDice);

            Board board = new Board(snakes, ladders);
            SnakeLadderGameService snakeLadderService = new SnakeLadderGameService(board, players, dice);
            snakeLadderService.StartGame();

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
