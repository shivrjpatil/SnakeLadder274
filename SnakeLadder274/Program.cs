using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and Ladder Simulator ");
            int PlayerPosition = 0, count = 0;
            const int NoPlay = 0, Ladder = 1, Snake = 2, WinningPosition = 100;
            Console.WriteLine("lets play! \nPlayerPosition=" + PlayerPosition);

            while (PlayerPosition < WinningPosition)
            {
                Random random = new Random();
                int Dice = random.Next(1, 7);
                Console.WriteLine("after die rolles the number =" + Dice);
                count++;


                int check = random.Next(0, 3);
                Console.WriteLine("Option for the user=" + check);

                switch (check)
                {
                    case NoPlay:
                        PlayerPosition += 0;
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;

                    case Ladder:
                        PlayerPosition += Dice;
                        if (PlayerPosition > WinningPosition)
                        {
                            PlayerPosition = WinningPosition - PlayerPosition;
                            if (PlayerPosition == Dice)
                                Console.WriteLine("Player Position =" + PlayerPosition);
                        }
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;

                    case Snake:
                        PlayerPosition -= Dice;
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;
                }
            }
            Console.WriteLine("The number of times Dice rolled=" + count);
            Console.ReadLine();
        }
    }
}
