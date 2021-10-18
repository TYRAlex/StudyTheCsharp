using System.Collections.Generic;
using System.Linq.Expressions;

namespace 数据结构研究
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList=new LinkedList<int>();
            linkedList.AddFirst(123);
            linkedList.AddLast(456);

            bool isContain = linkedList.Contains(123);
            LinkedListNode<int> node123 = linkedList.Find(123);//元素123的位置，从头查找
            linkedList.AddBefore(node123, 123);//节点不存在，会报错
           // linkedList.add
        }
    }
}