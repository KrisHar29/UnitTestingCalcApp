using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public  class Calcu
    {
        public  double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }

        public  double Subtract(double x, double y)
        {
            double output = x - y;
            return output;
        }

        public  double Multiply(double x, double y)
        {
            double output = x * y;
            return output;
        }

        public  double Divide(double x, double y)
        {
            double output = x / y;
            return output;
        }
    }
}
