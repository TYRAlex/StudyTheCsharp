using System;

namespace 工厂方法模式
{
    public class BMWCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("The BMWCar start-up speed is verty quickly!");
            
        }

        public override void Run()
        {
           Console.WriteLine("The BMWCar run is quitely fast and safe!!!!");
        }

        public override void Stop()
        {
            Console.WriteLine("The slow stop time is 2 second");
        }
    }
}