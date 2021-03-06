﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questions.Easy
{
    [TestFixture]
    class Sorting_SelectionSort
    {
        [TestCase(new int[] { 8, 5, 2, 9, 5, 6, 3 }, ExpectedResult = new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [TestCase(new int[] { 2, 1, 3 }, ExpectedResult = new int[] { 1, 2, 3 })]
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIdx = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minIdx])
                    {
                        minIdx = j;
                    }
                }
                swap(i, minIdx, array);
            }

            return array;
        }
        static public void swap(int a, int b, int[] array)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
