using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
     public partial class Calculator
        {
            partial void OnCalculated(double result)
            {
                Console.WriteLine($"Log: result = {result}");
            }
        }
}
