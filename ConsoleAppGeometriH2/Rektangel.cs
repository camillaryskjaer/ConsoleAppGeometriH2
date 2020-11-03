using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    public class Rektangel : Square
    {
        private int sideA;
        private int sideB { set; get; }
 
        public Rektangel(int a, int b) : base(a)
        {
            sideA = a;
            sideB = b;
        }

        /// <summary>
        /// Areal
        /// A = a * b
        /// </summary>
        /// <returns></returns>
        public override double Areal()
        {
            double areal = sideA * sideB;
            return areal;
        }

        /// <summary>
        /// Omkredsen
        /// O = 2 * (a + b)
        /// </summary>
        /// <returns></returns>
        public override double Omkredsen()
        {
            double omkreds = 2 * (sideA + sideB);
            return omkreds;
        }
    }
}
