using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    public class Square
    {
        private int sideA { get; set; }


        public Square(int a)
        {
            sideA = a;
        }

        /// <summary>
        /// Omkredsen
        /// O = side + side + side + side
        /// </summary>
        /// <returns></returns>
        public virtual double Omkredsen()
        {
            int omkreds = sideA * 4;
            return omkreds;
        }

        /// <summary>
        /// Arealet
        /// A = l* b
        /// </summary>
        public virtual double Areal()
        { 
            int areale = sideA * sideA;
            return areale;
        }
    }
}
