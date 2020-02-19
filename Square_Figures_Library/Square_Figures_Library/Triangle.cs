using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Figures_Library
{
    public class Triangle: Figure
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }

        public Triangle(double x, double y, double z)
        {
            if (x <=0)
            {
                throw new ArgumentException("The value ​​of side " +
                                "must be positive.", nameof(x));
            }
            if (y <= 0)
            {
                throw new ArgumentException("The value ​​of side " +
                                "must be positive.", nameof(y));
            }
            if (z <= 0)
            {
                throw new ArgumentException("The value ​​of side " +
                                "must be positive.", nameof(z));
            }

            double sum = x + y + z;
            double side1 = Math.Max(Math.Max(x, y), z);
            double side2 = Math.Min(Math.Min(X, Y), Z);
            double side3 = sum - side1 - side2;

            if (side1 >= side2 + side3)
            {
                throw new ArgumentException("The value of the larger side " +
                    "must be less than the sum " +
                    "of the values ​​of other parties.", nameof(side1));
            }

            X = x;
            Y = y;
            Z = z;
        }
        public override double Area()
        {
            double p = (X + Y + Z) / 2;
            return Math.Pow((p * (p - X) * (p - Y) * (p - Z)), 0.5);
        }

        public bool IsRighTriangle()
        {
            double perimeter = X + Y + Z;
            double hypotenuse = Math.Max(Math.Max(X, Y), Z);
            double first_cathetus = Math.Min(Math.Min(X, Y), Z);
            double second_cathetus = perimeter - hypotenuse - first_cathetus;

            return (Math.Pow(first_cathetus, 2) +
                Math.Pow(second_cathetus, 2) == Math.Pow(hypotenuse, 2)) ? true : false;
        }
    }
}
 