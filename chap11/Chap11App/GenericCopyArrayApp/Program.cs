using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };  // 5개 int 배열
            int[] target = new int[source.Length];  // 5개 int 배열 초기화

            CopyArray(source, target);  // int 배열 복사
            Console.WriteLine("int 배열 복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 1.4f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f };
            float[] target3 = new float[source2.Length];

            CopyArray(source3, target3);
            Console.WriteLine("float 배열 복사");
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
        }

        private static void CopyArray<T>(T[] source, T[] target)
        // Generic Method : 어떤 타입이든 커버 가능
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
