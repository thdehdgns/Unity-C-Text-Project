using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상화
{
    // 추상 클래스는 자체로는 객체화 불가능 
    //상속을 위한 목적으로 생선된 클래스
    //abstract 클래스를 상속받는 자식 클래스들이 반드시 가져야 할 기능, 속성을 알려줌
    internal abstract class 추상_클래스
    {
    }

    abstract class car
    {
        // abstract 키워드를 선언해서, car를 상속하는 녀석이 반드시 구현해야할 클래스를 지정해줄수 있다.
        //단기간에 큰 영향을 주진 않지만.
        //규모가 큰 협업을 하거나, 3달 뒤에 클래스르 다시 볼 때, 클래스의 기능을 강제하기 때문에
        protected abstract void SpeedUp();
        protected abstract void SpeedDown();
    }
        
    class Truck : car
    {

        protected override void SpeedDown()
        {

        }

        protected override void SpeedUp()
        {

        }

    }
}
