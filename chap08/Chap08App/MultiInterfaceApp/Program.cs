using System;

namespace MultiInterfaceApp
{
    interface IRunnable     // 자동차 종류
    {
        void Run();
    }

    interface IFlyable      // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run!!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DroneCar");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("차로 변경(interface)");
            IRunnable car = dreamCar;
            car.Run();
            //car.Fly();    // 오류

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = dreamCar;
            plane.Fly();
            //plane.Run();    // 오류
        }
    }
}