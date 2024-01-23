using System.Numerics;

class Program
{
    public static void Main(string[] args) {

        int[] digits = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0}; 

        foreach(var i in PlusOne(digits)) {
            Console.Write(i);
	    }

        Console.WriteLine();
	     
    }


    public static int[] PlusOne(int[] digits)
    {
       
        BigInteger num = digits
                    .Select((value, index) => (BigInteger)value * BigInteger.Pow(10, digits.Length - index - 1))
		            .Aggregate(BigInteger.Add);


        int[] newNum = (num+1).ToString().Select(i => int.Parse(i.ToString())).ToArray();


        // This is the long way to achieve the same goal. But keep it in Mind.... 
	    // Time is the most valuable thing you have ever own. So dont waste it. Try to use the best solution everytime.
	    // Infact dont try.. Just use it.(-_-)

        /*var newNum = new List<int>();
        while (num != 0)
        {
            newNum.Insert(0, num % 10);
            num = num / 10;
        }*/
        return newNum.ToArray();
    }
}