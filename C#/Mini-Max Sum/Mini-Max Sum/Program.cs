using System.Linq;
using System;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr)
    {
        long sum = arr.Sum(), max = 0, min = sum , result;

        for (int i = 0; i < 5;i++)
        {
            result = sum - arr[i];

            if (result > max)
            {
                max = result;
            }

            if (result < min)
            {
                min = result;
            }
        }

        Console.Write(min);
        Console.Write(" ");
        Console.WriteLine(max);
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));

        miniMaxSum(arr);
    }
}
