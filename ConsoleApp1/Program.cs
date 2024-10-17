namespace ConsoleApp1
{
    public static class Program
    {
        public static void BubbleSort(ref List<int> list)
        {
            var t = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        t = list[i];
                        list[i] = list[j];
                        list[j] = t;
                    }
                }
            }
        }

        public static void InsertionSort(ref List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
        }

        public static void QuickSort(ref List<int> list, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;

            var pivot = list[leftIndex];

            while (i <= j)
            {
                while (list[i] < pivot)
                {
                    i++;
                }

                while (list[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int t = list[i];
                    list[i] = list[j];
                    list[j] = t;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(ref list, leftIndex, j);
            }

            if (i < rightIndex)
            {
                QuickSort(ref list, i, rightIndex);
            }
        }

        public static int Main()
        {
            return 0;
        }
    }
}
