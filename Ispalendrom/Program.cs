using System;

namespace Ispalendrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string x= "Rabr";
            bool y=ispalindrome(x);
            Console.WriteLine(x+" "+y);
        }
        public static bool ispalindrome(string s)
        {
            string text = s.ToLower();
            if (text.Length == 1)
            {
                return false;
            }
            int start = 0;
            int end = text.Length-1;
            while (true)
            {
                if (text[start] != text[end])
                {
                    return false;
                }
                if (start>end)
                {
                    return true;
                }
                
                start++;
                end--;
            }
            
        }
    }
}
