using System;

namespace TamKarekok
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1; i <= 1000; i++)
            {
                if (Math.Sqrt(i).ToString().Length == 2 || Math.Sqrt(i).ToString().Length == 1)
                {
                    Console.WriteLine("{0} sayısının karekökü {1}", i, Math.Sqrt(i));
                }

            }
        }
    }
}
