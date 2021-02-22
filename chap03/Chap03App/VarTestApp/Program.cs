using System;

namespace VarTestApp
{
    class Program
    {
        static float j = 100.5f;
        static void Main(string[] args)
        {
            Console.WriteLine($"값은 {j}입니다.");   // 전역변수

            var i = 100;    // 값에 따라 자료형을 자동으로 변환(지역변수로만 사용 가능)
            Console.WriteLine($"값은 {i}입니다.");
        }
    }
}