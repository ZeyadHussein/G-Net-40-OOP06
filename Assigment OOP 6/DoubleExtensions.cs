using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public static class DoubleExtensions
    {
        public static string ToCurrency(this double value)
            => $"${value:F2}";
    }
}
