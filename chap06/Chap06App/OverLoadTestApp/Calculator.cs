using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----계산기-----");

            Console.Write("#int\t");
            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            Console.Write("#float\t");
            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");

            Console.Write("#double\t");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");

            Console.Write("#string\t");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");

            Console.WriteLine("#add parameter");
            int z = Calculator.Plus(3, 4, 5);
            Console.WriteLine($"3 + 4 + 5 = {z}");

            Console.WriteLine("#가변길이 매개변수");
            Console.WriteLine($"10까지의 합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10까지 배열의 합은 {Sum(arrs)}");

        }

        // 가변길이 매개 변수 - Using params
        private static int Sum(params int[] args)
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }

            return result;
        }

        private static int Sum(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        // return type이 object - return type이 뭔지 몰라서 -> Boxing
        private static /*object*/ double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        // Overloading - 이름만 같고 매개변수의 type은 다름
        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        // Parameter 개수 추가
        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        # region 불가능 - 매개변수 개수도 같고 타입도 같으면 Overloading 불가능
        /*
        private static long Plus(int v1, int v2)
        {
            long result = v1 + v2;
            return result;
        }

        private static int Plus(float v1, float v2)
        {
            int result = (int)(v1 + v2);
            return result;
        }
        */
        #endregion
    }
}
