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

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {

        
        //total tax
        double tax = meal_cost * tax_percent / 100;

        //value of tip
        double tip = meal_cost * tip_percent / 100;


        //calc total cost with writeline
        double total = meal_cost + tax + tip;

        Console.WriteLine(Math.Round(total));
                
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = 12.00;

        int tip_percent = 20;

        int tax_percent = 8;

        Result.solve(meal_cost, tip_percent, tax_percent);

       
    }
}
