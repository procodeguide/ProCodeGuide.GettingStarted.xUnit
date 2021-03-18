using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.GettingStarted.xUnit.Services
{
    public interface IMathsService
    {
        double Add(double x1, double x2);
        double Subtract(double x1, double x2);
        double Multiply(double x1, double x2);
        double Divide(double x1, double x2);
    }
}
