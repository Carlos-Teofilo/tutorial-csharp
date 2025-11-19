namespace SortAlgorithms
{

    public class BubbleSort
    {
        static public void Sort(int[] array)
        {
            int size = array.Length - 1;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
        }
    }
}
