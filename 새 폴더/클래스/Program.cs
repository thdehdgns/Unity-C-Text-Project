namespace 클래스
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //왜 클래스라는 개념이 도입되었는가?

            //조건문, 반복문, 배열... -> 계산기, 간단한 미니게임 만들 수 있습니다.

            //CharGpt 에게 물어보면 만들어줌.

            //조건문 , 반복문을 하나의 코드 반복하면 코드 줄 수가 너무 길어진다.

            // 새로운 기능 하나를 추가하려면 그 긴 코드를 전부 다 확인 해야합니다.

            //공통적인 기능을 하는 녀석들을 관리하고 싶어진다.

            //은행 이름 -> 농협,신한,기업... 

            //은행에 넣을 돈

            //입금, 출금

            //객체를 변수와 매소드로 묶어서 표현하는 사용자 자료형
            //클래스를 사용하는 이유?
            //공통된 특징을 가진 데이터에 속성을 다르게하여 기능을 표현하기 위해서 사용한다.
            Bank nhBank = new Bank("농협",10000);
            //nhBank.name = "농협";
            //nhBank.money = 10000;
            nhBank.PrintInfo();
            Bank kbBank = new Bank("국민",10000);
            //kbBank.name = "국민";
            //kbBank.money = 20000;
            kbBank.PrintInfo();

            //생성자 myClass = new 생성자("안녕하세요",0.01f);
            //Console.WriteLine($"{myClass.name}시간은 {myClass.time}");

            Bank myBank = new Bank("부산",10000);
            //Console.WriteLine($"{myBank.name}은행 {myBank.money}원");
            myBank.PrintInfo();
        }
    }//crtl M M 

    //클래스 선언
    //클래스를 선언하는 방법은 : class 클래스이름 {}
    
    
}
