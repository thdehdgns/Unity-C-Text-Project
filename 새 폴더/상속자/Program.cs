using 상속자;

namespace 상속
{
    //상속(Inheritance)
    //기존 클래스의 속성(함수)과 기능(함수)를 자식한테 물려주는 문법
    //csae1. 클래스에도 반복적으로 선언되는 경우가 빈번함.
    //csae2-> 상속 문법 사용. protected, public, private
    //csae3 상속의 생성자
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank("농협",10000); //모든 은행으 공통적으로 갖는 기능과 속성을 기술
            myBank.Show();
            CenterBank centerBank = new CenterBank("중앙은행","부모",10000,0);// 중안은행만 갖는 기능과 속성을 기술.
            centerBank.Show();
            Console.WriteLine($"d");


            //개발할 때 중앙은행에서 에러 -> CenterBank
            //전체 은행에서 에러가 발생했을 때 -> Bank
        }
    }
}