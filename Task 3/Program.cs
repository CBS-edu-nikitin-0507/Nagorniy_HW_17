using System;

namespace Task_3
{
    static class Extencion
    {
        public static void ExtencionSort(this int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }          
        }

        public static void ShowArr(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }

    class Program
    {
      
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 4, 2, 1, 6 };
            arr.ExtencionSort();
            arr.ShowArr();
           
        }
    }
}
