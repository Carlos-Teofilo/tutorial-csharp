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
                    end = middle;
                    continue;
                }
                if (array[middle] < value)
                {
                    begin = middle;
                    continue;
                }
            }

            return -1;
        }
    }
}