/*
 * 利用静态构造函数实现单例模式
 * 只能有一个，无参数的，程序无法调用
 * 同样是CLR保证，在程序第一次使用该类之前被调用，而且只调用一次，同静态变量一样，它会随着程序运行，就被实例化，同静态变量一个道理
 */
namespace SingletonPattern
{
    /// <summary>
    /// 利用静态构造函数实现单例模式
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 _singleton3Instance = null;

        static Singleton3()
        {
            _singleton3Instance=new Singleton3();
        }

        public static Singleton3 CreatInstance()
        {
            return _singleton3Instance;
        }
    }
}