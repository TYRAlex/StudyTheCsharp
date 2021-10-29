/*
 * 实现对象延迟初始化，从而优化系统的性能。
 * 延迟始化就是将对象的初始化延迟到第一次使用该对象时，延迟初始化时我们在写程序时经常遇到的情形，例如创建某一对象时需要花费很大的开销，而这一对象在系统的运行过程中不一定会用到，这时就可以使用延迟初始化
 * Lazy<T> 对象的初始化默认是线程安全的，在多线程环境下，第一个访问Lazy<T>对象Value属性的线程将初始化Lazy<T>对象，以后访问的线程都将使用第一次初始化的数据
 */

using System;

namespace Lazy关键字
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Lazy<Student> stu=new Lazy<Student>();
            if(!stu.IsValueCreated)
                Console.WriteLine("student isn't init!");
            Console.WriteLine(stu.Value.Name);
            stu.Value.Name = "Tom";
            stu.Value.Age = 21;
            Console.WriteLine(stu.Value.Name);
            Console.ReadKey();
        }
    }
}