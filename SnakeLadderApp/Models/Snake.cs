using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderApp.Models
{
    public class Snake
    {
        int start;
        int end;

        public Snake(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
    }
}
