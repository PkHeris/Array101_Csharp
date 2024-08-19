using System;

namespace Array101
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindMaxConsecutiveOnes();
            FindNumbers();
            // Add more test method calls for other problems here

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

        static void FindNumbers()
        {
            Console.WriteLine("Testing FindNumbers:");
            FindNumbers solution = new FindNumbers();

            // Test case for AnotherProblem
            int[] nums = { 12, 345, 2, 6, 7896 };
            int result = solution.FindNumbersWithEvenDigits(nums);
            Console.WriteLine($"Test case: {result}");

            Console.WriteLine();
        }
    }
}