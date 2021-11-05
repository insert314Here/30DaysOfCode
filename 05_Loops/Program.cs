using System;

namespace _05_Loops
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            runTimesTable(n);
        }

        public static void runTimesTable(int value)
        {            
            //result should multiple value and loopcount
            for (int loopCount = 1; loopCount < 11; loopCount++)
            {
                int result = value * loopCount;
                Console.WriteLine($"{value} x {loopCount} = {result}");
            }
        }
    }

    
}
