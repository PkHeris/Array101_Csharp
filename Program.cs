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
            TestDuplicateZeros();
            TestMerge();
            TestRemoveElement();
            TestRemoveDuplicates();
            TestCheckIfExist ();
            TestValidMountainArray();
            TestReplaceElements();
            TestMoveZeroes();
            TestSortArrayByParity();
            TestRemoveElementK();
            TestHeightChecker();

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
                Console.WriteLine($"Test case2: {result2}");
                Console.WriteLine();
        }

        static void TestValidMountainArray()
        {
            Console.WriteLine("Testing ValidMountainArray:");
            ValidMountainArray solution = new ValidMountainArray();
            int[] nums1 = { 2, 1 };
            bool result1 = solution.ValidMountainArrayExist(nums1);
            int[] nums2 = { 3, 5, 5 };
            bool result2 = solution.ValidMountainArrayExist(nums2);
            int[] nums3 = { 0, 3, 2, 1 };
            bool result3 = solution.ValidMountainArrayExist(nums3);
            Console.WriteLine($"Test case1 [{string.Join(", ", nums1)}]: {result1}");
            Console.WriteLine($"Test case2 [{string.Join(", ", nums2)}]: {result2}");
            Console.WriteLine($"Test case3 [{string.Join(", ",nums3)}]: {result3}");
            Console.WriteLine();
        }

        static void TestReplaceElements()
        {
            Console.WriteLine("Testing ReplaceElements:");
            ReplaceElements solution = new ReplaceElements();
            int[] arr1 = { 17, 18, 5, 4, 6, 1 };
            Console.WriteLine($"Testing case 1 [{string.Join(", ", arr1)}]:");
            int[] result1 = solution.ReplaceElementsInPlace((int[])arr1.Clone());
            Console.WriteLine($"[{string.Join(", ", result1)}]");
            int[] arr2 = { 400 };
            Console.WriteLine($"Testing case 2 [{string.Join(", ", (int[])arr2)}]:");
            int[] result2 = solution.ReplaceElementsInPlace(arr2);
            Console.WriteLine($"[{string.Join(", ",result2)}]");
        }

        static void TestMoveZeroes()
        {
            Console.WriteLine("Testing MoveZeroes:");
            MoveZeroes solution = new MoveZeroes();
            int[] arr1 = { 0, 1, 0, 3, 12 };
            Console.WriteLine($"Testing case 1 [{string.Join(", ", (int[])arr1.Clone())}]:");
            solution.MoveZeroesInPlace(arr1);
            Console.WriteLine($"[{string.Join(", ", arr1)}]");
            int[] arr2 = { 0 };
            Console.WriteLine($"Testing case 2 [{string.Join(", ", (int[])arr2.Clone())}]:");
            solution.MoveZeroesInPlace(arr2);
            Console.WriteLine($"[{string.Join(", ", arr2)}]");
        }
        static void TestSortArrayByParity()
        {
            Console.WriteLine("Testing SortArrayByParity:");
            SortArrayByParity solution = new SortArrayByParity();
            int[] arr1 = { 3, 1, 2, 4 };
            Console.WriteLine($"Testing case 1 [{string.Join(", ", (int[])arr1.Clone())}]:");
            solution.SortArrayByParityInPlace(arr1);
            Console.WriteLine($"[{string.Join(", ", arr1)}]");
            int[] arr2 = { 0 };
            Console.WriteLine($"Testing case 2 [{string.Join(", ", (int[])arr2.Clone())}]:");
            solution.SortArrayByParityInPlace(arr2);
            Console.WriteLine($"[{string.Join(", ", arr2)}]");
        }
        static void TestRemoveElementK()
        {
            Console.WriteLine("Testing ReplaceElements:");
            RemoveElementK solution = new RemoveElementK();
            int[] arr1 = { 3, 2, 2, 3 };
            int val1 = 3;
            Console.WriteLine($"Testing case 1 [{string.Join(", ", arr1)}]:");
            int result1 = solution.RemoveElementKInPlace(arr1, val1);
            Console.WriteLine($"[{result1}]");
            int[] arr2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val2 = 2;
            Console.WriteLine($"Testing case 2 [{string.Join(", ", arr2)}]:");
            int result2 = solution.RemoveElementKInPlace(arr2, val2);
            Console.WriteLine($"[{result2}]");
        }

        static void TestHeightChecker()
        {
            Console.WriteLine("Testing HeightChecker:");
            HeightChecker solution = new HeightChecker();
            int[] heights1 = { 1, 1, 4, 2, 1, 3 };
            int count1 = solution.HeightCheckerDiff(heights1);
            Console.WriteLine($"Testing Case 1 [{string.Join(", ", heights1)}]:");
            Console.WriteLine($"{count1}");
            int[] heights2 = { 5, 1, 2, 3, 4 };
            int count2 = solution.HeightCheckerDiff(heights2);
            Console.WriteLine($"Testing Case 1 [{string.Join(", ", heights2)}]:");
            Console.WriteLine($"{count2}");
            int[] heights3 = { 1, 2, 3, 4, 5 };
            int count3 = solution.HeightCheckerDiff(heights3);
            Console.WriteLine($"Testing Case 1 [{string.Join(", ", heights3)}]:");
            Console.WriteLine($"{count3}");
        }

    }
}

//dotnet restore
//dotnet build

