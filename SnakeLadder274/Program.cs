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
            int PlayerPosition = 0;
            Console.WriteLine("lets play! \nPlayerPosition=" + PlayerPosition);

            Random random = new Random();
            int Dice = random.Next(1, 7);
            Console.WriteLine("after die rolles the number =" + Dice);
            Console.ReadLine();
        }
    }
}
