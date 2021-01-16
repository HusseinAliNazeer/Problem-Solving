using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
          string r = s.Substring(0,2);
            string r1 = s.Substring(3, 3);
            string r2 = s.Substring(6, 2);
            string e = s.Substring(8,2);
            
            int x = Convert.ToInt32(r);
            if (x == 12 )
            {
                if (e == "AM")
                {
                    r = "00";
                }
            }
            if (e == "PM")
            {
                if (x != 12)
                {x = x+ 12;}
                e = x+":"+r1+r2;
            }
            else if (e == "AM")
            {
                e = r +":"+ r1 + r2;
            }

            r = x.ToString();
            return e;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}