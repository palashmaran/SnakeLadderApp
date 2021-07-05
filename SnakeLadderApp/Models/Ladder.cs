namespace SnakeLadderApp.Models
{
    public class Ladder
    {
        int start;
        int end;

        public Ladder(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
    }
}