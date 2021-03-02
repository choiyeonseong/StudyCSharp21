using System;

namespace DelegateChainApp
{
    class Program
    {
        delegate void AllCalc(int x, int y);    // 대리자 선언

        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!!");

            //Plus(10, 5);
            //Minus(10, 5);
            //Multiple(10, 5);
            //Divide(10, 5);

            // 대리자 체인 연결
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;
            allCalc(10, 5); // 하나의 호출로 여러가지 일을 한꺼번에 처리할 수 있음 (winform에서 많이 사용)

            Console.WriteLine("\n곱셈 메서드 제거");
            allCalc -= Multiple;
            allCalc(10, 5); // 곱셉 메소드 제거 후 실행
        }
    }
}