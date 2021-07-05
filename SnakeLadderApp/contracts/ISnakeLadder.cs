
namespace SplitwiseApp.contracts
{
    using SnakeLadderApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISnakeLadderGame
    {
        public abstract void StartGame();
        public abstract void EndGame(Player player);
    }
}
