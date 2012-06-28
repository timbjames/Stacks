using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[100];
            for (int x = 0; x <= 99; x++)
            {
                i[x] = x;
            }
            var most = mostOften(i);
        }

        public static int mostOften(int[] a)
        {
            var most = a.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault();
            return (most != null) ? most.First() : -1;
        }

    }
}
