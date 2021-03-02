using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자
    class Program
    {
        // 오름차 순 : a > b -> 1, a==b -> 0, a < b -> -1
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;    //a, b 바꿈
            else if (a == b) return 0;
            else return -1;
        }
        // 내림차 순 : a < b -> 1, a==b -> 0, a > b -> -1
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;    //a, b 바꿈
            else if (a == b) return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++){
                for (int j = 0; j < DataSet.Length - (i + 1); j++){
                    // 비교하여 값 위치 변경 swap
                    if (comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            
            Console.WriteLine("Sorting......");
            // 버블 정렬 오름차순
            BubbleSort(array, new Compare(AscendCompare));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Sorting......");
            // 버블 정렬 내림차순
            BubbleSort(array, new Compare(DescendCompare));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
