using System;

namespace 工厂方法模式
{
    public abstract class CarFactory
    {
        public abstract Car CarCreat();

        public virtual void Test()
        {
            Console.WriteLine("这是一个测试方法");
        }
    }
}