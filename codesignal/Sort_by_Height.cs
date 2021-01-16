int[] sortByHeight(int[] a) {
int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]!=-1)
                for (int j = 0; j < a.Length;j++ )
                {
                    if (a[j]>a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }
            }
            return a;
}
