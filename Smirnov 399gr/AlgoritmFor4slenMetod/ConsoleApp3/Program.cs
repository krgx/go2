using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int k = 0;
            double iskLast = 4;
            double isk = Vicislen(iskLast);
            bool chek = true;
            while (true)
            {
                if (Math.Abs(isk - iskLast) > 0.001)
                {
                    Console.WriteLine(isk + " " + k);
                    iskLast = isk;
                    isk = Vicislen(iskLast);
                    k ++;
                    
                }
                else
                {
                    chek = false;
                }
            }

        }

        static double Vicislen(double a)
        {
            double m;
            m = Math.Sin(a) + 4;
            return m;
        }
    }
}
