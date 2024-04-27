using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상화
{
    //몬스터를 상속 했을 떄
    //특정 몬스터만 갖고 있는 기능은 어떻게 해주면 좋을까?

    //인터페이스 
    //인터페이스의 이름은 첫 글자에 대문자를 I를 쓰고 이름을 작성하는 규칙이 있음.
    //인스턴스를 생성할 수 없음
    //특정 녀석만 소유할 수 있는 기능을 만들어 줘서, 그 기능을 갖고 있는 객체들만 사용할 수 있다.
    internal interface IFlayable
    {
        // 클래스에서 접근 지정자를 선언하지 않았을 때 => private 자동으로 선언
        // interface는 자동으로 public이 선언이 된다.
        void Fly();
    }
}
