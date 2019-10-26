using System;

namespace Task1
{
    /// <summary>
    /// Class Program
    /// </summary>

    class Program
    {
        static void Main()
        {
            OutputCustomerData a = new OutputCustomerData("Jofrey", 1000000, "+1(343) 545 32 12");
            Console.WriteLine(a);
            Console.WriteLine(a.Name);
            Console.WriteLine(a.ContactPhone);
            Console.WriteLine(a.Revenue);
            Console.WriteLine(a);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.ToString("A"));
            Console.WriteLine(a.ToString("a"));
            Console.WriteLine(a.ToString("B"));
            Console.WriteLine(a.ToString("c"));
            Console.WriteLine(a.ToString("d"));
            Console.WriteLine(a.ToString("e"));
        }
    }
}
