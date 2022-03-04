using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            // int[] num1 = {2, 0, 1, 3};
            // int[] num2 = {0, 1, 2, 3};
            // int count = 0;
            //
            // for (int i = 0; i < num1.Length; i++)
            // {
            //     for (int j = 0; j < num2.Length; j++)
            //     {
            //         if (num2[j] == i && num1[i] == j)
            //         {
            //             count++;
            //         }
            //     }
            //    
            // }
            // Console.WriteLine(count);
            
            //2
            int[] nums = { 2, -1, 2};
            int k = 3;
            int sum = nums[1] + nums[2];
            int counter = 0;
           
            if (nums[0] == sum)
            {
                if (nums[2] == nums[0] + nums[1])
                {
                    counter++;
                }
            }
            
            else if (k + nums[1] == nums[2])
            {
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
