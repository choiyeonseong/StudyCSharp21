using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int x = 108, y = 0;
            int result = 0;


            // 한번에 여러개의 예외가 처리되지는 않음
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
                result = x / y;
                Console.WriteLine($"결과 {result}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"예외발생 : {e.Message}");
            }
            catch (Exception e) // 이거 하나만 써도 됨
            {
                Console.WriteLine($"예외발생 : {e.Message}");
            }

            string strVal = "Hello World";
            string splitVal = strVal.Substring(6, 5);
            Console.WriteLine($"자른 문자 : {splitVal}");

            try
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화 하세요. : {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화 하세요. : {ex.Message}");
                

            }
        }
    }
}