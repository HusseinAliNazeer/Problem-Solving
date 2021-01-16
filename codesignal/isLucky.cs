bool isLucky(int n) {
int currentNumber = n;
            int sum1 = 0,sum2=0;
            List<int> digits = new List<int>();
            while (currentNumber != 0)
            {
                digits.Add(currentNumber % 10);
                currentNumber = currentNumber / 10;
            }
            int mid = digits.Count / 2;
            for (int i = 0; i < mid;i++ )
            {
                sum1 += digits[i];
            }
            for (int i = mid; i < digits.Count; i++)
            {
                sum2 += digits[i];
            }
            bool s;
            if (sum1 == sum2)
                s = true;
            else
                s = false;
            return s;
}
