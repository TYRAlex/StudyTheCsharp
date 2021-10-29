using System;
using System.Diagnostics;

namespace SingletonPattern
{
    /// <summary>
    /// 最简单的单例模式
    /// </summary>
    public class Singleton1
    {
        private static Singleton1 _singleton = null;
        private static object _singleton_Lock=new object();
        public static Singleton1 CreatInstance()
        {
            lock (_singleton_Lock)
            {
                Console.WriteLine("路过");
                if (_singleton == null)
                {
                    Console.WriteLine("被创建");
                    _singleton=new Singleton1();
                }
            }
            return _singleton;
        }
    }
}