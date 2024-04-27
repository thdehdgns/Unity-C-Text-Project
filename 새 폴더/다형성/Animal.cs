using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다형성
{
    class Worker//동물을 케어해준다.ㄴ
    {
        public void CareAnimal(Animal animal) //오버로딩 ... 오버로딩으로 수많은 데이터 선언.. 많다..
        {
            //동물을 돌봐준다.
            animal.Hp = animal.Hp + 1;
        }

        public void Function(Animal animal)
        {
            //동물은 각자 동물이면서 호랑이 일수도 있고, 독수리 일수도 있고, 상어 일수도 있고.

            //(Animal -> 각자의 클래스 변환)
            //as 키워드, is 키워드

            //is 앞에 데이터 타입과 is 뒤에 데이터 타입이 같으면 True 반환, 다르면 false 반환.
            if( animal is Tiger)
            {
                Console.WriteLine("호랑이");
            }
            else if(animal is Eagle)
            {
                Console.WriteLine("독수리");
            }
            else if(animal is Shark)
            {
                Console.WriteLine("상어");
            }
            else
            {
                Console.WriteLine("해당하는 동물이 없습니다.");
            }

            if(null ==animal as Tiger) // naimal이 Tiger타입이면 해당 타입을 animal에 넘겨주고 해당 타입이 아니면 null을 넣어준다.
            {
                // animal 갖는 형태를 as 뒤에 클래스로 확정하고 싶을 때 사용
                Console.WriteLine("호랑이 아님;;");
                //실수로 잘못된 데이터가 들어갔을 때는 Null
            }
        }
    }

    internal class Animal
    {
        public int Hp;
    }

    class Tiger : Animal
    {
        void Run() { }
    }

    class Shark : Animal 
    {
        void Swim() { }
    }

    class Eagle : Animal
    {
        void Fly() { }
    }
}
