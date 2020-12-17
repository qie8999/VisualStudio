using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단 입력 : ");
            int aa = int.Parse(Console.ReadLine());
            int bb = 0;
            int gugu = aa * bb;

            for(bb=0; bb<9; bb++) {
               gugu = aa * (bb + 1);
                Console.WriteLine(aa + "x" + bb + "=" + gugu);
            }
            

        }
    }
}
