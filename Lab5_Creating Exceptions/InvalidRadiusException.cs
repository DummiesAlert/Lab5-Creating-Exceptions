using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Creating_Exceptions
{
    internal class InvalidRadiusException : Exception
    {

        private double Rad;
        public double Radius { get { return Radius; } }
        public InvalidRadiusException(double Radius, string message) : base($"{message}: {Radius}")
        {
            Rad = Radius;
        }

    }
}
