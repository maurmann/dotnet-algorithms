namespace dotnet_algorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] values)
        {
            Sort(values, 0, values.Length - 1);
        }

        private static void Sort(int[] values, int startPosition, int endPosition)
        {
            var pivot = values[startPosition];

            var leftPosition = startPosition;
            var rightPosition = endPosition;

            while (leftPosition <= rightPosition)
            {
                while (values[leftPosition] < pivot)
                    leftPosition++;

                while (values[rightPosition] > pivot)
                    rightPosition--;

                if (leftPosition <= rightPosition)
                {
                    (values[leftPosition], values[rightPosition]) = (values[rightPosition], values[leftPosition]);
                    leftPosition++;
                    rightPosition--;
                }

                if (startPosition < rightPosition)
                    Sort(values, startPosition, rightPosition);

                if (leftPosition < endPosition)
                    Sort(values, leftPosition, endPosition);
            }
        }
    }
}
