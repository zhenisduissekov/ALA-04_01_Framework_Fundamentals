namespace Task5
{
    using System;

    /// <summary>
    /// Class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Hello World!"));
            Console.WriteLine(ReverseWords("The greatest victory is that which requires no battle"));
        }

        /// <summary>
        /// Function to reverse sentences
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static public string ReverseWords(string str)
        {
            string result = string.Empty;
            string[] temp = str.Split();
            
            for (int i = temp.Length - 1; i > -1; i--)
            {
                result += " " + temp[i];
            }
            return result.Trim();
        }
    }
}
