using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("요일을 입력하세요 : ");    // 다음줄로 안내려감
                string day = Console.ReadLine();       // 콘솔에서 입력값을 변수에 넣음

                if (day == "끝") break;  // 프로그램 종료

                // if문
                if (day == "월요일")
                {
                    Console.WriteLine("월요일입니다");
                }
                else if (day == "화요일")
                {
                    Console.WriteLine("화요일입니다");
                }
                else if (day == "수요일")
                {
                    Console.WriteLine("수요일입니다");
                }
                else if (day == "목요일")
                {
                    Console.WriteLine("목요일입니다");
                }
                else if (day == "금요일")
                {
                    Console.WriteLine("금요일입니다");
                }
                else if (day == "토요일")
                {
                    Console.WriteLine("토요일입니다");
                }
                else if (day == "일요일")
                {
                    Console.WriteLine("일요일입니다");
                }
                else
                {
                    Console.WriteLine("요일이 아닙니다");
                }

                //switch문
                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일입니다");
                        break;
                    case "화요일":
                        Console.WriteLine("화요일입니다");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일입니다");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일입니다");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일입니다");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일입니다");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일입니다");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다");
                        break;
                }
                Console.WriteLine($"{day}입니다");
            }
        }
    }
}
