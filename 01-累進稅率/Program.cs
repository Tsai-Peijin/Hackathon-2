using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_累進稅率
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal A = 540000;
            decimal B = 1210000;
            decimal C = 2420000;
            decimal D = 4530000;
            decimal E = 10310000;
            Console.Write("請輸入年收入：");
            decimal income = int.Parse( Console.ReadLine());
            decimal[] tax = { A*0.07m, B*0.08m, C*0.1m, D*0.1m, E*0.1m };
            decimal x = 0;
            decimal money = 0;

            if (0 < income && income<=A)
            {
                x = 0;
                money = income * 0.05m - x;
            }
            if (A < income && income <= B)
            {
                x = tax[0];
                money = income * 0.12m - x;
            }
            if (B < income && income <= C)
            {
                x = tax[0] + tax[1];
                money = income * 0.2m - x;
            }
            if (C < income && income <= D)
            {
                x = tax[0] + tax[1] + tax[2];
                money = income * 0.3m - x;
            }
            if (D < income && income <= E)
            {
                x = tax[0] + tax[1] + tax[2] + tax[3];
                money = income * 0.4m - x;
            }
            if (E < income)
            {
                x = tax[0] + tax[1] + tax[2] + tax[3] + tax[4];
                money = income * 0.5m - x;
            }
            Console.WriteLine();
            Console.WriteLine("你的所得：" + income);
            Console.WriteLine("你所需要繳的稅：" + money.ToString());
            Console.ReadLine();
        }
    }
}
