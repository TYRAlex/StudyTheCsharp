namespace 插入排序
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static void InsertSort(ref int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i - 1;
                temp = array[i];
                //因为当前数的左边都已是排序好的数列，因此无需当前数与左边数列每个都进行比较，只需某个数比当前数小，则剩下的未比较的数也一定比当前数小
                while (j>=0&&temp<array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
            }
        }
    }
}