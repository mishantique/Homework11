using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    struct Equation
    {
        double k;
        double b;
        public Equation(double k, double b) 
        { 
            this.k = k;
            this.b = b;
        }

        public string Root() 
        {   
            if (k != 0)
            {
                double root = -b / k;
                return $"Решение уравнения: x = {root}";
            }
            else
            {
                return $"Решение уравнения: x - любое";
            }
            
        }
    }
}
