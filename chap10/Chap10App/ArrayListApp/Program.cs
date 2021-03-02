using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList : 배열처럼 사용 가능, 크기 지정 없이 동적으로 메모리 할당
             추가-Add(), 삽입-Insert(), 삭제-RemoveAt() 쉬움*/

            ArrayList array = new ArrayList();
            // 추가
            /*            array.Add(80);
                        array.Add(74);
                        array.Add(81);
                        array.Add(90);
                        array.Add(34);
            */
            //초기화
            array = new ArrayList(new[] { 80, 74, 81, 90, 34 });

            // 삽입
            Console.WriteLine("81 추가");
            var loc = array.IndexOf(81);
            array.Insert(loc, 50);
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
            // 삭제
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);
            array.RemoveAt(loc);
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }
            // 정렬
            Console.WriteLine("정렬");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($"  {item}");
            }
        }
    }
}
