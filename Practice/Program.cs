// See https://aka.ms/new-console-template for more information
using SearchAlgorithms;
using SortAlgorithms;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id.ToString());

            int[] array = { 20, 43, 8, 10, 78, 2, 1, 3, 100, 56, 101, 124, 156 };

            BubbleSort.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

        }
    }
}
