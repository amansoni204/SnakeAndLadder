using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class SnakeLadder
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
        }
        public static int DiceThrown()
        {
            Random random = new Random();
            int diceOutput = random.Next(1, 7);
            return diceOutput;
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            int position = 0;
            Console.WriteLine("Dice Output :" + DiceThrown());
            Console.ReadLine();

        }
            
        
        


        
    }
}
