﻿using System;
using Huawei_Unlock;

namespace SubmoduleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test.HW_ALGO_SELECTOR("This_is_a_15_digit_imei_jk");

            Console.WriteLine("Made second change to SubmoduleTest");

            Console.WriteLine("Made third change to SubmoduleTest");
        }
    }
}
