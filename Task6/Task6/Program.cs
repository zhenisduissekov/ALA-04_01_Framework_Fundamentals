//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------
namespace Task6
{
    using System;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main where there are some sample inputs
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string[] a = { "3333311111111111", "7777555511111111" };
            string[] b = { "44422222221111",      "3332222221111" };
            string[] r = { "3377733333332222", "7780887733332222" };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Format("{0,20}\n+\n{1,20}\n=\n{2,20}\n", a[i], b[i], SumOfBigNumbers(a[i], b[i])));
                if (SumOfBigNumbers(a[i], b[i]) == r[i])
                {
                    Console.WriteLine("Correct\n");
                }
                else
                {
                    Console.WriteLine("Wrong\n");
                }
            }
        }

        /// <summary>
        /// method to sum big numbers that are given in strings
        /// output is also string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string SumOfBigNumbers(string str1, string str2)
        {
            if (str1 == null)
            {
                return str2;
            }

            if (str2 == null)
            {
                return str1;
            }

            string str1_rev = Reverse(str1);
            string str2_rev = Reverse(str2);

            int i_min = (str1.Length < str2.Length) ? str1.Length : str2.Length;
            string max = (str1.Length > str2.Length) ? str1_rev : str2_rev;
            string result = string.Empty;
            int carry_out = 0;
            int sum_A_B = 0;
            for (int i = 0; i < i_min; i++)
            {
                sum_A_B = (int)(str1_rev[i] - '0') + (int)(str2_rev[i] - '0') + carry_out;
                carry_out = (sum_A_B > 9) ? 1 : 0;
                result += (sum_A_B % 10).ToString();
            }

            if (carry_out == 1)
            {
                result += (((int)max[i_min] - '0') + 1).ToString();
            }
            else
            {
                result += max[i_min];
            }

            i_min++;
            result += max[i_min..];

            string str_result = Reverse(result);
            return str_result;
        }

        /// <summary>
        /// method to reverse the string.
        /// uses array.reverse method
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
