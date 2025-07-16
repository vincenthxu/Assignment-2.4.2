namespace Assignment_2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];

            for(int i=0; i<size; i++)
            {
                Console.Write($"Input {i+1}{DetermineOrdinal(i+1)} number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            (int index, int value) result = FindMax(nums);
            Console.WriteLine($"The largest number in the array is the {result.index + 1}{DetermineOrdinal(result.index + 1)} number '{result.value}' at index {result.index}.");
        }
        // For an int[] argument of non-zero size, return the max value and its index.
        static (int index, int value) FindMax(int[] nums)
        {
            // For an argument with no elements, return the following.
            int index = -1, max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }
            return (index, max);
        }
        static string DetermineOrdinal(int num)
        {
            if (num % 100 != 13 && num % 10 == 3)
                return "rd";
            else if (num % 100 != 12 && num % 10 == 2)
                return "nd";
            else if (num % 100 != 11 && num % 10 == 1)
                return "st";
            else
                return "th";
        }
    }
}
