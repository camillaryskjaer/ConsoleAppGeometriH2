using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppGeometriH2
{
    class Parallelogram : Square
    {
        private int sideA;
        private int sideB { get; set; }
        private int vinkle { get; set; }


        public Parallelogram(int a , int b , int v) : base(a)
        {
            sideA = a;
            sideB = b;
            vinkle = v;
        }

        /// <summary>
        /// Areal
        /// 𝐴 = 𝑎 × 𝑏 × sin(𝜃)
        /// </summary>
        public override double Areal()
        {
            double vRadian = vinkle * Math.PI / 180;
            double areal = sideA * sideB * Math.Sin(vRadian);
            return areal;

        }

        /// <summary>
        /// Omkreds formel
        /// O = 2 * a + 2 * b
        /// </summary>
        /// <returns></returns>
        public override double Omkredsen()
        {
            double omkreds = 2 * sideA + 2 * sideB;
            return omkreds;
        }
    }
}
