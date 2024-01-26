


using EasyFundamental;

recursive(5);

static void recursive(int n)
{
    if (n > 0)
    {
        Console.Write(n);
        recursive(n - 1);
    }
}



LinkedLists solution = new();


ListNode CreateLinkedList(int[] arr)
{
    ListNode dummy = new(0);
    ListNode current = dummy;
    foreach (int val in arr)
    {
        current.next = new ListNode(val);
        current = current.next;
    }
    return dummy.next;
}


solution.IsPalindrome(CreateLinkedList([1,2,5,2,1]));











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