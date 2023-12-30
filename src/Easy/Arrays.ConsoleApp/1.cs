namespace Arrays.ConsoleApp;

internal class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndexMap = [];
        for (int i = 0; i < nums.Length; ++i)
        {
            int complement = target - nums[i];
            if (numIndexMap.TryGetValue(complement, out int value))
                return [value, i];
            numIndexMap[nums[i]] = i;
        }
        return [];
    }
}