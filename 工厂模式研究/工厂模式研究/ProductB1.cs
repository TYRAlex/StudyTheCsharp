using System;

namespace 抽象工厂模式
{ 
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name+"interact with"+a.GetType().Name);
        }
    }
}