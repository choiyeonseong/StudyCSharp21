using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    /*    class Ridable   // 탈것
        {
            public virtual void Ride()
            {
                Console.WriteLine("탈것!");
            }
        }*/

    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();
        void Ride();
    }

    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("DroneCar Fly!");
        }

        public void Ride()  // 내용은 없고 구현만 하면 됨 -> 다중상속 문제 해결
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("DroneCar Run!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }
    }
}
