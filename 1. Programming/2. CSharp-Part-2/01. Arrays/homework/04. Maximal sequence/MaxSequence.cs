﻿using System;

namespace _04.Maximal_sequence
{
    class MaxSequence
    {
        static void Main()
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            int currentLength = 1;
            int maxLength = 0;
            //int elementBestLength = 0;

            for (int i = 0; i < arrayNums.Length - 1; i++)
            {
                if (arrayNums[i] == arrayNums[i + 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        //elementBestLength = arrayNums[i];
                    }
                    currentLength = 1;
                }
            }

            // in case when the last sequence is the maximal sequence of equal elements
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                //elementBestLength = arrayNums[arrayNums.Length - 1];
            }

            Console.WriteLine(maxLength);

            //for (int i = 0; i < maxLength; i++)
            //{
            //    Console.Write(i != maxLength - 1 ? elementBestLength + ", " : elementBestLength + "\n");
            //}

        }
    }
}
