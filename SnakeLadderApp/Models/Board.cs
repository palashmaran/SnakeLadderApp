using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderApp.Models
{
    public class Board
    {
        private int startBoxId;
        private int endBoxId;
        private List<Snake> snakes;
        private List<Ladder> ladders;
        Dictionary<int, Box> boxList;
        private readonly int DefaultStartBoxId = 1;
        private readonly int DefaultEndBoxId = 100;

        public int StartBoxId { get => startBoxId; set => startBoxId = value; }
        public int EndBoxId { get => endBoxId; set => endBoxId = value; }

        public Board(List<Snake> snakes, List<Ladder> ladders)
        {
            this.StartBoxId = DefaultStartBoxId;
            this.EndBoxId = DefaultEndBoxId;
            this.snakes = snakes;
            this.ladders = ladders;
            this.boxList = new Dictionary<int, Box>();
        }

        public Board(int startBoxId, int endBoxId, List<Snake> snakes, List<Ladder> ladders)
        {
            this.StartBoxId = startBoxId;
            this.EndBoxId = endBoxId;
            this.snakes = snakes;
            this.ladders = ladders;
            this.boxList = new Dictionary<int, Box>();
        }

        public Box GetBox(int boxId)
        {
            if (boxId > endBoxId)
                boxId = endBoxId;

            return boxList[boxId];
        }

        public void IntitalizeBoard()
        {
            for(int i=startBoxId; i<=endBoxId; i++)
            {
                Box box = new Box(i);
                if(i == startBoxId)
                {
                    box.BoxType = BoxType.SOURCE;
                }

                if(i == endBoxId)
                {
                    box.BoxType = BoxType.DESTINATION;
                }

                boxList.Add(i,box);
            }

            foreach (var snake in snakes)
            {
                Box snakeHead = boxList[snake.Start];

                snakeHead.Snake = snake;
                snakeHead.BoxType = BoxType.SNAKE;
                
                boxList[snake.Start] = snakeHead;
            }

            foreach (var ladder in ladders)
            {
                Box ladderStart = boxList[ladder.Start];

                ladderStart.Ladder = ladder;
                ladderStart.BoxType = BoxType.LADDER;
                
                boxList[ladder.Start] = ladderStart;
            }
        }
    }
}
