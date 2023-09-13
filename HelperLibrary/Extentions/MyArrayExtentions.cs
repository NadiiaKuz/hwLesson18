namespace HelperLibrary.Extentions
{
    public static class MyArrayExtentions
    {
        public static int[] SortList(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
            return array;
        }

        public static int GetElementCount(this int[] array) =>
            array.Length;

        public static int GetElementByIndex(this int[] array, int index) =>
            array[index];

        public static int GetSum(this int[] array)
        {
            int sum = 0;
             
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int GetMinValue(this int[] array)
        {
            int minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minValue > array[i])
                    minValue = array[i];
            }

            return minValue;
        }

        public static int GetMaxValue(this int[] array)
        {
            int maxValue = array[0];
            for (int i = 0;i < array.Length; i++)
            { 
                if (maxValue < array[i])
                    maxValue = array[i];
            }

            return maxValue;
        }
    }
}