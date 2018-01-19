using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Core.Order
{
    public class BubbleSortOrder
    {
        /// <summary>
        /// Realiza a ordenação com o Algoritmo Bubble Sort. Este é um dos algoritmos mais
        /// conhecidos por ser fácil de implementar e entender.
        /// 
        /// Definição:
        /// O bubble sort, ou ordenação por flutuação (literalmente "por bolha"), 
        /// é um algoritmo de ordenação dos mais simples. A ideia é percorrer o vector diversas vezes, 
        /// e a cada passagem fazer flutuar para o topo o maior elemento da sequência. 
        /// Essa movimentação lembra a forma como as bolhas em um tanque de água procuram 
        /// seu próprio nível, e disso vem o nome do algoritmo.
        /// 
        /// </summary>
        /// <param name="arr">Array que será ordenado.</param>
        /// <returns>Retorna o array ordenado de forma crescente.</returns>
        public static int[] Order(int[] arr)
        {
            int changes = 0;
            do
            {
                changes = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int j = i + 1;
                    if (j < arr.Length)
                    {
                        if (arr[i] > arr[j])
                        {
                            int ax = arr[i];
                            arr[i] = arr[j]; // Menor valor desce (na posicao J)
                            arr[j] = ax;     // Maior valor sobe (na posição I)
                            changes++;
                        }
                    }
                }
            } while (changes != 0);

            return arr;
        }
    }
}
