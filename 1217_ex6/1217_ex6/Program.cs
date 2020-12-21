using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력:");
            int num1 = 0;
            int num2 = 0;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            
            if(num1>0 && num2>0)
            {
                Console.WriteLine("출력");
                Console.WriteLine("1");
            }
            else if(num1 <0 && num2>0)
            {
                Console.WriteLine("출력");
                Console.WriteLine("2");
            }
            else if(num1<0 && num2 < 0)
            {
                Console.WriteLine("출력");
                Console.WriteLine("3");
            }
            else if(num1>0 && num2 < 0)
            {
                Console.WriteLine("출력");
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("출력");
                Console.WriteLine("해당없음");
            }

        }
    }
}
