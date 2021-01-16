bool almostIncreasingSequence(int[] sequence) {
    int counter1=0;
    int counter2=0;
    for(int i=0;i<sequence.Length-1;i++)
    {
        if(sequence[i]>=sequence[i+1])
        {
            counter1++;
        }
        if(i != 0)
        {
            if(sequence[i-1]>=sequence[i+1])
            {
                counter2++;
            }
        }
    }
    if(counter1==1&&counter2<=1)
    {
        return true;
    }
    else{
        return false;
    }
}
