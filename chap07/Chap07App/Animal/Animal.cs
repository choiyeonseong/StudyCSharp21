using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Animal    // 동물클래스
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Breath()
        {
            Console.WriteLine($"{this.Name}이 숨을 쉽니다.");
        }
    }
}
