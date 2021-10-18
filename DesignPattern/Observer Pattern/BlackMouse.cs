using System;

namespace Observer_Pattern
{
    public class BlackMouse : Mouse
    {
        public BlackMouse(string name, int age) : base(name, age)
        {
            
        }

        public override void MouseAction()
        {
            base.MouseAction();
            Console.WriteLine("小黑鼠"+_name+"准备逃跑");
        }
    }
}