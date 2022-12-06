using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeANDLadder
{
    internal class DieRoll
    {
        public void dieroll()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("You get number "+ die);
        }
    }
}
