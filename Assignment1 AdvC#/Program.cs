namespace Assignment1_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 19, 8, 2, 5, 3, 11, 26, 21 };

            BubbleSort(arr);

            Console.WriteLine("Sorted Array:");

            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }

        }

        #region Q1
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            bool Swapped;

            for (int i = 0; i < array.Length - 1; i++)
            {
                Swapped = false;

                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        //Swap
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        Swapped = true;
                    }
                }
                if (!Swapped)
                    break;
            }
        } 
        #endregion
    }
}
