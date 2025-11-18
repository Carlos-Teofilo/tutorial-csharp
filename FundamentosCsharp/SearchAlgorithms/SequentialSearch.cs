namespace SearchAlgorithms;

class SequentialSearch  // Fixed spelling
{
    public static int Find(int[] array, int value)  // PascalCase for method names
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
                return i;
        }

        return -1;
    }
}