namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArr = SelectionSort();

            foreach(int i in sortedArr)
                Console.WriteLine(i);
        }

        static int[] SelectionSort()
        {
            int[] array = { 15, 8, 21, 16, 5, 19, 7, 23, 10, 14, 3, 11, 6, 17, 4 };
            var arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = tempVar;
            }
            return array;
        }
    }
}