using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Utility
{
    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
