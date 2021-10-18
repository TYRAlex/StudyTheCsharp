using System;

namespace 工厂方法模式
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Factory Method No:");
            Console.WriteLine("******************************");
            Console.WriteLine("no Factory method");
            Console.WriteLine("1  HongQiCarFactory");
            Console.WriteLine("2  BMWCarFactory");
            Console.WriteLine("******************************");
            CarFactory carFactory=new HongQiCarFactory();
            Car hongqi= carFactory.CarCreat();
            hongqi.Run();
            hongqi.StartUp();
            Console.ReadKey();


        }
    }
}