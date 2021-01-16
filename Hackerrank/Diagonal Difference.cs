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

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {
     int sum1 = 0;
            int sum2 = 0;
            int res = 0;
            for (int i = 0; i < 3;i++ )
            {
                
                for (int j = 0; j <=arr.Length-1; j++)
                {
                    sum1 +=arr[i][j];
                    i++;
                }
                
            }
            for (int i = arr.Length-1; i >=arr.Length-1; i--)
            {

                for (int j = 0; j <=arr.Length-1 ; j++)
                {
                    sum2 +=arr[i][j];
                    i--;
                }

            }
            res = Math.Abs(sum1 - sum2);
            return res;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}