namespace 工厂方法模式
{
    public class BMWCarFactory : CarFactory
    {
        public override Car CarCreat()
        {
            return new BMWCar();
        }
    }
}