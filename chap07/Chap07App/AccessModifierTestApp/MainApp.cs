using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        internal int temp = 5;    // 물온도    // public, protected, private 순으로 많이 쓰임

        // private int에 접근하지 못하기 때문에 set,get을 만들어줌
        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 일정온도를 벗어났습니다. 59℃로 맞춥니다.");
                this.temp = 59;
                return;
            }
            else
            {
                this.temp = temp;
                Console.WriteLine($"현재 온도는 {this.temp}℃");
            }
        }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다!");
        }

        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다!");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            Console.WriteLine($"현재 온도는 {kitturami.GetTemp()}℃");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }
        }
    }
}
