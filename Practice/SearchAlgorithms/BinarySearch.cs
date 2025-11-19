namespace SearchAlgorithms
{
    public class BinarySearch
    {
        public static int Find(int[] array, int value)
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
