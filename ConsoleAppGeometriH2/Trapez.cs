using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    class Trapez : Square
    {
        private int sideA;

        public Trapez(int a) : base(a)
        {
            sideA = a;
        }


        /// <summary>
        /// Arealet
        /// A = ½ * (a + b) * h
        /// </summary>
        /// <returns></returns>
        public override double Areal()
        {
            return base.Areal();
        }
    }
}
