namespace ConsoleApp1
{
    public class UnitTest1
    {
        int SORTING_TIME_LIMIT = 10000;

        [Fact]
        public void TestBubbleSort()
        {
            var arr = new List<int>()
            {
                1,
                4,
                6,
                3,
                2
            };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Program.BubbleSort(ref arr);
            watch.Stop();

            for (int i = 0; i < arr.Count - 1; ++i)
            {
                if (arr[i + 1] < arr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.True(watch.ElapsedMilliseconds <= SORTING_TIME_LIMIT);
        }

        [Fact]
        public void TestInsrtionSort()
        {
            var arr = new List<int>()
            {
                1,
                4,
                6,
                3,
                2
            };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Program.InsertionSort(ref arr);
            watch.Stop();

            for (int i = 0; i < arr.Count - 1; ++i)
            {
                if (arr[i + 1] < arr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.True(watch.ElapsedMilliseconds <= SORTING_TIME_LIMIT);
        }

        [Fact]
        public void TestQuickSort()
        {
            var arr = new List<int>()
            {
                1,
                4,
                6,
                3,
                2
            };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Program.QuickSort(ref arr, 0, arr.Count - 1);
            watch.Stop();

            for (int i = 0; i < arr.Count - 1; ++i)
            {
                if (arr[i + 1] < arr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.True(watch.ElapsedMilliseconds <= SORTING_TIME_LIMIT);
        }
    }
}