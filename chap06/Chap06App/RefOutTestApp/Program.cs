using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 3;
            int q = 0, r = 0;
            Divide(a, b, out q, out r);
            //Divide(a, b, ref q, ref r);

            Console.WriteLine($"{a} = {b} * {q} + {r}");

            bool isSucceed = int.TryParse("1000.74", out int result);   // 오류가 안나서 안정적임
            Console.WriteLine($"변환 결과 : {isSucceed}, result 값 : {result}");
        }
       
        static void Divide(int a, int b, out int quotient, out int remainder)   // 출력 parameter
        {
            quotient = a / b;
            remainder = a % b;

            return;
        }
        /*static void Divide(int a, int b, ref int quotient, ref int remainder)   // 출력 parameter
        {
            quotient = a / b;
            remainder = a % b;

            return;
        }*/
    }
}
