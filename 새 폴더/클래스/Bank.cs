using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{



    class Bank
    {
        //멤버 변수 : 같은 클래스에 소속된 메소드(함수)들이 이 변수를 공용으로 사용할 수 있다.
        public string name;
        public int money;

        //접근 지정자.
        // public   :외부에서 클래스를 통해 접근 허용한다
        // private  :외부에서 클래스 접근을 허용하지 않는다. 자식 클래스에도 접근이 불가하다.
        // protected    :외부에서 클래스 접근을 허용하지 않고 자식 클래스 에는 접근을 허용한다.   

        //접근 지정자를 왜 사용하는가?
        //기능을 제한하는 것도 기능이다.
        //사람은 항상 실수를 할 수도 있다. 사람이 할 수 있는 실수를 원천적으로 막고싶음.
        //기능을 제한하는 기능을 구현하면 실수 하는 것을 막을 수 있다.

        //생성자 오버로딩
        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
        

        public void Deposit(int depositmoney)
        {
            money = money + depositmoney;

        }
        //외부에서 이 클래스를 사용하는 사람이 알 필요가 없는 녀석을 숨겨 두는 것.
        private void InternalFunc()
        {
            //ATM 출금 해줘.
            //소리를 내고, 돈을 찾는 것 같은 시간 후에 출금.
        }

        public void Withdraw(int withdrawmoney)
        {
            if (money < withdrawmoney)
            {
                Console.WriteLine("통장 잔고보다 큰 금액을 인출하려고 했습니다.");
                return;
            }
            money = money - withdrawmoney;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name}은행에 {money}원이 들어있습니다.");
        }
    }
}
