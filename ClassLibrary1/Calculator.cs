using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }

        public ICalc CurrentOperation { get; set; }

        public double Calc()
        { 
            return CurrentOperation?.Calc(X, Y) ?? 0;
        }
    }
}
