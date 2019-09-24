using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Computer
    {
        public int GenerateNumber()
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(1, 101);
            return num;
        }
    }
}
