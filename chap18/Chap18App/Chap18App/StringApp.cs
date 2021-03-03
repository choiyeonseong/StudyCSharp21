using System;

namespace Chap18App
{
    class StringApp
    {
        string temp2 = "Grobal Variable String";//var사용 불가
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습");

            // 기본선언
            string message1 = null;
            Console.WriteLine($"null문자열 :{message1}.");

            string message2 = String.Empty; // ""
            Console.WriteLine($"빈값문자열 :{message2}.");

            string oldPath = "C:\\Program Files\\Bandizip";    // 폴더, 파일경로
            string newPath = @"C:\Program Files\Bandizip";

            String greeting = "Hello World!";   //String = string
            // int = Int32
            var temp1 = "Local Variable String";    //var 지역변수에만

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine("hello");

            string s1 = "Hello";
            string s2 = "World";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = s1;
            string s4 = s3;
            s3 += "world!";
            Console.WriteLine(s4);

            string row = "Row1\r\nRow2\r\nRow3\r\n"; // standard
            Console.Write(row);

            string row2 = "Row11\r\nRow22\r\nRow33";  // 가장짧음
            Console.Write(row2);

            Console.WriteLine();
            Console.Write($"Row11{Environment.NewLine}Row222{Environment.NewLine}Row33");

            string oldline = "Test" + "Test2" + "Test3";
            string multiline = @"New Test
There are multiline
end.";

            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);

            Console.WriteLine($"\U0001F47D");   //👽

            // tuple book
            var book = (lastName: "박", firstName: "상현", title: "이것이 c# 이다.", company: "한빛미디어",
            releaseDate: "2018-07-01", price: 30000, page: 812);

            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.Write($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간, ");
            Console.WriteLine($"페이지수 {book.page}, 금액:{book.price: #,###}원");

            Console.WriteLine("문자열 조작(함수 사용)");
            
            string s5 = " Visual C# Express ";  // s5.Length = 19
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim());   // 앞뒤 공백 삭제
            
            var s6 = s5.Trim(); // s6.Length = 17 Visual C# Express
            Console.WriteLine(s6.Substring(7)); // C# Express
            Console.WriteLine(s6.Substring(7, 2));  // C#

            Console.WriteLine(s6.Replace("C#", "Basic"));   // Visual Basic Express
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic"));   // Visual Basic Express

            Console.WriteLine(s6.IndexOf("C")); // 7
            Console.WriteLine(s6.Length);    // 17
            Console.WriteLine(s6.ToUpper());    // VISUAL C# EXPRESS
            Console.WriteLine(s6.ToLower());    // visual c# express

            // null문자열 빈문자열
            Console.WriteLine("null/빈 문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty; // ""

            Console.WriteLine(str + nullstr);   // hello
            Console.WriteLine(nullstr == emptystr); // False

            try
            {
                //null값이 있는 string에는 equals메소드 사용 안됨
                Console.WriteLine(nullstr.Equals(emptystr));   // 예외발생
                Console.WriteLine(emptystr.Length); // 0
                Console.WriteLine(nullstr.Length);  // 예외발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }


        }
    }
}
