﻿namespace Range_Exceptions
{
    using System;

    class Startup
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input!", 2, 50);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n");

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1981, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}