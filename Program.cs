/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:
    Input: nums = [1,2,3,1]
    Output: true

Example 2:
    Input: nums = [1,2,3,4]
    Output: false

Example 3:
    Input: nums = [1,1,1,3,3,4,3,2,4,2]
    Output: true
*/

namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine($"Input: nums = [{String.Join(",", nums)}]");
            Console.WriteLine($"Output: {HasDuplicates(nums)}\n");
            
            nums = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"Input: nums = [{String.Join(",", nums)}]");
            Console.WriteLine($"Output: {HasDuplicates(nums)}\n");

            nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine($"Input: nums = [{String.Join(",", nums)}]");
            Console.WriteLine($"Output: {HasDuplicates(nums)}\n");

            nums = new int[] { -5, -2, -1, 0, 1, 2, 5 };
            Console.WriteLine($"Input: nums = [{String.Join(",", nums)}]");
            Console.WriteLine($"Output: {HasDuplicates(nums)}\n");

        }

        static bool HasDuplicates(int[] array)
        {
            // Use HashSet to hold unique values
            HashSet<int> numHashSet = new();

            // Check if each number in the array exists in the hashset
            // If a number has a duplicate, return true, otherwise add number to hashset
            foreach (int num in array)
            {
                if (numHashSet.Contains(num))
                    return true;
                else
                    numHashSet.Add(num);
            }

            // If the entire array is iterated through without duplicates:
            return false;
        }
    }
}
