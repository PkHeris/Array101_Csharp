﻿using System;

namespace Array101
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindMaxConsecutiveOnes();
            TestFindNumbers();
            TestSortedSquares();
            TestDuplicateZeros();
            TestMerge();
            TestRemoveElement();
            TestRemoveDuplicates();
            TestCheckIfExist ();
            Console.ReadLine(); 
        }

        static void TestFindMaxConsecutiveOnes()
        {
            Console.WriteLine("Testing FindMaxConsecutiveOnes:");
            FindMaxConsecutiveOnes solution = new FindMaxConsecutiveOnes();

            int[] nums1 = { 1, 1, 0, 1, 1, 1 };
            int result1 = solution.FindMaxConsecutiveOnesMethod(nums1);
            Console.WriteLine($"Test case 1: {result1}"); 

            int[] nums2 = { 1, 0, 1, 1, 0, 1 };
            int result2 = solution.FindMaxConsecutiveOnesMethod(nums2);
            Console.WriteLine($"Test case 2: {result2}"); 

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

        static void TestDuplicateZeros()
        {
            Console.WriteLine("Testing DuplicateZeros:");
            DuplicateZeros solution = new DuplicateZeros();
            int[] arr1 = { 1, 0, 2, 3, 0, 4, 5, 0 };
            int[] arr2 = {1, 2, 3};
            solution.DuplicateZerosInPlace(arr1);
            Console.WriteLine($"Test case 1: [{string.Join(", ", arr1)}]");
            solution.DuplicateZerosInPlace(arr2);
            Console.WriteLine($"Test case 2: [{string.Join(", ", arr2)}]");
            Console.WriteLine();
        }

        static void TestMerge()
        {
            Console.WriteLine("Testing Merge:");
            Merge solution = new Merge();
            int[] num1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] num2 = { 2, 5, 6 };
            int n = 3;
            solution.MergeTwoGroups(num1, m, num2, n);
            Console.WriteLine($"Test case: [{string.Join(", ", num1)}]");
            Console.WriteLine();
        }

        static void TestRemoveElement()
        {
            Console.WriteLine("Testing RemoveElement:");
            RemoveElement solution = new RemoveElement();
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int result = solution.RemoveElementbyKtimes(nums, val);
            Console.WriteLine($"Test case: {result}");
            Console.WriteLine();
        }

        static void TestRemoveDuplicates()
        {
            Console.WriteLine("Testing RemoveDuplicates:");
            RemoveDuplicates solution = new RemoveDuplicates();
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = solution.RemoveDuplicatesReportUnique(nums);
            Console.WriteLine($"Test case: {result}");
            Console.WriteLine();
        }

        static void TestCheckIfExist()
            {
                Console.WriteLine("Testing CheckIfExist:");
                CheckIfExist solution = new CheckIfExist();
                int[] nums1 = { 10, 2, 5, 3 };
                bool result1 = solution.CheckIfExistSatisfied(nums1);
                int[] nums2 = { 3, 1, 7, 11 };
                bool result2 = solution.CheckIfExistSatisfied(nums2);
                Console.WriteLine($"Test case1: {result1}");
                Console.WriteLine($"Test case1: {result2}");
                Console.WriteLine();
            }
    }
}

//dotnet restore
//dotnet build

