using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 };
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("크기 변경");
            Array.Resize(ref array, 6);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("81 인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >= idx; i--)
            {
                array[i] = array[i - 1];
            }
            array[idx] = 50;


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            /*초기화 3가지*//*
            //1)
            //var array = new int[5]; // int[] ⊂ var        //가능
            *//*array[0] = 80;
                     array[1] = 74;
                     array[2] = 81;
                     array[3] = 90;
                     array[4] = 34;*//*
            //2)
            //var array = new int[] { 80, 74, 81, 90, 34 }; //가능

            //3)
            int[] array = { 80, 74, 81, 90, 34 };

            Console.WriteLine($"Type of Array : {array.GetType()}");
            Console.WriteLine($"Base Type of Array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Array.Sort(array);  //정렬 
            Console.WriteLine("오름차순 정렬");

            var idx = 0; // foreach는 index값을 활용할 수 없음 -> index값을 따로 설정
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }

            Array.Reverse(array);
            Console.WriteLine("내림차순 정렬");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int id = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {id}");

            id = Array.IndexOf(array, 100);
            Console.WriteLine($"100의 인덱스 : {id}");

            Array.Clear(array, 3, 2);
            Console.WriteLine("배열 삭제");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }*/


        }
    }
}
