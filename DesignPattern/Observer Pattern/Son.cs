using System;

namespace Observer_Pattern
{
    public class Son : Father
    {
        public delegate void GameStart();
        
        public override void Test1()
        {
            base.Test1();
            Console.WriteLine("现在重写父亲的Test1");
        }

        public override void Test2()
        {
            Console.WriteLine("现在重写父亲的Test2");
        }
    }
}