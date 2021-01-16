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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {

 int co1=0,co2=0,co3=0,co4=0,co5=0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 1)
                    co1++;
               else if (arr[i] == 1)
                    co1++;
               else if (arr[i] == 2)
                    co2++;
               else if (arr[i] == 3)
                    co3++;
               else if (arr[i] == 4)
                    co4++;
               else if (arr[i] == 5)
                    co5++;
            
            }
           
                if (co1 >= co2 && co1 >= co3 && co1 >= co4 && co1 >= co5)
                    return 1;
                else if (co2 > co1 && co2 >= co3 && co2 >= co4 && co2 >= co5)
                    return 2;
                else if (co3 > co1 && co3 > co2 && co3 >= co4 && co3 >= co5)
                    return 3;
                else if (co4 > co1 && co4 > co2 && co4 > co3 && co4 >= co5)
                    return 4;
                else 
                    return 5;
                
            
            
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}