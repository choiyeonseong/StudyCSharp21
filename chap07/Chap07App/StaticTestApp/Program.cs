using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number;
        public float fnum;

        public static float ProcSomething()
        {
            Console.WriteLine($"{number}, Do Something");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            TestClass.number = 10;
            //aCls.number = 10;
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            //bCls.number = 10;
            bCls.fnum = 4.87f;

            TestClass.ProcSomething();
            //bCls.ProcSomething();
        }
    }
}
