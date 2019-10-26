//-----------------------------------------------------------------------
// <copyright file="OutputCustomerData.cs" company="EPAM">
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
    ///  OutputCustomerData to customize my output data
    /// </summary>
    public class OutputCustomerData : Customer
    {

        public OutputCustomerData(string name, Decimal revenue, string contactPhone) : base(name, revenue, contactPhone)
        {
        }
        /// <summary>
        /// custom method ToString (override)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string formatString = "-Customer record: {0}, {1}, {2:###,###,###.00}";
            var sb = new StringBuilder();
            sb.AppendFormat(formatString, Name, ContactPhone, Revenue);
            return sb.ToString();
        }

        /// <summary>
        /// Custom ToString method (overloading)
        /// </summary>
        /// <param name="fmt"></param>
        /// <returns></returns>
        public string ToString(string fmt)
        {
            switch (fmt.ToUpperInvariant())
            {
                case "A":
                    return string.Format("-Customer record: {0}, {1}, {2:###,###,###.00}", Name, ContactPhone, Revenue);
                case "B":
                    return string.Format("-Customer record: {0}", ContactPhone);
                case "C":
                    return string.Format("-Customer record: {0}, {1}", Name, ContactPhone);
                case "D":
                    return string.Format("-Customer record: {0}, {1:###,###,###.00}", Name, Revenue);
                case "E":
                    return string.Format("-Customer record: {0}", Revenue);
                default:
                    string msg = string.Format("'{0}' is an invalid format string", fmt);
                    throw new ArgumentException(msg);
            }
        }
    }
}
