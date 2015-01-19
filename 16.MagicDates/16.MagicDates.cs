using System;
using System.Globalization;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        DateTime startDay = new DateTime(startYear, 01, 01);
        DateTime endDay = new DateTime(endYear, 12, 31);
        int count = 0;

        for (DateTime i = startDay; i <= endDay; i = i.AddDays(1))
        {
            int tempWeight = 0;
            string currentDate = i.ToString("ddMMyyyy",
                         CultureInfo.InvariantCulture);
            int[] dateArray = new int[8];
            for (int j = 0; j < dateArray.Length; j++)
            {
                dateArray[j] = Convert.ToInt32(currentDate[j].ToString());
            }
            for (int k = 0; k < dateArray.Length; k++)
            {
                for (int m = k + 1; m < dateArray.Length; m++)
                {
                    tempWeight += dateArray[k] * dateArray[m];
                }
            }
            if (tempWeight == magicWeight)
            {
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}