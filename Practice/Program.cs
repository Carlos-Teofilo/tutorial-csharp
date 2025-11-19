// See https://aka.ms/new-console-template for more information
using SearchAlgorithms;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id.ToString());

            int[] array = { 10, 20, 43, 56, 78, 100, 101, 124, 156 };

            foreach (var i in array)
            {
                Console.WriteLine(BinarySearch.Find(array, i));
            }

        }
    }
}
