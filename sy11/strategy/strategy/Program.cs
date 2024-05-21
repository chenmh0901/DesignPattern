using System;
namespace strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 4, 6, 1, 3 };

            ArrayOperator arrayOperator = new ArrayOperator(new BubbleSortStrategy());
            arrayOperator.SortArray(array);
            Console.WriteLine("Bubble Sort: " + string.Join(", ", array));

            arrayOperator.SetSortStrategy(new SelectionSortStrategy());
            arrayOperator.SortArray(array);
            Console.WriteLine("Selection Sort: " + string.Join(", ", array));

            arrayOperator.SetSortStrategy(new InsertionSortStrategy());
            arrayOperator.SortArray(array);
            Console.WriteLine("Insertion Sort: " + string.Join(", ", array));

            // 此处可以继续添加新的排序算法，并通过SetSortStrategy来更换
        }
    }
}
