using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");

            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");

            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");

            Console.WriteLine($"후치 증가 값은 {result++}");    // 후치 증가 연산
            Console.WriteLine($"전치 증가 값은 {++result}");    // 전치 증가 연산

            Console.WriteLine($"전치 감소 값은 {--result}");    // 전치 감소 연산
            Console.WriteLine($"후치 감소 값은 {result--}");    // 후치 감소 연산
            Console.WriteLine($"현재 숫자는 {result}");
        }
    }
}
