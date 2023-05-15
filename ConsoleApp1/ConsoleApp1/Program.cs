using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object numberNames;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose number 1-3");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TupleSix();
                    break;
                case 2:
                    TupleWithValues();
                    break;
                case 3:
                    WithSortedList();
                    break;
            }
        }


        private static void TupleWithValues()
        {
            ValueTuple<int, string, string> valueTuple = (69, "string", "string2");
            Console.WriteLine(valueTuple.ToString());
        }

        private static void TupleSix()
        {
            var values = Tuple.Create(1, 2, 3, 4, 5, 6);
            TupleParam(values);
        }

        private static void TupleParam(Tuple<int, int, int, int, int, int> values)
        {
            Console.WriteLine(values.ToString());
        }

        private static void WithSortedList()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(17, "seitseteist");
            numberNames.Add(15, "viisteist");
            numberNames.Add(18, "kaheksateist");
            numberNames.Add(12, "kaksteist");
            numberNames.Add(11, "üksteist");
            foreach (var kvp in numberNames)
            {
                Console.WriteLine($"{kvp.Key},{kvp.Value}");
            }

        }
    }
}

