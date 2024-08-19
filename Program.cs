using System;

namespace Array101
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindMaxConsecutiveOnes();
            TestFindNumbers();
            TestSortedSquares();
            Console.ReadLine(); // Keep console window open
        }

        static void TestFindMaxConsecutiveOnes()
        {
            Console.WriteLine("Testing FindMaxConsecutiveOnes:");
            FindMaxConsecutiveOnes solution = new FindMaxConsecutiveOnes();

            int[] nums1 = { 1, 1, 0, 1, 1, 1 };
            int result1 = solution.FindMaxConsecutiveOnesMethod(nums1);
            Console.WriteLine($"Test case 1: {result1}"); // Expected output: 3

            int[] nums2 = { 1, 0, 1, 1, 0, 1 };
            int result2 = solution.FindMaxConsecutiveOnesMethod(nums2);
            Console.WriteLine($"Test case 2: {result2}"); // Expected output: 2

            Console.WriteLine();
        }

        static void TestFindNumbers()
        {
            Console.WriteLine("Testing FindNumbers:");
            FindNumbers solution = new FindNumbers();
            int[] nums = { 12, 345, 2, 6, 7896 };
            int result = solution.FindNumbersWithEvenDigits(nums);
            Console.WriteLine($"Test case: {result}");
            Console.WriteLine();
        }

        static void TestSortedSquares()
        {
            Console.WriteLine("Testing SortedSquares:");
            SortedSquares solution = new SortedSquares();
            int[] nums_high = { -4, -1, 0, 3, 10 };
            int[] nums_low = { -4, -1, 0, 3, 10 };
            int[] complex_high_result = solution.SortedSquaresNumbersHigherComplexity(nums_high);
            Console.WriteLine($"High Test case: [{string.Join(", ", complex_high_result)}]");
            int[] complex_low_result = solution.SortedSquaresNumbersLowerComplexity(nums_low);
            Console.WriteLine($"Low Test case: [{string.Join(", ", complex_low_result)}]");
            Console.WriteLine();
        }
    }
}
