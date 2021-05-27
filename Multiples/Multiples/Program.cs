using System;
using System.Collections.Generic;


namespace Multiples
{
    class Program
    {
        List<int> numl1 = new List<int>();
        List<int> numl2 = new List<int>();
        static int val1 = 0;
        static int val2 = 0;
        static int checkval = 0;
        static int Result = 0;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Multiples Machine");
                Console.WriteLine("Please Enter First Multiple Value:");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Second Multiple Value:");
                val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Max Value to Check Values up to:");
                checkval = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < checkval; i += val1)
                {
                    Result += i;
                }
                for(int  i = 0; i < checkval; i += val2)
                {
                    if(i%val1 != 0)
                    {
                        Result += i;
                    }
                }
                Console.WriteLine("Result: " + Result);
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
