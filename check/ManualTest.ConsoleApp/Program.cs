


using EasyFundamental;
using EasyIntermediate;

//recursive(5);

static void recursive(int n)
{
    if (n > 0)
    {
        Console.Write(n);
        recursive(n - 1);
    }
}



Arrays arrays = new Arrays();
arrays.DifferenceOfSum([1, 2, 3, 4, 5, 8, 3]);










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