using System;   // ~ 를 사용하겠다 <- (System 을 사용하겠다) namespace system을 사용한다.
namespace Unity_C_  //namespace 이름공간
{
    internal class Player
    {
        
        static void Main(string[] args)
        {
                //플레이어가 공격할 때 주는 데미지 수치를 저장하고 싶다. 
               //변수 = 데이터를 저장하는 공간이다."기본 데이터"
              //변수가 데이터를 저장하기 위해서는 이름과 데이터 타입을 저장해주어야한다.
            int Damage = 10;    //(음수 or 양수 표현이 가능) int = 정수형 데이터를 저장할 수 있다.
            float time = 3.14f;     //소수 표현 가능. 실수형 변수
            string name = "한글"; //문자열을 저장하는 데이터 타입.
            bool Die = false;       // 참 혹은 거짓만 출력하는 함수

            byte sData = 127;  // -128 ~ 127
            //Console.WriteLine(sData);
            sData = (byte)(sData + 1);

            short ShortData = 32767;
            // Console.WriteLine(ShortData);

            ShortData = (short)(ShortData + 1);
            //Console.WriteLine(ShortData);

            //대소문자, Null 조심
            //변수는 숫자로 이름을 시작할 수 없습니다. 
            //변수의 이름을 작성할 때에는 의미있는 이름을 짓는 것이 좋다. 여러 사람이 코드를 보거나 내가 보았을 때 햇갈릴 수 있음.

            //처음 변수에 데이터를 할당하는 것을 초기화라고한다.

            var item = 123;
            var charcter = "이름";
            var isGirl = false;

            int num1 = 10;
            int num2 = 20;

            int sum;

            sum = num1 + num2;
            //Console.WriteLine(sum);

            int a = 10;
            int b = 20;
            int c = 3;

            int resulta = (a + b)/ c;
            

            Console.WriteLine("A와 B를 더한후 C로 나눈 결과:"+ c);

            
            
        }
    }
}
