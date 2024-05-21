using System;
namespace strategy
{
    public class ArrayOperator
    {
        private ISortStrategy sortStrategy;

        public ArrayOperator(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SortArray<T>(T[] array) where T : IComparable<T>
        {
            sortStrategy.Sort(array);
        }
    }
}
