namespace HelperLibrary.Extentions
{
    public static class MyListExtentions
    {
        public static List<int> SortList(this List<int> list)
        {
            list.Sort();
            return list;
        }

        public static int GetElementCount(this List<int> list) =>
            list.Count;

        public static int GetElementByIndex(this List<int> list, int index) =>
            list[index];

        public static int GetSum(this List<int> list) =>
            list.Sum();

        public static int GetMin(this List<int> list) =>
            list.Min();

        public static int GetMax(this List<int> list) =>
            list.Max();
    }
}