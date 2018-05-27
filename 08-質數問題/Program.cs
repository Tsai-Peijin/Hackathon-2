using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_質數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, x;
            for ( i = 101; i <= 200; i++)
            {
                x = 1;
                for ( j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        x = 0;
                        break;
                    }
                }
                if (x == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
