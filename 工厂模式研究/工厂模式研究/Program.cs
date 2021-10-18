using System;

namespace 抽象工厂模式
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // AbstractFactory factory1=new ConcreteFactory1();
            // Client c1 = new Client(factory1);
            // c1.Run();
            // c1.ProductA();
            // AbstractFactory factory2=new ConcreteFactory2();
            // Client c2 = new Client(factory2);
            // c2.Run();
            // c2.ProductB();
            // (c2 as Iproduct).ProductB();
            //
            // Iproduct ipro=new ConcreteFactory1();
            // ipro.ProductA();
            // Console.ReadKey();
            
            Customer.CustomerMainMethod();
        }
    }
}