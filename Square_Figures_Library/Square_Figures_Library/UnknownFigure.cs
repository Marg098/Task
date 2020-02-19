using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Figures_Library
{
    public class UnknownFigure
    {
        public double AreaObject(params double[] inputs)
        {
            switch (inputs.Length)
            {
                case 1: Circle shape_c = new Circle(inputs[0]); return shape_c.Area(); 
                case 3: Triangle shape_t = new Triangle(inputs[0], inputs[1], inputs[2]); return shape_t.Area();
                default: throw new ArgumentException("Not enough data.");
            }
        }
    }
}
