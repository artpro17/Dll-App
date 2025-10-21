using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BMI
    {
        public static double CalculateBMI(double mass, double height)
        {         
            return mass / (height * height);
        }
    }
}
