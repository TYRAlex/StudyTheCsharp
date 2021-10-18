using System;

namespace 抽象工厂模式
{ 
    class Client: Iproduct
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreatProductA();
            _abstractProductB = factory.CreatProductB();
        }

        public void Run()
        {
            _abstractProductA.Interact(_abstractProductB);
            _abstractProductB.Interact(_abstractProductA);
        }

        public void ProductA()
        {
            Console.WriteLine("Clinet 继承接口 生产A");
        }

        void Iproduct.ProductB()
        {
            Console.WriteLine("显式实现ProductB");
        }

        public void ProductB()
        {
            Console.WriteLine("Clinet 继承接口 生产B");
        }
    }
}