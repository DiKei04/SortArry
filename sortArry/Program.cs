using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortArry
{
    internal class Program
    {

        public void Sort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                Heapify(arr, arr.Length, i);

            for (int i = arr.Length - 1; i > 0; i--)
            {

                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        void Heapify(int[] arr, int x, int i)
        {
            int largNum = i; 
            int L = i + 1; 
            int R = i + 2; 

         
            if (L < x && arr[L] > arr[largNum])
                largNum = L;


            if (R < x && arr[R] > arr[largNum])
                largNum = R;

            
            if (largNum != i)
            {
                int swap = arr[i];
                arr[i] = arr[largNum];
                arr[largNum] = swap;

               
                Heapify(arr, x, largNum);
            }
        }

       
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }

       
        public static void Main()
        {
            int[] arr = { 31, 5, 50, 1, 22, 17, 2 };

            
            Program ob = new Program();
            ob.Sort(arr);

            Console.WriteLine("Sorted array is");
            PrintArray(arr);
        }
    }
}
