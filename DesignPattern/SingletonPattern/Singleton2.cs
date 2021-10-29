/*
 * 利用静态变量去实现单例模式，由CLR保证，在程序第一次使用该类之前被调用，而且只调用一次
 * 缺点：在程序初始化之后，静态对象就被CLR构造了，哪怕没用
 */
namespace SingletonPattern
{
    /// <summary>
    /// 利用静态变量实现单例模式
    /// </summary>
    public class Singleton2
    {
        private static readonly Singleton2 _singleton2Instance=new Singleton2();

        public static Singleton2 GetInstance
        {
            get
            {
                return _singleton2Instance;
            }
        }
    }
}