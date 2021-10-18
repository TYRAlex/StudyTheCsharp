using System;

namespace 简单工厂模式
{
    /// <summary>
    /// 菜抽象类
    /// </summary>
    public abstract class Food
    {
        //输出点了什么菜
        public abstract void Print();
    }

    /// <summary>
    /// 西红柿炒鸡蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }

    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }

    /// <summary>
    /// 简单工厂类，负责炒菜
    /// </summary>
    public class FoodSimleFactory
    {
        public static Food CreatFood(string type)
        {
            Food food = null;
            switch (type)
            {
                case "土豆肉丝":
                    food=new ShreddedPorkWithPotatoes();
                    break;
                case "西红柿炒蛋":
                    food=new TomatoScrambledEggs();
                    break;
            }

            return food;
        }
    }
}