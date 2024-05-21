using System;
namespace strategy
{
    public interface ISortStrategy
    {
        void Sort<T>(T[] array) where T : IComparable<T>;
    }
}
