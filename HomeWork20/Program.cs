using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using lesson3.ViewModel;

namespace HomeWork20
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задача 1
            //int[] numbers = { 7, 6, 5, 4, 3, 2, 1 };

            //IEnumerable<int> num = from i in numbers

            //                       select i;

            //foreach (var i in num.Reverse())
            //{

            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            //----------------------------------------------------------//

            //Задача 2

            //int[] numbers = { 1, 2, 3, 4, 5, -4, -3,-2, -1};

            //IEnumerable<int> num = from i in numbers
            //                       where i > 0
            //                       select i;
            //IEnumerable<int> num2 = from y in numbers
            //                       where y < 0
            //                       select y;

            //Console.WriteLine(num.Count());
            //Console.WriteLine(num2.Sum());

            //Console.ReadKey();

            //----------------------------------------------------------//

            //Задача 3
            //List<Word> words = new List<Word>();

            //words.Add(new Word { Name = "Iphone" });
            //words.Add(new Word { Name = "Notebook" });
            //words.Add(new Word { Name = "Book" });
            //words.Add(new Word { Name = "Pen" });

            //var items = from u in words
            //            orderby u.Name.Length
            //            select u;

            //foreach (var i in items)
            //{

            //    Console.WriteLine(i.Name);
            //}
            //Console.ReadKey();



            //----------------------------------------------------------//

            //Задача 4

            List<int> ages = new List<int> { 5, 2, 2, 2, 2, 2 };

            var Uniqlist = ages.GroupBy(x => x).Where(p => p.ToList().Count == 1).Select(p => p.Key);

            foreach (var item in Uniqlist)
            {
                Console.WriteLine(item);
            }
                
            Console.ReadKey();

        }


    }
}
