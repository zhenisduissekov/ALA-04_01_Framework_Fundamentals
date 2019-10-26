//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// Task 2 create TitleCase function
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Task2
{
    using System;
    using System.Text;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main where some test sentences used
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(TitleCase());
            Console.WriteLine(TitleCase("a an the of", "a clash of KINGS"));
            Console.WriteLine(TitleCase("The In", "THE WIND IN THE PILLOWS"));
            Console.WriteLine(TitleCase("the quick brown fox"));
            Console.WriteLine(TitleCase("My young friend", "why so sad", "want to play?"));
            Console.WriteLine(TitleCase("my up", "my x-box heats up"));
        }

        /// <summary>
        /// TitleCase function
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TitleCase(params string[] str)
        {
            string work_string;
            string ex_list;
            switch (str.Length)
            {
                case 0:
                    return "No arguments were entered";
                case 1:
                    ex_list = string.Empty;
                    work_string = str[0].ToLower();
                    break;
                case 2:
                    ex_list = str[0].ToLower();
                    work_string = str[1].ToLower();
                    break;
                default:
                    return "To many arguments were entered";
            }

            StringBuilder sb = new StringBuilder();

            int i = 0;

            foreach (var word in work_string.Split())
            {
                if (i == 0)
                {
                    sb.Append(char.ToUpperInvariant(word[0]) + word[1..]);
                }
                else if (ex_list.IndexOf(word, StringComparison.Ordinal) != -1)
                {
                    sb.Append(" " + word);
                }
                else
                {
                    sb.Append(" " + char.ToUpperInvariant(word[0]) + word[1..]);
                }

                i++;
            }

            string result = sb.ToString();
            return result;
        }
    }
}
