using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week14_2
{
    class Program
    {
        static void caculate(int s)
        {
            Console.WriteLine($"10!(階乘)={s}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week14_2");
            int s = 1*2*3*4*5*6*7*8*9*10;
            caculate(s);
            Console.ReadLine();
        }
    }
}
