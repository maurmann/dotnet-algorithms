namespace dotnet_algorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] values)
        {
            if (values == null || values.Length < 2)
                return;

            var length = values.Length;

            while (length > 0)
            {
                for (int index = 1; index < length; index++)
                {
                    if (values[index] < values[index - 1])
                    {
                        var greatValue = values[index];
                        values[index] = values[index - 1];
                        values[index - 1] = greatValue;
                    }
                }
                length--;
            }
        }
    }
}
