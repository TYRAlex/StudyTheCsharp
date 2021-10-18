using System;

namespace 抽象工厂模式
{
    /// <summary>
    /// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口
    /// </summary>
    public abstract class FoodAbstractFactory
    {
        //抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了绝味中鸭脖和鸭架的创建接口
        public abstract YaBo CreatYaBo();
        public abstract YaJia CreatYaJia();
    }

    /// <summary>
    /// 南昌生产工厂
    /// </summary>
    public class NanChangFactory : FoodAbstractFactory
    {
        public override YaBo CreatYaBo()
        {
            return new NanChangYaBo();
        }

        public override YaJia CreatYaJia()
        {
            return new NanChangYaJia();
        }
    }

    /// <summary>
    /// 上海生产工厂
    /// </summary>
    public class ShangHaiFactory : FoodAbstractFactory
    {
        public override YaBo CreatYaBo()
        {
            return new ShangHaiYaBo();
        }

        public override YaJia CreatYaJia()
        {
            return new ShangHaiYaJia();
        }
    }
    
    /// <summary>
    /// 鸭架抽象类，供每个地方的鸭架类继承
    /// </summary>
    public abstract class YaJia
    {
        public abstract void Print();
    }
    /// <summary>
    /// 鸭脖抽象类，供每个地方的鸭脖类继承
    /// </summary>
    public abstract class YaBo
    {
        public abstract void Print();
    }

    /// <summary>
    /// 上海鸭脖的子类
    /// </summary>
    public class ShangHaiYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("生产上海鸭脖");
        }
    }

    /// <summary>
    /// 南昌鸭架子类
    /// </summary>
    public class NanChangYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("生产南昌鸭架");
        }
    }

    /// <summary>
    /// 上海鸭架子类
    /// </summary>
    public class ShangHaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("生产上海鸭架");
        }
    }

    /// <summary>
    /// 南昌鸭脖子类
    /// </summary>
    public class NanChangYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("生产南昌鸭脖");
        }
    }

    class Customer
    {
        public static void CustomerMainMethod()
        {
            //南昌工厂制作南昌的鸭脖和鸭架
            FoodAbstractFactory nancChangFactory= new NanChangFactory();
            YaBo nanChangeYabo = nancChangFactory.CreatYaBo();
            nanChangeYabo.Print();
            
            YaJia nanchangYaJia = nancChangFactory.CreatYaJia();
            nanchangYaJia.Print();
            
            //上海工厂制作上海的鸭脖和鸭架
            FoodAbstractFactory shangHaiFactory=new ShangHaiFactory();
            shangHaiFactory.CreatYaBo().Print();
            shangHaiFactory.CreatYaJia().Print();

            Console.ReadKey();
        }
    }
}