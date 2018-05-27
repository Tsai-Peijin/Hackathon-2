using _06_文字檔讀取_判斷與轉換.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文字檔讀取_判斷與轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var lines = File.ReadAllLines("test03.txt");
            // string i = string.Empty;
            CultureInfo zhtw = new CultureInfo("zh-tw");
            foreach (var i in lines)
            {
                if (i.Substring(0, 3) == "695" || i.Substring(0, 3) == "525")
                {
                    DateTime.TryParseExact(i.Substring(13, 8), "yyyyMMdd", zhtw, DateTimeStyles.None, out DateTime dateValue1);
                    DateTime.TryParseExact(i.Substring(21, 8), "yyyyMMdd", zhtw, DateTimeStyles.None, out DateTime dateValue2);
                    Table data = new Table()
                    {
                        TickNumber = i.Substring(0, 13),
                        FlyingDay = dateValue1,
                        BirthDay = dateValue2
                    };
                    try
                    {
                        ContactsModel context = new ContactsModel();
                        context.Table.Add(data);
                        context.SaveChanges();
                        Console.WriteLine($"{data.TickNumber}  {data.FlyingDay.ToString("yyyy/MM/dd")}  {data.BirthDay.ToString("yyyy/MM/dd")}");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("發生錯誤" + ex);
                    }
                }
            }
           // var list = new ContactsModel();
           // var list2 = list.Table.ToList();
           //foreach(var i in list2)
           // {
           //     Console.WriteLine(i.TickNumber + " " + i.FlyingDay + " " + i.BirthDay);
           // }
            Console.ReadLine();
            
        }

    }
}
