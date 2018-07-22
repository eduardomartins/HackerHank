using System.Linq;
using System;

class Solution
{
    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        int count = 0, max = ar.Max();

        foreach(int num in ar)
        {
            if (max == num) {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = birthdayCakeCandles(ar);

        Console.WriteLine(result);

    }
}
