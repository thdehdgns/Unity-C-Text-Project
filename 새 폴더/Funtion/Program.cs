using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //함수를 왜 사용하는가?

            // Console.WriteLine(); 콘솔창에 텍스트를 출력해주는 것
            // 함수는 반복적인 실행을 줄이기 위해 사용. 
            //결과 값을 반환할 수도 있고 안할 수도 있다.

            int a = 10;
            int b = 20;

            //반환 값이 없는 함수]
            void start() { }
            void update() { }

            //반환 값이 있는 함수
            Console.WriteLine("Text");

            static void Add(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
        }
    }
}
