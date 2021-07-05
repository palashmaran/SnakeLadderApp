
namespace SnakeLadderApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Player
    {
        string id;
        string name;
        int postion;
        bool isLock;
        bool isReached;
        public Player(string id, string name, int postion)
        {
            this.id = id;
            this.name = name;
            this.postion = postion;
            this.isLock = true;
            this.isReached = false;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Postion { get => postion; set => postion = value; }
        public bool IsLock { get => isLock; set => isLock = value; }
        public bool IsReached { get => isReached; set => isReached = value; }
    }
}
