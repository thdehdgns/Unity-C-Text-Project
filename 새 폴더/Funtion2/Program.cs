namespace Funtion2
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

            //static void Add(int a, int b)
            //{
            //    int sum = a + b;
            //    Console.WriteLine(sum);
            //}

            //boolean 타입 

            bool isboy = true;



            string mystring = Console.ReadLine();
            Console.WriteLine(mystring);
            int coinnumber = int.Parse(Console.ReadLine()); //"1"이 int 1로 변환되어서 coinnumber

            //ctrl + k + c 일괄 주석 처리
            //ctrl + k + u 일괄 주석 해제
            //art를 누른 상태에서 마우스 커서: 이동 일괄 처리 기능
            //이동하고 싶은 줄을 드래그 후 알트를 누르고 방향키를 누르면 줄 이동이 가능함

            //코인넘버
            if (coinnumber == 1)
            {
                Console.WriteLine("왼손");
            }
            else if (coinnumber == 2)
            {
                Console.WriteLine("오른손"); 
            }

            //두 수를 비교하기

            bool Test = 10 > 25;    //false
            bool issame = 10 == 10; //true 

            int coin = int.Parse(Console.ReadLine());
            int coin2 = int.Parse(Console.ReadLine());
            if(coin < coin2)
            {
                Console.WriteLine(coin+"이"+coin2+"보다 작음");
            }
            else if(coin > coin2)
            {
                Console.WriteLine(coin+"이"+coin2+"보다 큼");
            }

            //Console.WriteLine(BooleanTypeAndOperator(3 ,5, 6)); 
            

            //반환 값 함수의 이름()
            //{
            //  코드블럭
            //  실제로 코드를 처리하는 부분을 코드블럭이라고 한다. 
            //}

            //반환 값...
            //함수를 실행하고 나서 결과 값을 반환해주고 싶으면, void 대신 변환해주고 싶으면 데이터 타입(자료형)을 넣어주면 된다.
            //반환 값이 있는 함수는 반드시 해당 데이터를 return 해줘야 합니다.

           
            
        }
        static void BooleanTypeAndOperator(int a, int b, int n)
        {
            //두 수를 더한 값이 n보다 크거나 같으면 true를 리턴하고, 아니면 false를 리턴하도록 만드는 함수.
            if (a + b < n)
            {
                
            }
            else if (a + b > n)
            {
                
            }

        }
    }
}
