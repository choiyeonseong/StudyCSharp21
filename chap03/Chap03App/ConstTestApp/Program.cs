using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{
    class Program
    {
        enum Season
        {
            봄 = 1000,
            여름 = 2000,
            가을 = 3000,
            겨울 = 4000
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592; // 값을 변경할 수 없는 상수
            Console.WriteLine($"원주율의 값은 {PI}");

            Season mySeason = Season.여름;    // (Season) 2000;
            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a = 0;  // null을 넣을수 없음
            Console.WriteLine($"a는 {a}");
            int? b = null;  // ? : nullable
            Console.WriteLine($"b는 {b}");

            
        }
    }
}
