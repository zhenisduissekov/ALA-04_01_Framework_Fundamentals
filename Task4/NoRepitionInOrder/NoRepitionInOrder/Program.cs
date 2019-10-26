//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
// Tried hard but was not able to implement using IEnumerable interface.
// Cannot understand interfaces
//-----------------------------------------------------------------------

namespace TestDomain
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class program
    /// </summary>
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(string.Join(", ", UniqueInOrder("ABBCcAD")));
            Console.WriteLine(string.Join(", ", UniqueInOrder("AAAABBBCCDAABBB")));
            Console.WriteLine(string.Join(", ", UniqueInOrder("12233")));
            Console.WriteLine(string.Join(", ", UniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 })));
        }

        /// <summary>
        /// if the input is string
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string UniqueInOrder(string v)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(v[0]);
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i - 1] != v[i])
                {
                    sb.Append(v[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// if the input is a list of double
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<double> UniqueInOrder(List<double> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i + 1);
                }
            }

            return list;
        }

    }
}

