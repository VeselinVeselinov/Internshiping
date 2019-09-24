using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    class Player
    {
        public int[] Divisor { get; set; }

        public string[] Gesture { get; set; }

        public string Log { get; set; }

        public string Move { get; set; }

        public Player(int[] divisor, string[]gesture, string move, string log)
        {
            Divisor = divisor;
            Gesture = gesture;
            Log = log;
            Move = move;
        }

        public void DoMove(bool isLost)
        {
            int log = int.Parse(Log);
            CheckForFizzBuzz(log, Move);
            isLost = CheckForMistake(log, Move);
            
        }

        public void CheckForFizzBuzz(int number, string input)
        {
            if ((number % 5 == 0 && input != "fizz") || (number % 7 == 0 && input != "buzz") || (number % 35 == 0 && input != "fizzbuzz"))
            {
                Log = "You lose";
            }
            else
            {
                Log = GenerateNumber().ToString();
            }
        }

        static bool CheckForMistake(int number, string input)
        {
            if ((number % 5 == 0 && input != "fizz") || (number % 7 == 0 && input != "buzz") || (number % 35 == 0 && input != "fizzbuzz"))
            {
                return true;
            }
            else return false;
        }

        public int GenerateNumber()
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(1, 101);
            return num;
        }
    }
}
