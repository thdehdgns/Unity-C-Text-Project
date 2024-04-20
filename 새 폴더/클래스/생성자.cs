using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    internal class 생성자
    {

        public string name;
        public float time;
          

        public 생성자(string name, float time)
        {
            //this 는 자기 자신의 클래스를 의미
            //매개변수와 멤버변수의 이름이 같을 때 사용하기 위한 목적으로 사용한다.
            //본인 클래스로 메개 변수로 사용하기 위해서도 사용.
            this.name = name;
            this.time = time;
        }
    }
}
