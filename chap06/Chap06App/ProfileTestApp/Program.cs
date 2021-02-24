using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("최연성", "010-3901-3464");

            if (PrintProfile(null, "333-4444-55555") == -1)
            {
                Console.WriteLine("*출력시 오류 발생*");
            }
            
            // 명명된 매개변수 - 가독성, 순서변경 가능, 정확한 명시
            PrintProfile(phone: "010-9999-9999", name: "홍길동");

            // 선택적 매개변수 - defalt값 설정 가능, 모호함 발생
            PrintProfile("홍기동");
            //PrintProfile("010-2325-3464");
            PrintProfile(phone: "010-2325-3464");
        }

        public static int PrintProfile(string name = "홍길동", string phone = "010-7979-7979")
        // public static int PrintProfile(string name, string phone = "010-7979-7979)  //가능 
        // public static int PrintProfile(string name = "홍길동", string phone)        //불가능 - method선언시 뒤에있는 prameter부터 선택적 매개변수 설정 가능
        {
            if (string.IsNullOrEmpty(name)) // IsNullOrEmpty : null이거나 비었으면 True
            {
                Console.WriteLine("이름을 정확히 입력하세요!");
                return -1;
            }
            // 프로필 출력
            Console.WriteLine($"이름 : {name}\n번호 : {phone}");
            return 0;
        }
    }
}