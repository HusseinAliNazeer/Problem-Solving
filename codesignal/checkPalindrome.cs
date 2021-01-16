bool checkPalindrome(string inputString) {
string n = inputString.Substring(0, inputString.Length);
            bool b = false;
            for (int i = 0; i < inputString.Length;i++ )
            {
                for (int j = inputString.Length - 1; j >= 0; j--)
                {
                    if (inputString[i] == n[j])
                    {
                        b = true;
                        i++;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }
                break;
            }
    Console.WriteLine(b);
            return b;
}
