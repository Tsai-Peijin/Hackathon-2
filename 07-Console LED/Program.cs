using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Console_LED
{
    class Program
    {
        static void Main(string[] args)
        {
            string A0 = "   ";
            string A1 = " _ ";

            string B1 = "|_|";
            string B2 = "| |";
            string B3 = " _|";
            string B4 = "|_ ";
            string B5 = " | ";
            string B6 = "  |";
            Console.Write(A1 + A0 + A1 + A1 + A0 + A1 + A1 + A1 + A1 + A1+ Environment.NewLine);
            Console.Write(B2 + B5 + B3 + B3 + B1 + B4 + B4 + B6 + B1 + B1 + Environment.NewLine);
            Console.Write(B1 + B5 + B4 + B3 + B6 + B3 + B1 + B6 + B1 + B3 + Environment.NewLine);
            
            Console.ReadLine();

        }
    }
}
