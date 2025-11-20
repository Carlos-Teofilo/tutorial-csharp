// See https://aka.ms/new-console-template for more information
using SearchAlgorithms;
using SortAlgorithms;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {32, 54, 123, 75, 76, 23};
            foreach (var n in array)
                Console.Write(n + ", ");
            
            Console.WriteLine("");

            Sort.BubbleSort(array);

            foreach (var n in array)
                Console.Write(n + ", ");

            Console.WriteLine(Search.BinarySearch(array, 54));
        }

    }
}
