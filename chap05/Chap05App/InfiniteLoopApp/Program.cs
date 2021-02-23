using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idx = 0;
            for(; ; )   //무한루프 == while(true)
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
