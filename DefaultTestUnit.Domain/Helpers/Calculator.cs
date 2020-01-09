using System;
using System.Collections.Generic;
using System.Text;
using DefaultTestUnit.Domain.Interfaces;

namespace DefaultTestUnit.Domain.Helpers
{
    public class Calculator : ICalculator
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
