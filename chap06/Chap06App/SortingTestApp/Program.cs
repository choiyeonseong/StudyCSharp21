using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;

            Console.WriteLine($"Before Swap {x}, {y}");

            // Call by Value
            Program.Swap(x, y); // 정렬 기반

            Console.WriteLine($"After Swap {x}, {y}");

            // Call by Reference (= Call by Address)
            Program.Swap_ref(ref x, ref y); // 정렬 기반

            Console.WriteLine($"After Swap_ref {x}, {y}");
        }

        private static void Swap(int p1, int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }

        private static void Swap_ref(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }  
    }
}
