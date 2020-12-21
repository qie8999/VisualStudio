using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("현재의 달을 입력받고 계절을 출력하는 프로그램을 작성하시오" );
            Console.WriteLine("12, 1, 2 : 겨울");
            Console.WriteLine("3, 4, 5 : 봄");
            Console.WriteLine("6, 7, 8 : 여름");
            Console.WriteLine("9, 10, 11 : 가을");
            Console.WriteLine("----------------------------------");
            Console.Write("월 입력 : ");
            int month = 0;
            month = int.Parse(Console.ReadLine());

            switch (month) {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("겨울입니다");
                    break;
                case 3: 
                case 4: 
                case 5:
                Console.WriteLine("봄입니다");
                    break;
                case 6: 
                case 7: 
                case 8:             
                Console.WriteLine("여름입니다");
                    break;
                case 9:
                case 10:
                case 11:
              Console.WriteLine("가을입니다");
                        break;  
                
                    }



        }
    }
}
