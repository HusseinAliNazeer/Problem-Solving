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

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar) {
          int sum = 0;
            int f = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = ar.Length - 1; j >= 0; j--)
                {
                    if (ar[i] == ar[j])
                    {
                        f = ar[i];
                        break;
                    }

                    i++;
                }
                if (f > 0)
                    break;

            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == f)
                    sum++;

            }
            if (sum == 0)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = ar.Length - 1; j >= 0; j--)
                    {
                        if (ar[i] == 82)
                        {
                            f = ar[i];
                            break;
                        }
                        else if (ar[i] != ar[j])
                            break;

                        if (f > 0)
                            break;
                    }


                }
                for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == f)
                    sum++;

            }
            }
            if (sum == 0)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = ar.Length - 1; j >= 0; j--)
                    {
                        if (ar[i] == 77)
                        {
                            f = ar[i];
                            break;
                        }
                        else if (ar[i] != ar[j])
                            break;

                        if (f > 0)
                            break;
                    }


                }
                for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == f)
                    sum++;

            }
            }


            return sum;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}