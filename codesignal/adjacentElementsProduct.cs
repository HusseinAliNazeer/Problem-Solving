int adjacentElementsProduct(int[] inputArray) {
int [] tep_arr= new int [inputArray.Length];
            int h = 0;
            int max = 0;
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                tep_arr[h] = inputArray[i] * inputArray[i + 1];
                h++;
            }
            Array.Sort(tep_arr);
            if (tep_arr[tep_arr.Length - 1] != 0)
            {
                max = tep_arr[tep_arr.Length - 1];
            }
            else
                max = tep_arr[tep_arr.Length - 2];
            Console.WriteLine(max);
            return max;
}
