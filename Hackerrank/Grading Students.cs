using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        /*
         * Write your code here.
         */
         
            int[] final_Grade = new int[grades.Length];
            for (int i = 0; i < final_Grade.Length; i++)
            {
                final_Grade[i] = grades[i];
            }
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38 && grades[i] < 40)
                {
                    final_Grade[i] = 40;
                }
                else if (grades[i] >= 43 && grades[i] < 45)
                {
                    final_Grade[i] = 45;
                }
                else if (grades[i] >= 48 && grades[i] < 50)
                {
                    final_Grade[i] = 50;
                }
                else if (grades[i] >= 53 && grades[i] < 55)
                {
                    final_Grade[i] = 55;
                }
                else if (grades[i] >= 58 && grades[i] <60)
                {
                    final_Grade[i] = 60;
                }
                else if (grades[i] >= 63 && grades[i] < 65)
                {
                    final_Grade[i] = 65;
                }
                else if (grades[i] >= 68 && grades[i] < 70)
                {
                    final_Grade[i] = 70;
                }
                else if (grades[i] >= 73 && grades[i] < 75)
                {
                    final_Grade[i] = 75;
                }
                else if (grades[i] >= 78 && grades[i] < 80)
                {
                    final_Grade[i] = 80;
                }
                else if (grades[i] >= 83 && grades[i] < 85)
                {
                    final_Grade[i] = 85;
                }
                else if (grades[i] >= 88 && grades[i] < 90)
                {
                    final_Grade[i] = 90;
                }
                else if (grades[i] >= 93 && grades[i] < 95)
                {
                    final_Grade[i] = 95;
                }
                else if (grades[i] >= 98 && grades[i] < 100)
                {
                    final_Grade[i] = 100;
                }
            }

            return final_Grade;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}