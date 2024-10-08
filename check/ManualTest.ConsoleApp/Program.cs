﻿//recursive(5);

//static void recursive(int n)
//{
//    if (n > 0)
//    {
//        Console.Write(n);
//        recursive(n - 1);
//    }
//}



//Arrays arrays = new();
//arrays.SortedSquares([]);

//var n = ~5;
//Console.WriteLine(n);

//var ns = Math.ILogB(5);
//Console.WriteLine(ns);

//var num = 2 + 1;
//Console.WriteLine(num);

//var s = 1 << num;
//Console.WriteLine(s);

//s -= 1;
//Console.WriteLine(s);

//var d = n & s;
//Console.WriteLine(d);



"1, 2, 3, 4, 6, 5, S7, 8, 9, 10".ToInts().ToList().ForEach(Console.WriteLine);

public static class MillyExtensions
{
    public static IEnumerable<int> ToInts(this string str, char delimiter = ',')
        => str
          .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
          .Where(i => int.TryParse(i, out _))
          .Select(int.Parse);
}





//// ------------------------------------------------------------------------------------
//// MEMORY PERFORMANCE TEST
//long memoryUsed = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64;
//// ---------------------

//var result = meduimArrays.MaxLength(new[] { "cha", "r", "act", "ers" });
//Console.WriteLine(result);

//// ---------------------
//long memoryUsedDuringExecution = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64 - memoryUsed;
//Console.WriteLine($"Memory used during execution: {memoryUsedDuringExecution} bytes");
//// ------------------------------------------------------------------------------------





//// ------------------------------------------------------------------------------------
//// TIME PERFORMANCE TEST
//var stopwatch = System.Diagnostics.Stopwatch.StartNew();
//// ---------------------

//result = meduimArrays.MaxLength(new[] { "cha", "r", "act", "ers" });
//Console.WriteLine(result);

//// ---------------------
//stopwatch.Stop();
//Console.WriteLine($"Time: {stopwatch.Elapsed}");
//// ------------------------------------------------------------------------------------