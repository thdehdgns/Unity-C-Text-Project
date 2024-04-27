namespace 추상화
{
    // abstract 추상 클래스, interface 클래스 학습 
    // 상속을 쓰는 가장 쉬운 방법 : 모든 공통된 데이터를 묶는 하나의 클래스를 만드는 것.
    // 클래스 2개를 생성한 후 그 둘 공통점을 묶어서 부모 클래스르 만든다.

    // 몬스터. (공통 클래스) -몬스터가 난다.
    // 몬스터_슬라임, 몬스터_박쥐 ...
    // 날 수 없는 박쥐가 있을 수도????
    // 상속한 데이터는 물려주기 때문에 불 필요한 데이터를 소유하게 됩니다.

    // abstract, interface

    class Monster
    { 

    }

    //C# 상속... 이중 상속을 못하게 막고있음.
    class Bat : Monster, IFlayable  
    {
        public void Fly()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}