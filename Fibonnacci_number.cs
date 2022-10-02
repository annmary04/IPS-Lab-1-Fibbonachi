using System;
public static class LoopTasks
{
    public static int SumOfFirstNFibonacciNumbers(int n)
    {
        int CurrentValue = 1;
        int PrevValue = 0;
        int Sum = 1;
        int CurrentSum;
        int i = 2;

        if (n == 0) Sum = 0;
        if (n == 1) Sum = 0;

        while (i < n)
        {
            CurrentSum = PrevValue + CurrentValue;
            PrevValue = CurrentValue;
            CurrentValue = CurrentSum;
            Sum += CurrentValue;
            i++;
        }

        return Sum;
    }
}
