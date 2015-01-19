using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitKiller
{
    class BitKiller
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());
            byte[] nums = new byte[n];
            
            for (int i = 0; i < n; i++)
            {
                nums[i] = byte.Parse(Console.ReadLine());
            }
            
            List<byte> sequence = new List<byte>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                string temp = Convert.ToString(nums[i], 2).PadLeft(8,'0');
                for (int j = 0; j < temp.Length; j++)
                {
                    sequence.Add(Convert.ToByte(temp[j].ToString()));
                }
            }

            for (int i = 1,j = 0; i < sequence.Count; i = 1+j*step, j++)
            {
                sequence[i] = 3;
            }

            StringBuilder seq = new StringBuilder();
            foreach (var num in sequence)
            {
                if (num != 3)
                {
                    seq.Append(num);
                }
            }
            
            if (seq.Length % 8 != 0 && seq.Length > 8)
            {
                for (int i = 0; i < seq.Length % 8; i++)
                {
                    seq.Append(0);
                }
            }
            else if (seq.Length < 8)
            {
                for (int i = 0; i < 8-seq.Length; i++)
                {
                    seq.Append(0);
                }
            }
            string final = seq.ToString();
            var individuals = Split(final, 8);
            foreach (var ind in individuals)
            {
                Console.WriteLine(Convert.ToInt32(ind,2).ToString());
            }

        }
        
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
