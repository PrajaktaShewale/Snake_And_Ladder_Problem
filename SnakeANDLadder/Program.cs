﻿using System;
namespace SnakeANDLadder
{
    public class Programs
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while(Flag)
            {
                Console.WriteLine("Welcome to Snake And Ladder Game");
                Console.WriteLine("1.start " + "\n" + "2.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        StartGame st = new StartGame();
                        st.Game();
                        break;
                        default:
                        Flag = false;
                        break;
                }
            }
        }
    }
}