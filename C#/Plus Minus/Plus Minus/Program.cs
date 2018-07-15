using System.Linq;
using System;

class Solution
{

    // Complete the staircase function below.
    static void staircase(int n)
    {
        for(int i = 1;i <= n;i++)
        {
            Console.WriteLine(
                String.Concat(
                    String.Concat(Enumerable.Repeat(" ", (n-i))),
                    String.Concat(Enumerable.Repeat("#", i))
                )
            );
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
