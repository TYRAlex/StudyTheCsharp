using System;

namespace 抽象工厂模式
{ 
    class ConcreteFactory1 : AbstractFactory,Iproduct
    {
        public override AbstractProductA CreatProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreatProductB()
        {
            return new ProductB1();
        }

        public void ProductA()
        {
            Console.WriteLine("继承接口，生产A");
        }

        public void ProductB()
        {
            Console.WriteLine("继承接口，生产B");
        }
    }
}