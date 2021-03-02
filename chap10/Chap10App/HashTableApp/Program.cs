using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");
            /*Hashtable : 키와 값의 쌍, 사전*/
            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";
            // 키를 넣으면 값이 나옴
            Console.WriteLine(ht["일"]);
            Console.WriteLine(ht["이"]);
            Console.WriteLine(ht["삼"]);
            Console.WriteLine(ht["사"]);

            // Hashtable을 반복문으로 출력, 순서는 중요하지 않음(정렬도 X)
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
