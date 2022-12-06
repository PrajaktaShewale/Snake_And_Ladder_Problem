using System;
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
                Console.WriteLine("1.start " + "\n" + "2.DieRoll" + "\n" + "3.CheckPosition" + "\n" + "4.Winning Position" + "\n" + "5.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        StartGame st = new StartGame();
                        st.Game();
                        break;
                        case 2:
                            DieRoll roll = new DieRoll();
                        roll.dieroll();
                        break;
                    case 3:
                        CheckOption opt = new CheckOption();
                        opt.Check();
                        break;
                    case 4:
                        RepeatTillWinposition win = new RepeatTillWinposition();
                        win.WinPosition();
                        break;
                        default:
                        Flag = false;
                        break;
                }
            }
        }
    }
}