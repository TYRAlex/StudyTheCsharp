using System;

namespace Observer_Pattern
{
    public class WhiteMouse : Mouse
    {
        public WhiteMouse(string name) : base(name)
        {
            
        }

        public override void MouseAction()
        {
            base.MouseAction();
            Console.WriteLine(Name+"小白鼠不吃东西了");
        }
    }
}