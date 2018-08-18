using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class PolygonAreaCalc
    {


        public static double DetCalc(double detA, double detB, double detC, double detD)
        {
            return detA * detD - detB * detC;
        }
    }
}
