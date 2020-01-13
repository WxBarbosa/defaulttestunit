using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultTestUnit.Domain.Interfaces
{
    public interface ICalculator
    {
        double Sum(double[] listNumbers);

        double Multiply(double[] listNumbers);
    }
}
