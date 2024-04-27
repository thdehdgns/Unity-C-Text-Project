namespace 메소드_심화
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //클래스 변수 이름에 .을 붙이면 클래스 멤버에 접근
            //접근 지정자가 허용하는 데이터만 접근이 가능하다.


            int shaerNumber = 0;
            int remainderNumber = 0;

            Parent parent = new Parent();
            parent.Method1();
            parent.Method2();
            parent.Divide(3, 2, ref shaerNumber, ref remainderNumber); // ref는 할당되지 않은 변수를 매개 변수로 넘겨줄 수 없지만
            parent.Divide2(3,2, out shaerNumber, out remainderNumber); // out는 매개 변수에 선언하면서 넘겨줄 수 있다.
                                                                       // out 키워드를 사용해서 총을 쐈을 때 충돌한 지점에 정보를 out 키워드로 반환.

            Console.WriteLine($"나눈 결과 값 확인 : 몫:{shaerNumber} \n나머지:{remainderNumber}");

            Parent child = new Child();
            child.Method1();
            child.Method2();
        }
    }
}