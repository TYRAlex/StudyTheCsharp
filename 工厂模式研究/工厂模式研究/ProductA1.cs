using System;

namespace 抽象工厂模式
{
    class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + "interact with" + b.GetType().Name);
        }
    }
}