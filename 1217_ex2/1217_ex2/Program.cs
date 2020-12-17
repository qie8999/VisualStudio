using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sec = 0;
            Console.WriteLine("입력 : ");
            sec = int.Parse (Console.ReadLine()) ;
            //sec =s.nextInt();
            int min = sec / 60;
            int sec2 = sec % 60;
                        
            Console.WriteLine("출력:"+min+"분" + sec2 + "초");


        }
    }
}
