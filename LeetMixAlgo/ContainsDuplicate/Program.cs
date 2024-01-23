public class Solution
{

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 1, 3 };

        Console.WriteLine(ContainsNearbyDuplicate(numbers, 3));
    
    
    
    }
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {

        Dictionary<int, int> indexes = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (indexes.ContainsKey(nums[i]) && i - indexes[nums[i]] <= k)
            {
                return true;
            }
        }
        return false;
    }
}