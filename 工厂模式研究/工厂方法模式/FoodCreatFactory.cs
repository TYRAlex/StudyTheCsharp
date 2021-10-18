
using System;
using System.Runtime.Remoting;


namespace 工厂方法模式
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class FoodCreatFactory
    {
        //工厂方法
        public abstract Food CreateFoodFactory();
    }
    
    /// <summary>
    /// 创建西红柿炒蛋的工厂子类
    /// </summary>
    public class TomatoScrambledEggsFactory : FoodCreatFactory
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }

    /// <summary>
    /// 创建土豆肉丝这道菜的工厂子类
    /// </summary>
    public class ShreddedPorkWithPotatoesFactory : FoodCreatFactory
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }

    /// <summary>
    /// 菜的抽象类
    /// </summary>
    public abstract class Food
    {
        //输出点了什么菜
        public abstract void Print();
    }

   

    /// <summary>
    /// 西红柿炒蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("点了一个西红柿炒蛋！");
        }
    }

    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("点了一个土豆肉丝的菜！");
        }
    }

    class Client
    {

        static void MainMethod()
        {
            FoodCreatFactory shreddedPorkWithPotatoesFacoty=new ShreddedPorkWithPotatoesFactory();
            FoodCreatFactory tomatoScrambledEggsFactory=new TomatoScrambledEggsFactory();

            Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFacoty.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            Console.ReadKey();

        }

        // static void Main(string[] args)
        // {
        //     
        // }
    }
    
    
}