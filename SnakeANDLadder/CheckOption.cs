﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeANDLadder
{
    internal class CheckOption
    {
        public void Check()
        {
            int position = 0;   
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("die roll value "+ die);
            int num = random.Next(1, 4);
            Console.WriteLine("Player get option "+ num);
            switch(num)
            {
                case 1://No play
                    Console.WriteLine("Player Stays in the Same Position");
                    break;
                    case 2://move ahead
                    position += die;
                    Console.WriteLine("Player moves ahead and player position is "+ position);
                    break;
                    default:
                    position -= die;
                    Console.WriteLine("Player moves behind and player position is " + position);
                    break ;
            }
        }
    }
}
