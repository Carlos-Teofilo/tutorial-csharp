namespace SearchAlgorithms
{
    public class Search
    {
        public static int SequentialSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value)
                    return i;

            return -1;
        }

        public static int BinarySearch(int[] array, int value)
        {
            int begin = 0;
            int end = array.Length - 1;

            while (begin <= end)
            {
                int middle = (begin + end) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }
                if (array[middle] > value)
                {
                    end = middle - 1;
                    continue;
                }
                if (array[middle] < value)
                {
                    begin = middle + 1;
                    continue;
                }
            }

            return -1;
        }
    }
}
