﻿using System.CodeDom.Compiler;
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

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        int PmrDim = 0, SndDim = 0, n = arr.Length - 1;

        for (int i = 0;i < arr.Length; i++)
        {
            PmrDim += arr[i][i];
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            SndDim += arr[i][n-i];
        }

        return Math.Abs(PmrDim-SndDim);
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
