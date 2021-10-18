namespace 工厂方法模式
{
    public class HongQiCarFactory : CarFactory
    {
        public override Car CarCreat()
        {
            return new HongQiCar();
        }
    }
}