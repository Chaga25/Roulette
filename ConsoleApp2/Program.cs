using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Roulette r = new Roulette();
            r.Spin();
            //Random r = new Random();
            //int randNum = r.Next(0, 4);
            //Console.WriteLine(randNum);
            //int[] k = { 1, 2, 3 };
            //Console.WriteLine(k.Contains(randNum));
        }
    }
}
