using System;

namespace ASC_DSC_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 Elements");
            for (i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //=====Ascending Order=======
            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending Order is");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t{0} ",arr[i]);
            }
            //=====Descending Order======
            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending Order is");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\t{0} ",arr[i]);
            }
        }
    }
}
