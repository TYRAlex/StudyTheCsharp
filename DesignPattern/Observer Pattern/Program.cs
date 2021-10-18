using System;
using System.Diagnostics;
using System.Reflection;

namespace Observer_Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Test1();
            // Test2();
            // Test3();
            // SonA a=new SonA();
            // SonB b=new SonB();
            // Father f = new SonA();
            // f.Test1();
            // f.Test2();
            //获取程序集信息
            Program program=new Program();
            // p.ReflectionTest3();
            
            //p.ReflectionTest4();
            
            
            //string s = "sdf ";

            //Test5();
            // Mouse blackMouse=new BlackMouse("小黑",4);
            // Mouse whiteMouse = new WhiteMouse("小白");
            // Cat.CatComing();
            
            //double* pDouble = stackalloc double[50];

            //program.TestPro();

            Console.ReadKey();
        }
        
        // public unsafe void Add(int *p)
        // {
        //     *p = *p + 4;
        //    
        //     Console.WriteLine(*p+"的地址为：");
        // }
        //
        // public unsafe void TestPro()
        // {
        //     int[] value = new int[2] {1, 2};
        //
        //     fixed (int *p = &value[0])
        //     {
        //         Add(p);
        //     }
        // }

        [Conditional("TEST")]
        public static void Test5()
        {
            Console.WriteLine("this is the Test5");
        }

        public void ReflectionTest3()
        {
            //typeof(SonA).GetMethod("Test1").Invoke(SonA,)
            Type t = typeof(SonA);
            Object a = Activator.CreateInstance(t);
            t.GetMethod("Test1").Invoke(a, null);
        }

        public void ReflectionTest4()
        {
            Assembly assembly =
                Assembly.LoadFile(@"D:\RiderProject\Study\LibraryTest\LibraryTest\bin\Debug\LibraryTest.dll");
            Type t = assembly.GetType("LibraryTest.Student");
            BindingFlags flag = BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public;
            MethodInfo[] info = t.GetMethods(flag);
            foreach (var item in info)
            {
                //Console.WriteLine(item.Name+item.);
            }
        }

        public void RelectionTest2()
        {
            Type t = typeof(SonA);
            
            SonA a=new SonA();
            MethodInfo mt = t.GetMethod("Test1");
            mt.Invoke(a, null);
        }

        public static void RelectionTest()
        {
            Assembly assembly =
                Assembly.LoadFile(@"D:\RiderProject\Study\LibraryTest\LibraryTest\bin\Debug\LibraryTest.dll");
            Console.WriteLine("程序集名字："+assembly.FullName);
            Console.WriteLine("程序集位置："+assembly.Location);
            Console.WriteLine("运行程序集需要的额CLR版本:" + assembly.ImageRuntimeVersion);
            Console.WriteLine("=========================================================");
            //获取模块信息
            Module[] modules = assembly.GetModules();
            foreach (var item in modules)
            {
                Console.WriteLine("模块名称："+item.Name);
                Console.WriteLine("模块版本ID"+item.ModuleVersionId);
            }
            Console.WriteLine("==============================================");
            //获取类，通过模块和程序集都可以
            Type[] types = assembly.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("类型的名称:"+item.Name);
                Console.WriteLine("类型的完全命名："+item.FullName);
                Console.WriteLine("类型的类别：" + item.Attributes);
                Console.WriteLine("类型的GUID" + item.GUID);
                Console.WriteLine("================================");
            }
            //获取主要类Student的成员信息等
            Type studentType = assembly.GetType("LibraryTest.Student");
            Object obj = Activator.CreateInstance(studentType);
            MemberInfo[] mi = studentType.GetMembers();
            foreach (var item in mi)
            {
                Console.WriteLine("成员的名称"+item.Name+"  成员的类别"+item.MemberType);
               
            }
            Console.WriteLine("===========================================");
            //获取方法
            BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance;
            MethodInfo[] methodInfo = studentType.GetMethods(flags);
            foreach (var item in methodInfo)
            {
                Console.WriteLine("public 类型的，不包括基类继承的实例方法："+item.Name);
                item.Invoke(obj, null);
                
            }
            Console.WriteLine("============================================");
            //获取方法
            BindingFlags flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;
            MethodInfo[] methodinfos = studentType.GetMethods(flag);
            foreach (var item in methodinfos)
            {
                Console.WriteLine("非public类型的，不包括基类继承的实例方法：" + item.Name);
                item.Invoke(obj, null);
            }
            Console.WriteLine("===========================================");

            BindingFlags flags2 = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly |
                                  BindingFlags.Instance;
            PropertyInfo[] pi = studentType.GetProperties(flags2);
            foreach (var item in pi)
            {
                Console.WriteLine("属性名称："+item.Name);
            }
        }

        public static void Test1()
        {
            Console.WriteLine("current state");
                
        }

        public static void Test2()
        {
            Console.WriteLine("this is the Test2 ");
        }

        public static void Test3()
        {
            for (int i = 0; i < 10;i++)
            {
                if (i < 5)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public void Test4()
        {
            Console.WriteLine("这是一个非静态的初始方法");
        }
    }
}