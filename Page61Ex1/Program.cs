using System;

namespace Page61Ex1
{

    class MainClass
    {
        static void Check_Brackets(string test)
        {
            if ((test.IndexOf('(') < 0) || (test.IndexOf(')') < 0))
                Console.WriteLine("false");
            else
            {
                int appearance = 0;
                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == '(')
                        appearance++;
                    else if (test[i] == ')')
                        appearance--;
                    if ((appearance == 0) & (i == test.Length - 1))
                        Console.WriteLine("true");
                    else if ((appearance != 0) & (i == test.Length - 1))
                        Console.WriteLine("false");
                }
            }
        }

        public static void Main(string[] args)
        {
            string test = Console.ReadLine();
            Check_Brackets(test);
        }
    }
}
