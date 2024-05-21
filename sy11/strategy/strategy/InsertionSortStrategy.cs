using System;
namespace strategy
{
    public class InsertionSortStrategy:ISortStrategy
    {
        public InsertionSortStrategy()
        {
        }
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
