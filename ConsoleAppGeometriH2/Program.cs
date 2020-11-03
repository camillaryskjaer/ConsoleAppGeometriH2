using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objecter
            Square square0 = new Square(10);
            Square square1 = new Square(20);
            Square square2 = new Square(30);
            Square square3 = new Square(40);
            #endregion

            #region Omkredsen del (CW)
            Console.WriteLine("kvadratens omkredsen er " + square0.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square1.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square2.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square3.Omkredsen());
            #endregion

            #region Areal del (CW)
            Console.WriteLine("kvadratens Areal er " + square0.Areal());
            Console.WriteLine("kvadratens Areal er " + square1.Areal());
            Console.WriteLine("kvadratens Areal er " + square2.Areal());
            Console.WriteLine("kvadratens Areal er " + square3.Areal());
            #endregion

            #region Parallelogram

            Square parallelogram = new Parallelogram(3,5,20);


            Console.WriteLine("Parallelogram areal er " + parallelogram.Areal());

            #endregion

            Console.ReadKey();
        }
    }
}
