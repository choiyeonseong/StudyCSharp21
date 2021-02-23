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

            PrintProfile(null, "333-4444-55555");
        }

        public static void PrintProfile(string name, string phone)
        {
            if (string.IsNullOrEmpty(name)) // IsNullOrEmpty : null이거나 비었으면 True
            {
                Console.WriteLine("이름을 정확히 입력하세요!");
                return;
            }
            // 프로필 출력
            Console.WriteLine($"이름 : {name}\n번호 : {phone}");
        }
    }
}