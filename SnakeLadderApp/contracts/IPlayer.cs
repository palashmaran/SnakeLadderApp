
namespace SnakeLadderApp.Contracts
{
    using SnakeLadderApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IPlayer
    {
        public abstract Boolean CanMove(Player player, Box box);
        public abstract void Move(Player player, Box box);
    }
}
