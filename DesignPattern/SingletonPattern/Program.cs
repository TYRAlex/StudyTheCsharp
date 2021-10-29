using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //第一个单例模式测试
            try
            {
                TaskFactory taskFactory=new TaskFactory();
                List<Task> taskList=new List<Task>();
                for (int i = 0; i<5; i++)
                {
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        Singleton1 singleton1 = Singleton1.CreatInstance();
                    }));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}