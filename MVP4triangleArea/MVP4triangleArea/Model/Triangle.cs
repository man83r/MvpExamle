using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP4triangleArea.Model
{
    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double getArea()
        {
            double halfPerim = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(halfPerim * (halfPerim - Side1) * (halfPerim - Side1) * (halfPerim - Side1));
        }

    }
}
