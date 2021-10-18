using System;

namespace 冒泡排序
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new[] {3, 1, 67, 34, 21, 78, 45, 56, 23};
            Console.WriteLine("冒泡排序1：");
            BubbkesortByFirst(ref array);
            PrintArray(array);
            array = new[] {3, 1, 67, 34, 21, 78, 45, 56, 23};
            Console.WriteLine("冒泡排序2：");
            array= Bubblesort.BubbleSort(array);
            PrintArray(array);
            Console.ReadKey();
        }

        public static void BubbkesortByFirst(ref int[] array)
        {
            int temp = 0;
            int count = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 1; j < array.Length-i-1; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        count++;
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("总共的数量为：" + count);
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i+":"+array[i]+" ");
            }
        }
    }
}