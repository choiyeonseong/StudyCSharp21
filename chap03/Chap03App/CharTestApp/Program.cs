using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자
            char ch1 = 'T', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");

            //문자열
            string str1 = "Hello, World!";
            Console.WriteLine($"{str1}");

            bool isCorrect = false; //true
            Console.WriteLine(isCorrect);
            if (isCorrect)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
        }
    }
}
