using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_千元買百雞
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; // 公雞
            int y = 0; // 母雞
            int z = 0; // 小雞

            while ((x + y + z != 100) && (60 * x + 30 * y + z) != 1000)
            {
                x++;

                if ((900 - (59 * x)) % 29 == 0)
                {
                    y = ((900 - 59 * x) / 29);
                    z = (100 - x - y);
                }
            }
            Console.WriteLine($"公雞：{x} 母雞：{y} 小雞：{z}");
            Console.ReadLine();
            
            
        }
    }
}
