using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums =
                Console.ReadLine()
                    .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();
            long sumOfRemValues = 0;
            while (nums.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long removedNum = 0;
                if (index < 0)
                {
                    removedNum = nums[0];
                    sumOfRemValues += removedNum;
                    nums[0] = nums[nums.Count - 1];

                    IncreaseDegreaseValuesOfList(removedNum, nums);
                    
                    
                }
                else if (index >= nums.Count)
                {
                    removedNum = nums[nums.Count - 1];
                    sumOfRemValues += removedNum;
                    nums[nums.Count -1] = nums[0];

                    IncreaseDegreaseValuesOfList(removedNum, nums);
                    
                    
                }
                else
                {
                    
                    removedNum = nums[index];
                    sumOfRemValues += removedNum;
                    nums.RemoveAt(index);

                    IncreaseDegreaseValuesOfList(removedNum, nums);
                }
                
            }

            Console.WriteLine(sumOfRemValues);
        }

        static void IncreaseDegreaseValuesOfList(long removedNum, List<long> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] <= removedNum)
                {
                    nums[i] += removedNum;
                }
                else
                {
                    nums[i] -= removedNum;
                }
            }
        }
    }
}
