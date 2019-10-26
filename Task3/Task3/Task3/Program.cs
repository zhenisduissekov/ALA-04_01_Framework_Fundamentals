//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// Task 2 create TitleCase function
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Task3
{
    using System;
    using System.Text;

    public class Program
    {
        /// <summary>
        /// My Main where i put a few sample urls
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine(AddOrChangeUrlParameter("www.example.com", "key=value"));
            Console.Write(AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2"));
            Console.Write(AddOrChangeUrlParameter("www.example.com?key=value", "key=value2"));
            Console.WriteLine(AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue"));
            Console.WriteLine(AddOrChangeUrlParameter("www.example.com?key=oldValue&key1=Rvas", "key=newValue"));
            Console.Write(AddOrChangeUrlParameter("www.example.com?key=oldValue&key1=Rvas&key2=wds", "key2=newValue"));
            Console.Write(AddOrChangeUrlParameter("www.example.com?key=oldValue&key1=Rvas", "key1=newValue"));
        }

        /// <summary>
        /// Method to add or change parameter
        /// First searches for ? parameter
        /// Then splits new url parameter into key and value
        /// Next looks for same key, if not found adds in the end of url
        /// If there is, then replaces the value
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url_param"></param>
        /// <returns></returns>
        public static string AddOrChangeUrlParameter(string str, string url_param)
        {
            string result = string.Empty;
            if (str.IndexOf("?", StringComparison.Ordinal) == -1)
            {
                result += str + "?" + url_param;
            }
            else
            {
                string[] key = url_param.Split("=");
                if (str.IndexOf(key[0], StringComparison.Ordinal) == -1)
                {
                    result += str + "&" + url_param;
                }
                else
                {
                    int i = str.IndexOf(key[0], StringComparison.Ordinal);
                    int j = i + str[i..].IndexOf("=", StringComparison.Ordinal);
                    int k;
                    if (str[j..].IndexOf("&", StringComparison.Ordinal) == -1)
                    {
                        k = str.Length - j;
                        result = str.Substring(0, j + 1) + key[1];
                    }
                    else
                    {
                        k = str[j..].IndexOf("&", StringComparison.Ordinal);
                        result = str.Substring(0, j + 1) + key[1] + str.Substring(k + j, str.Length - 1 - k - j);
                    }
                }
            }

            return result;
        }
    }
}