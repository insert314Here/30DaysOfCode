using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        int N = 18;

        int odd = N % 2;

        if (odd == 1)
        {
            Console.WriteLine("Weird");
        }
        else if (odd == 0 && N<=5 && N>=2)
        {
            Console.WriteLine("Not Weird");
        }
        else if (odd == 0 && N <=20 && N >= 6)
        {
            Console.WriteLine("Weird");
        }
        else if(odd == 0 && N > 20)
        {
            Console.WriteLine("Not Weird");
        }
    }
}
