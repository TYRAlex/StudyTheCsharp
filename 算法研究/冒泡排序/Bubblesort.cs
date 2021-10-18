using System;

namespace 冒泡排序
{
    public class Bubblesort
    {
        public static int[] BubbleSort(int[] array)
        {
            int count = 0;
            int i, j, temp;//交换标志
            bool exchange;
            for (i = 0; i < array.Length; i++)//最多做array.Length-1趟排序
            {
                exchange = false;//本趟排序开始前，交换标志应为假
                for (j= array.Length-2; j >= i; j--)
                {
                    if (array[j + 1] < array[j])  //交换条件
                    {
                        count++;
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        exchange = true;    //发生了交换，故将交换标志置为真
                    }
                }
                if(!exchange)        //本趟排序未发生交换，提前终止算法
                    break;
            }
            Console.WriteLine("这次总的交换次数为："+count);
            return array;
        }
    }
}