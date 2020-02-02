using System;

namespace leetcode_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var indices = TwoSum(new int[] { 3, 2, 4 }, 6);
            System.Console.WriteLine($"Indices: {indices[0]}, {indices[1]}");
            Console.In.Read();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // var result = new int[2];
            // var sum = 0;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     for (int j = 0; j < nums.Length - 1; j++)
            //     {
            //         sum = nums[i] + nums[j + 1];
            //         if (sum == target)
            //         {
            //             result[0] = i;
            //             result[1] = j;
            //             return result;
            //         }
            //     }
            // }
            // return result;

            var result = new int[2];
            foreach (var number in nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (number + nums[i] == target && Array.IndexOf(nums, number) != i)
                    {
                        result[1] = Array.IndexOf(nums, number);
                        result[0] = i;
                    }
                }
            }

            return result;
        }
    }
}
