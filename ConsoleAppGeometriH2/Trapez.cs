using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    class Trapez : Square
    {
    //Side A eksisterer jo allerede i superklassen, hvorfor er den med her?
        private int sideA;
        private int sideB { get; set; }
        private int sideC { get; set; }
        private int sideD { get; set; }

        public Trapez(int a, int b, int c, int d) : base(a)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            sideD = d;

        }


        /// <summary>
        /// Arealet
        /// A = ½ * (a + b) * h
        /// </summary>
        /// <returns></returns>
        public override double Areal()
        {
            double areal = 0.5 * (sideA + sideB) * this.Højde();
            return areal;
        }

        /// <summary>
        /// Højde 
        /// h = 2 / a - c * kvadratrod s * (s - a + c) * (s - b) * (s - d)
        /// </summary>
        private double Højde()
        {
            double s = this.Side();
            double højde = (2 / (sideA - sideC)) * Math.Sqrt(s * ((s - sideA + sideC) * (s - sideB) * 
                (s - sideD)));

            return højde;
        }

        /// <summary>
        /// Side 
        /// s = (a + b - c + d) / 2
        /// </summary>
        private double Side()
        {
            double side = (sideA + sideB - sideC + sideD) / 2;
            return side;
        }
    }
}
