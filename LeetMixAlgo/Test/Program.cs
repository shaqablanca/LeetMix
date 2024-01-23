using System;

class Program
{
    public  static void Main()
    {
        int[] nums = { 3, 4, 2, 1, 6, 12, 7, 2, 8 };

        List<int> sumOfNums = new List<int>();
        int sum = 0;

        for( int i = 0; i< nums.Length; i++) {

            sum += nums[i];
            sumOfNums.Add(sum);

            Console.WriteLine(sumOfNums[i]);
	    }
        
    }

}
