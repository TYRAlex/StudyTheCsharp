namespace 抽象工厂模式
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreatProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreatProductB()
        {
            return new ProductB1();
        }
    }
}