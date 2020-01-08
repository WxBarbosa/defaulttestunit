using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultTestUnit.Domain.Helpers
{
    public class Calculator
    {
        public double Sum(double[] listNumbers)
        {
            double total = 0;
            foreach (double number in listNumbers)
                total += number;
            return total;
        }

        public double Multiply(double[] listNumbers)
        {
            double total = 1;
            foreach (double number in listNumbers)
                total *= number;
            return total;
        }
    }
}
