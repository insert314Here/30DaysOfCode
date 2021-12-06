using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        //Console.WriteLine("What is the amount of names to be entered?");
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var names = Console.ReadLine().Split(' ');
            phoneBook.Add(names[0], names[1]);
        }

        string name = "noOne";
        while ((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name+"="+phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}