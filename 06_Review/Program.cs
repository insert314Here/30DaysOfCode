using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06_Review
{
    class Solution
    {
        static void Main(String[] args)
        {
            //take in the test case amount
            int T = Convert.ToInt32(Console.ReadLine());
            //create a LIST OBJECT to store string input
            List<string> strings = new List<string>();

            for (int i = 0; i < T; i++)
            {
                //takes in string from console and adds to LIST OBJECT
                string line = Console.ReadLine();
                strings.Add(line);
            }

            for (int i = 0; i < T; i++)
            {
                //take initial input and puts into LIST OBJECT
                string line = strings[i];
                string even = "";
                string odd = "";
                for (int j = 0; j < line.Length; j++)
                {
                    if (j == 0 || j % 2 == 0) //takes index 0 assumed to be even
                        even += line[j];//adds space and grabs even index chars in LIST OBJECT
                    else
                        odd += line[j];
                    //if-else statements add even and odd indecies to string variables created in begin of for loop
                }

                Console.WriteLine(even + " " + odd);
            }
        }
    }
}
