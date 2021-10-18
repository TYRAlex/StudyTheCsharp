using System;

namespace 简单工厂模式
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Food food1 = FoodSimleFactory.CreatFood("西红柿炒蛋");
            food1.Print();

            Food food2 = FoodSimleFactory.CreatFood("土豆肉丝");
            food2.Print();
            Console.ReadKey();
        }
    }
}