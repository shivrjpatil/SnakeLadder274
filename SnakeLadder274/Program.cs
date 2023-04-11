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
            GamePlay winner = new GamePlay();
            winner.TwoPlayer();
            Console.ReadLine();
        }
        public class GamePlay
        {
            int player1Position = 0, player2Position = 0, turn = 1;
            Random random = new Random();
            const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
            public void start()
            {
                Console.WriteLine("Lets Start the Game");
                Console.WriteLine("Player is at starting position ");
            }
            public int DieRoll()
            {
                int dieRoll = random.Next(1, 7);
                return dieRoll;

            }
            public void Turn()
            {
                int turn = random.Next(0, 2);
                if (turn == 1)
                {
                    this.player1Position += DieRoll();
                }
                else
                {
                    this.player2Position += DieRoll();
                }
            }
            public void TwoPlayer()
            {
                while (player1Position != WINNING_POSITION && player2Position != WINNING_POSITION)
                {
                    int checkOption = random.Next(0, 3);
                    switch (checkOption)
                    {
                        case NO_PLAY:
                            break;
                        case LADDER:
                            int die = DieRoll();

                            if (turn == 1)
                            {
                                this.player1Position += die;
                                if (player1Position > WINNING_POSITION)
                                    this.player1Position -= die;
                                Console.WriteLine("player one position:" + player1Position);
                            }
                            else
                            {
                                this.player2Position += die;
                                if (player2Position > WINNING_POSITION)
                                    this.player2Position -= die;

                            }
                            Console.WriteLine("player two position:" + player2Position);
                            break;
                        case SNAKE:
                            int die1 = DieRoll();
                            if (turn == 1)
                            {
                                this.player1Position -= die1;
                                if (player1Position < 0)
                                    this.player1Position = 0;
                                Console.WriteLine("player one position :" + player1Position);
                            }
                            else
                            {
                                this.player2Position -= die1;
                                if (player2Position < 0)
                                    this.player2Position = 0;

                            }
                            Console.WriteLine("plyer two position:" + player2Position);
                            Turn();
                            break;
                    }
                }
                if (player1Position == WINNING_POSITION)
                    Console.WriteLine("Player 1 won the snake and ladder game with score:{0} ", player1Position);
                else
                    Console.WriteLine("Player 2 won the snake and ladder game with score:{0} ", player2Position);
            }

        }
    }
}


