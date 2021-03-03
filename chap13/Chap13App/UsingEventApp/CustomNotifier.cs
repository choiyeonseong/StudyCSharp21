using System;
using System.Collections.Generic;
using System.Text;

namespace UsingEventApp
{
    /// <summary>
    /// 대리자와 이벤트 차이점
    /// 이벤트 - 클래서 외부에서 호출 불가    -   객체의 상태 변화나 사건의 발생 통지
    /// 대리자 - public, internal인 경우 class 외부에서도 호출 가능    -   콜백
    /// => Winform에서 사용되는 기능
    /// </summary>

    delegate void EventHandler(string message); //메시지 받아서 처리하는 대리자 선언.

    class CustomNotifier
    {
        // 이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened;    // 대리자의 인스턴스 이벤트

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) // 3, 6, 9로 떨어지는 값
            {
                SomethingHappened($"{number} : 짝~!");   // 이벤트 사용(로직은 없음)
            }
            else { SomethingHappened($"{number}"); }    // 이벤트 사용
        }
    }
}
