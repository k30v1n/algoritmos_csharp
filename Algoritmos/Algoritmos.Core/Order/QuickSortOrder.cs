using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Core.Order
{
    public class QuickSortOrder
    {
        public static int[] Order(int[] arr)
        {
            return quickSort(arr, 0, arr.Length - 1);
        }

        private static int[] quickSort(int[] arr, int initVet, int endVet)
        {
            // TODO: Corrigir
            int i = 0, j = 0, pivo = 0;

            i = initVet;
            j = endVet;
            pivo = arr[(initVet + endVet) / 2];

            while (i < j)
            {
                while (i < endVet && arr[i] <= pivo)
                    i++;
                while (j > initVet && arr[j] > pivo)
                    j--;

                if (i < j)
                    (arr[i], arr[j]) = (arr[j], arr[i]);

                i++;
                j--;
            }
            System.Diagnostics.Debugger.Log(1, "", String.Join(", ", arr)+"\n");
            if (j > initVet)
                quickSort(arr, initVet, j);
            if (i < endVet)
                quickSort(arr, j + 1, endVet);

            return arr;
        }
    }
}
