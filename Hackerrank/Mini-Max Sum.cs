using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long sum_max = 0;
            long sum_min = 0;
            long max = -999999999999999999;
            long min = 99999999999999999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum_max += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum_min += arr[i];
            }
            sum_max = sum_max-min ;
            sum_min = sum_min - max;
            Console.WriteLine(sum_min+" "+sum_max );
            


    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}