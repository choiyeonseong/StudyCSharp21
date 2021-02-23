using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");    // 다음줄로 안내려감
                string line = Console.ReadLine();       // 콘솔에서 입력값을 변수에 넣음

                if (line == "quit") break;  // 프로그램 종료

                int number = 0;
                int.TryParse(line, out number);  // 숫자인 경우 숫자 반환, 문자인 경우 0 반환
                // todo 아래 로직을 수정하세요
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else Console.WriteLine("0보다 큰 홀수");
                }
                else if (number < 0)
                {
                    Console.WriteLine("0보다 작은 수");
                }
                else Console.WriteLine("범위를 벗어난 수");
                // todo 마지막
            }

            Console.WriteLine("계산종료");
        }
    }
}
