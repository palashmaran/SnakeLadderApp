using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderApp.Models
{
    public class Box
    {
        int id;
        private Snake snake;
        private Ladder ladder;
        private BoxType boxType;

        public Box(int id)
        {
            this.Id = id;
            this.boxType = BoxType.DEFAULT;
        }

        public int Id { get => id; set => id = value; }
        public Snake Snake { get => snake; set => snake = value; }
        public BoxType BoxType { get => boxType; set => boxType = value; }
        public Ladder Ladder { get => ladder; set => ladder = value; }
    }
}
