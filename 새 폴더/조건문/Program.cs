namespace 조건문
{
    internal class Program
    {
        // Shift + Art + 키보드 방향키
        // Ctrl + k + c = 전체 주석 처리
        // Ctrl + k + u = 주석 해제

        //if , switch
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a == 1)
            {
                Console.WriteLine("a=1이다");

            }
            else
            {
                Console.WriteLine("a=1이 아님");
            }
            Console.WriteLine("1~100사이 숫자를 입력해주세요.");
            
            //if 문 뒤에 ;를 붙이면 코드를 닫은 처리라서 다음 문장이 실행됨.
            //뭔가 C#이랑 C++이랑 너무 다른 듯.
            int b = int.Parse(Console.ReadLine());  //입력
            
            if(b <=29)
            {
                Console.WriteLine("낙제");
            }
            else if(b >=30)
            {
                Console.WriteLine($"현재 숫자:{b} = c");
            }
            else if(b >=50)
            {
                Console.WriteLine($"현재 숫자:{b}= b");
            }
            else if (b >= 80)
            {
                Console.WriteLine($"현재 숫자:{b} = A");
            }

            //Switch ~case 문 
            //Switch에 조건을 검사할 변수 설정.
            // 변수의 조건에 해당하는 놈을 Case에 설정
            //조건을 모두 만족하지 않으면 default로 넘어감 
            // break 반복문 탈출

            Console.WriteLine("Switch문을 테스트 하기 위한 숫자 입력");
            int Swn = int.Parse(Console.ReadLine()); 
            
            switch( Swn )   //장점 특정 값만을 입력했을 때 사용하면 편함. 단점 ~이상 이하가 안되어서 선택지? 그런용도 Not bad
            {
                case 1:
                    Console.WriteLine("개신기하네 이걸 왜 안쓰고 있었지?");
                    break;
                case 2:
                    Console.WriteLine("흠 if랑 Switch랑 장단점이 있다.");
                    break;
            }
            


        }
    }
}
