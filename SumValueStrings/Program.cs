using System;
// switch statement to cycle thru word hello e=5, h=8, l=12, o=15

namespace SumValueStrings
{
    public class Program
    {


        public static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            string word = Convert.ToString(Console.ReadLine());
            
            // if there is white space return result -1
            bool hasSpace = word.Contains(" ");
            if (hasSpace)
            {
                Console.WriteLine("there is a space so: -1");
            }
            else
            {
                ComputeStringValue(word);
            }

        }

        public static void ComputeStringValue(string word)
        {
            int result = 0;
            
            word = word.ToLower();
            char[] charList = word.ToCharArray(0, word.Length);

            // loop through the charList to assign integer value to word
            foreach (char letter in charList)
            {                
               //compensate for ASCII integer value of alphabet
               result += (int)letter - 96;
            }

            Console.WriteLine(result);
        }
    }
}


