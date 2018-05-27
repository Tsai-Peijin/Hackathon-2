using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_回文測試
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串數字或英文判斷是否回文：");
            string x = Console.ReadLine();
            char[] A= x.ToCharArray();
            Array.Reverse(A);
            string y = new string(A);
            
            if (x.Equals(y))
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
            Console.ReadLine();
        }
    }
}
