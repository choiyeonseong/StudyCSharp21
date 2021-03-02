using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitCollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 컬랙션을 배열로 초기화 
            int[] arr = { 123, 456, 789 };
            Console.WriteLine("ArrayList");
            ArrayList list1 = new ArrayList(arr);
            foreach (var item in list1)
            {
                Console.WriteLine($"ArrayList : {item}");
            }

            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789 });

            Console.WriteLine("Stack");
            Stack stack = new Stack(arr);
            foreach (var item in stack)
            {
                Console.WriteLine($"ArrayList : {item}");
            }

            Console.WriteLine("ArrayList3");
            ArrayList list3 = new ArrayList() { 10, 20, 30, 40 };
            foreach (var item in list3)
            {
                Console.WriteLine($"ArrayList 3 : {item}");
            }
        }
    }
}
