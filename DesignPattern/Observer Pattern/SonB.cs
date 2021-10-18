using System;

namespace Observer_Pattern
{
    public class SonB : Father
    {
        public override void Test1()
        {
            base.Test1();
            Console.WriteLine("B 现在重写Test1");
        }

        public override void Test2()
        {
            Console.WriteLine("B 现在重写Test2");
        }
    }
}