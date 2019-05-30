using System;

namespace Page28Ex12
{
    public class Palindrome
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void Plndrm(string palindrome)
        {
            int middle_position;
            int palindrome_length = palindrome.Length;
            if ((palindrome_length) % 2 == 0)
            {
                middle_position = palindrome_length / 2;
                string Estr = palindrome.Substring(middle_position);
                string Estr_Reverse = Reverse(Estr);
                string Bstr = palindrome.Remove(middle_position);
                if (Estr_Reverse == Bstr)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
            else if ((palindrome_length) % 2 != 0)
            {
                middle_position = (palindrome_length / 2) + 1;
                string Estr = palindrome.Substring(middle_position);
                string Estr_Reverse = Reverse(Estr);
                string Bstr = palindrome.Remove(middle_position - 1);
                if (Estr_Reverse == Bstr)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Add string, mortal!");
            string palindrome = Console.ReadLine();
            Palindrome middle = new Palindrome();
            middle.Plndrm(palindrome);
        }
    }
}
