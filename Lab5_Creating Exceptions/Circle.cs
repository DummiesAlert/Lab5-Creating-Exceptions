using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Creating_Exceptions
{
    internal class Circle
    {

        public double Radius;
        public double Rad 
        
        { 
            get { return Radius; } 

            set { 
                
                if (value > 0)

                {

                   Radius = value;

                }

                else

                {

                    throw new InvalidRadiusException(value, "Radius Value is NOT Valid");

                }

            }
        }
        public double Area

        {

            get { return (Math.Pow(Radius, 2) * Math.PI); }

        }
        public Circle(double Radius)

        {

            Rad = Radius;

        }
        public override string ToString()

        {

            return $"Radius: {Rad}";

        }

    }
}
