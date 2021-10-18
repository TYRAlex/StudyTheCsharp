using System;

namespace Observer_Pattern
{
    public class Father
    {
        public virtual void  Test1()
        {
            Console.WriteLine("这是父亲的Test1");
        }

        public virtual void Test2()
        {
            Console.WriteLine("这是父亲的Test2");
        }
    }
}