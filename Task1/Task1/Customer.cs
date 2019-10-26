//-----------------------------------------------------------------------
// <copyright file="NumberManipulator.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Task1
{

    using System;
    using System.Text;
    using System.Globalization;

    /// <summary>
    /// Customer class with properties
    /// </summary>
    public class Customer
    {
        public String Name { get; set; }
        public Decimal Revenue { get; set; }
        public String ContactPhone { get; set; }

        public Customer(string name, Decimal revenue, string contactPhone)
        {
            Name = name;
            Revenue = revenue;
            ContactPhone = contactPhone;
        }
    }
}
