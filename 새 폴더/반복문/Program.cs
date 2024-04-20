using System.Threading.Channels;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl r r 변수 이름을 일괄적으로 변경해주는 단축키
            Console.WriteLine("반복할 횟수를 입력해주세요");
            int value = int.Parse(Console.ReadLine());
            for (int num = 1; num < value; num++)
            {
                Console.WriteLine($"반복중 : {num}");
            }
            Console.WriteLine("2중 for 반복문");
            //2중 for문
            for (int a = 1;  a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.WriteLine($"{a} x {b} = {a*b}");
                }
            }
            Console.WriteLine("구구단이죠?");
            //while 반복문
            int Wn = 0;
            int Wns = 0;
            Console.WriteLine("While 반복문");
            while (Wn < 5)
            {
                Wns += Wn;

                Wn++;
                Console.WriteLine(Wns);
            }

            // do while 반복문
            //만드시 do를 실행하고 while 조건 체크
            int index = 0;
            do
            {
                Console.WriteLine($"index = {index}");
                index++;
            }
            while (index < 10);
            {
                Console.WriteLine("흠");
            }

            // 무한 반복문
            // 무한 반복문은 발생하지 않게 주의
            
            //while (true) { } 

            //점프문 
            //break, continue ,return ,goto 이중 3개는 써봤는데 컨티뉴는 처음봄

            //break - 코드블럭 탈출 할 때 쓰인다.

            //contnue 반복문에서 쓰이고 사용시 반복문의 처음으로 돌아간다. 사실 잘 안씀.

            //특정 라인으로 이동하는 문 goto -> 사용  지양  순서가 꼬일 수도 있다.

            //return - 매서드를 종료하고, 매서드를 호출 한 곳으로 돌아가는 명령문



        }
    }
}
