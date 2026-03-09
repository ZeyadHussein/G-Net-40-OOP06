using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public partial class Calculator
    {
        public double LastResult { get; private set; }
        partial void OnCalculated(double result);

        public double Add(double a, double b)
        {
            LastResult = a + b;
            OnCalculated(LastResult);
            return LastResult;
        }
    }
}
