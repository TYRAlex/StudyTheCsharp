using System;
using System.Diagnostics;

namespace 工厂方法模式
{
    public class HongQiCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("Test HongQiCar start-up speed!");
        }

        public override void Run()
        {
            Console.WriteLine("The HongQiCar run is very quickly");
        }

        public override void Stop()
        {
            Console.WriteLine("The slow stop time is 3 second");
        }
    }
}