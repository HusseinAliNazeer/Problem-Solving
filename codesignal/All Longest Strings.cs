string[] allLongestStrings(string[] inputArray) {
 int h = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > h)
                    h = inputArray[i].Length;
            }

            List <string> s = new List<string>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == h)
                    s.Add(inputArray[i]);

            } 
          
            return s.ToArray();
}
