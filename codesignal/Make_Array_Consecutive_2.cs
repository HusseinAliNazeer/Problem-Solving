int makeArrayConsecutive2(int[] statues) {
  int s = 0;
            Array.Sort(statues);
            for (int i = 0; i < statues.Length-1;i++ )
            {
                if (statues[i + 1] - statues[i] != 1)
                {
                    s += (statues[i + 1] - statues[i]) - 1;
                }
               
            }
            Console.WriteLine(s);

            return s;
}
