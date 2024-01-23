

Medium.Arrays meduimArrays = new();
Easy.Strings easyStrings = new();
Easy.LinkedLists easyLists = new();
Easy.Maths easyMaths = new();
Easy.Arrays easyArrays = new();

// ------------------------------------------------------------------------------------
// MEMORY PERFORMANCE TEST
long memoryUsed = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64;
// ---------------------

var result = meduimArrays.MaxLength(new[] { "cha", "r", "act", "ers" });
Console.WriteLine(result);

// ---------------------
long memoryUsedDuringExecution = System.Diagnostics.Process.GetCurrentProcess().PrivateMemorySize64 - memoryUsed;
Console.WriteLine($"Memory used during execution: {memoryUsedDuringExecution} bytes");
// ------------------------------------------------------------------------------------





// ------------------------------------------------------------------------------------
// TIME PERFORMANCE TEST
var stopwatch = System.Diagnostics.Stopwatch.StartNew();
// ---------------------

result = meduimArrays.MaxLength(new[] { "cha", "r", "act", "ers" });
Console.WriteLine(result);

// ---------------------
stopwatch.Stop();
Console.WriteLine($"Time: {stopwatch.Elapsed}");
// ------------------------------------------------------------------------------------