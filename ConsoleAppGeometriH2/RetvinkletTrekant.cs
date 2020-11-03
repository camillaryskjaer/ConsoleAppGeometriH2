using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    class RetvinkletTrekant : Square
    {
        int sideA;
        int sideB { set; get; }

        public RetvinkletTrekant(int a, int b) : base (a)
        {
            sideA = a;
            sideB = b;
        }


        /// <summary>
        /// Areal
        /// A = ½ * a * b 
        /// </summary>
        /// <returns></returns>
        public override double Areal()
        {
            double areal = 0.5 * sideA * sideB;
            return areal;
        }

        /// <summary>
        /// Omkredsen
        /// O = a + b + c
        /// </summary>
        /// <returns></returns>
        public override double Omkredsen()
        {
            double c = this.Hypotenusen();
            double omkreds = sideA + sideB + c;
            return omkreds;   
        }

        /// <summary>
        /// Pythagoras
        /// c = kvadratrod a^2 + b^2 
        /// </summary>
        /// <returns></returns>
        private double Hypotenusen()
        {
            double hyp = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return hyp;
        }
    }
}
