
namespace SnakeLadderApp.Services
{
    using SnakeLadderApp.Contracts;
    using SnakeLadderApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlayerService : IPlayer
    {
        public bool CanMove(Player player, Box box)
        {
            throw new NotImplementedException();
        }

        public void Move(Player player, Box box)
        {
            if (box.BoxType == BoxType.SNAKE)
            {
                player.Postion = box.Snake.End;
            }
            else if (box.BoxType == BoxType.LADDER)
            {
                player.Postion = box.Ladder.End;
            }
            else if (box.BoxType == BoxType.DESTINATION)
            {
                player.IsReached = true;
                player.Postion = box.Id;
            }
            else
            {
                player.Postion = box.Id;
            }
        }
    }
}
