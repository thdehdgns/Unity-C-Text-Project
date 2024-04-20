namespace 배열
{
    internal class Program
    {

        //배열 
        //변수를 선언한 목적은 데이터를 저장하고 사용하기 위해서
        //변수를 여러개 선언하는 것은 비효율적이다.
        //같은 데이터 타입을 받는 변수를 한번에 선언하기 위한 것이 배열 

        static void Main(string[] args)
        {
            // 배열의 선언 방법
            int[] array;

            //배열의 데이터를 넣어주는 것을 할당이라고 하는데 처음 데이터를 넣어주는 것을 초기화라고함.
            array = new int[3] {1 , 3 ,5 }; //0 1 2... 번지로 시작한다.
            int[] array2 = new int[] {10, 20, 30 };
            int[] array3 = { 100, 200, 300 };

            //배열의 사용, 반복문이랑 함께 사용할 때 좋다.
            for(int i =0; i< array.Length; i++)
            {
                Console.WriteLine($"{i}번 째 배열 값출력 : {array[i]}"); //좋다. 
            }
            // 배열의 길이.

            Console.WriteLine(array.Length);
            // 배열 클래스의 자신의 길이를 반환해준다.
            // 자신 배열이름.Length

            //2차원 배열 

            int[,] cell = new int[2, 3];
        } 
    }
}
