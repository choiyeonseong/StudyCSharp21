using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitRepository\StudyCSharp21\SampleDir\SubFolder\a.dat";    // text file 생성 위치

            // 파일 쓰기
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));   // OpenOrCreate:열거나 생성 / Append:추가 / Create:생성 / Truncate:잘라내고입력

                sw.WriteLine($"int.MaxValue = {int.MaxValue}");
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요!");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일 생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일 쓰기 예외 발생 : {ex.Message}");
            }
            finally
            {
                sw.Close();
            }

            // 파일 읽기
            StreamReader sr = null;

            sr = new StreamReader(new FileStream(filePath, FileMode.Open,FileAccess.Read));
            Console.WriteLine($"File Size : {sr.BaseStream.Length} bytes");

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
