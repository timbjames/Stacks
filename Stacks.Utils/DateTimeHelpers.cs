using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacks.Utils
{
    public class DateTimeHelpers
    {

        /// <summary>
        /// Returns either th, st, nd, rd for a day number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string GetOrginal(int num)
        {

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num.ToString() + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num.ToString() + "st";
                case 2:
                    return num.ToString() + "nd";
                case 3:
                    return num.ToString() + "rd";
                default:
                    return num.ToString() + "th";
            }

        }

    }
}
