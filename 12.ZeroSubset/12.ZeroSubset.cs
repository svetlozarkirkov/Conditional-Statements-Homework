using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            Console.WriteLine("Enter five integers, separated by space:");
            string input = Console.ReadLine();
            List<int> nums = new List<int>();
            string[] split = input.Split(' ');
            List<string> zeroSubsets = new List<string>();
            int count = 0;
            for (int i = 0; i < split.Length; i++)
            {
                nums.Add(Convert.ToInt32(split[i].ToString()));
            }
            foreach (var permu in Permutate(nums, nums.Count))
            {
                List<int> temp = new List<int>();
                foreach (var i in permu)
                {
                    temp.Add(Convert.ToInt32(i));
                    if (temp.Count>1 && temp.Sum()==0)
                    {
                        string zerosubsetTemp = string.Join(" + ", temp);
                        if (zeroSubsets.Contains(zerosubsetTemp))
                        {
                            continue;
                        }
                        else
                        {
                            zeroSubsets.Add(zerosubsetTemp);
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\nNo zero subsets found!\n");
            }
            else
            {
                Console.WriteLine("\nZero subsets found: \n");
                Console.WriteLine(new string('=',30));
                foreach (var subset in zeroSubsets)
                {
                    Console.WriteLine("{0} = 0",subset);
                }
            }
        }
        public static void RotateRight(IList sequence, int count)
        {
            object tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }
        public static IEnumerable<IList> Permutate(IList sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    
                    RotateRight(sequence, count);
                }
            }
        }
    }
}
