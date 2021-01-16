int commonCharacterCount(string s1, string s2) {
 int result = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                int index = s2.IndexOf(s1[i]);
                if (index >= 0)
                {
                    s2 = s2.Remove(index, 1);
                    result++;
                }
            }
            return result;
}
