using System;

namespace Observer_Pattern
{
    public class Mouse
    {
        protected string _name;

        protected int _age;

        public int Age => _age;

        public string Name => _name;

        public Mouse(string name)
        {
            _name = name;
            Console.WriteLine("生成的老鼠名字叫"+name);
            Cat.CatComing += MouseAction;
        }

        public void TestConsole()
        {
            Console.WriteLine("this is the test func");
            
        }

        public Mouse(string name, int age)
        {
            _name = name;
            _age = age;
            Console.WriteLine("这个小白鼠"+name+"的年龄是："+age);
            Cat.CatComing += MouseAction;
            if (_name.Equals("comming"))
            {
                Console.WriteLine("The status is comming now~ ");
                Console.ReadKey();
            }
        }

        public virtual void MouseAction()
        {
            Console.WriteLine("老鼠"+_name+"开始起反应了");
        }
    }
}