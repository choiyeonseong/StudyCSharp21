using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값을 변환한 int값은 {inCastVal}");

            inCastVal += 5; // 32767 + 5 = 32772 -> -32764
            short shCastVal = (short)inCastVal; 
            Console.WriteLine($"int값을 변환한 short값은 {shCastVal}");    // Overflow

            float flVal = 3.141592f;    //float : f or F 써야함
            inCastVal = (int)flVal;
            Console.WriteLine($"float을 변환한 int값은 {inCastVal}");

            double dlVal = inCastVal;   //3
            Console.WriteLine($"int을 변환한 double값은 {dlVal}");

            object obj = 20;    //Boxing
            int inUnboxingVal = (int)obj;   //Unboxing
            Console.WriteLine($"object를 변환한 int값은 {inUnboxingVal}");

            string strVal = "200";
            int result = int.Parse(strVal) * 3; // string(문자열) -> int(숫자) 형변환
            Console.WriteLine($"200 * 3 = {result}");
        }
    }
}
