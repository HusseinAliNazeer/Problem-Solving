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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {

            double neg = 0;
            double pos = 0;
            double z = 0;
            double sumneg = 0;
            double sumpos = 0;
            double sumz = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] == 0)
                {
                    z++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
            }
            sumneg = neg / arr.Length;
            sumpos = pos / arr.Length;
            sumz = z / arr.Length;
            Console.WriteLine(sumpos);
            Console.WriteLine(sumneg);
            Console.WriteLine(sumz);

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}