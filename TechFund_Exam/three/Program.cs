using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace three
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double initialN =(double)(N)+0.0;
            var M = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());


            if (N<1 || M<1)
            {
                return;
            }
            var count = 0;

            while (M<=N)
            {
                N = N - M;
                count++;
                double fiftyPercent = (double)N / initialN;
                    if (fiftyPercent==0.5)
                {
                    if (Y<1 || Y>N)
                    {
                        continue;
                    }
					N = N /Y;

                }


            }
            Console.WriteLine($"{N}");
            Console.WriteLine($"{count}");
        }
    }
}
