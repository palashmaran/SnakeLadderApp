
namespace SplitwiseApp.Services
{
    using SnakeLadderApp.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dice : IDice
    {
        int noOfDice;
        public readonly int DEFAULT_NO_OF_DICE = 1;
        public readonly int NUMBER_IN_DICE = 6;

        public Dice()
        {
            this.noOfDice = DEFAULT_NO_OF_DICE;
        }
        public Dice(int noOfDice)
        {
            this.noOfDice = noOfDice;
        }
        public int Throw()
        {
            var random = new Random();
            return 1 + random.Next(NUMBER_IN_DICE * noOfDice);
        }
    }
}
