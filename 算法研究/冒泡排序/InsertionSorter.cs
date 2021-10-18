namespace 冒泡排序
{
    public class InsertionSorter
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="array">数组</param>
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                int t = array[i];
                int j = i;
                while ((j>0)&& (array[j-1]>t))
                {
                    array[j] = array[j - 1];
                    --j;
                }

                array[j] = t;
            }
        }
    }
}