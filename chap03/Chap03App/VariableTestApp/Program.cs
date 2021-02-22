using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int v1 = 30, v2 = 40;
            //int result = v1 + v2;
            //Console.WriteLine("결과는 " + result);

            //sbyte형
            sbyte sbMinVal = sbyte.MinValue;
            sbyte sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte\t최소, 최대값은 {sbMinVal}, {sbMaxVal} 입니다.");
            //byte형
            byte bMinVal = byte.MinValue;
            byte bMaxVal = byte.MaxValue;
            Console.WriteLine($"byte\t최소, 최대값은 {bMinVal}, {bMaxVal} 입니다.");
            //short형
            short shMinVal = short.MinValue;
            short shMaxVal = short.MaxValue;
            Console.WriteLine($"short\t최소, 최대값은 {shMinVal}, {shMaxVal} 입니다.");
            //ushort형
            ushort ushMinVal = ushort.MinValue;
            ushort ushMaxVal = ushort.MaxValue;
            Console.WriteLine($"ushort\t최소, 최대값은 {ushMinVal}, {ushMaxVal} 입니다.");
            //int형
            int intMinVal = int.MinValue;
            int intMaxVal = int.MaxValue;
            Console.WriteLine($"int\t최소, 최대값은 {intMinVal}, {intMaxVal} 입니다.");
            //uint형
            uint uintMinVal = uint.MinValue;
            uint uintMaxVal = uint.MaxValue;
            Console.WriteLine($"uint\t최소, 최대값은 {uintMinVal}, {uintMaxVal} 입니다.");
            //long형
            long longMinVal = long.MinValue;
            long longMaxVal = long.MaxValue;
            Console.WriteLine($"long\t최소, 최대값은 {longMinVal}, {longMaxVal} 입니다.");
            //ulong형
            ulong ulongMinVal = ulong.MinValue;
            ulong ulongMaxVal = ulong.MaxValue;
            Console.WriteLine($"ulong\t최소, 최대값은 {ulongMinVal}, {ulongMaxVal} 입니다.");
            //float형
            float fMinVal = float.MinValue, fMaxVal = float.MaxValue;
            Console.WriteLine($"float\t최소, 최대값은 {fMinVal}, {fMaxVal} 입니다.");
            //double형
            double dMinVal = double.MinValue, dMaxVal = double.MaxValue;
            Console.WriteLine($"double\t최소, 최대값은 {dMinVal}, {dMaxVal} 입니다.");
            //decimal형
            decimal dcMinVal = decimal.MinValue, dcMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimal\t최소, 최대값은 {dcMinVal}, {dcMaxVal} 입니다.");
        }
        
    }
}
