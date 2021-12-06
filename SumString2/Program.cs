public class Program
{
  
    public static void Main(string[] args)
    {
        asciiPrint();
        /*
        string [] str = { "sahil", "shashanak", "sanjit","abhinav", "mohit" };
        string s = "abhinav";
        int n = s.Length;
        int score = stringScore(str,s,n);
        Console.WriteLine(score);
        */
    }
   
    //function to find string score

    //static int stringScore(string[] str, string s, int n)
    //{
    //    int score = 0, index = 0;
    //    for (int i = 0; i < n; i++)
    //    {
    //        if (str[i] == s)
    //        {
    //            for (int j = 0; j < s.Length; j++)
    //                score += s[j] - 'a' + 1;
    //            index = i + 1;
    //            break;
    //        }            
    //    }
    //    score = score * index;
    //    return score;
    //}

    //print ascii values of char

    public static void asciiPrint()
    {
        int sum = 0;
        int value = 0;
        string word = Convert.ToString(Console.ReadLine());
        word = word.ToLower();

        char[] charList = word.ToCharArray();

        foreach (char letter in charList)
        {
            //Console.WriteLine((int)letter - 96);
            value = (int)letter - 96;
            Console.WriteLine(value);
        }
    }
}

//a registers as 97 -->  97 - 96 = 1