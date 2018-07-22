using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the andProduct function below.
    static long andProduct(long a, long b)
    {
        long result = a;

        for (long i = (a+1); i  <= b; i++)
        {
            result = result & i;
        }
        return result;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());
        

        for (int nItr = 0; nItr < n; nItr++)
        {
            string[] ab = Console.ReadLine().Split(' ');

            long a = Convert.ToInt64(ab[0]);

            long b = Convert.ToInt64(ab[1]);

            long result = andProduct(a, b);

            Console.WriteLine(result);
        }

        //Console.ReadLine();
    }
}