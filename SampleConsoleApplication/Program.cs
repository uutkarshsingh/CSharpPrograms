using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApplication
{

    struct Dimension
    {
        public int Length;
        public int Breadth;

        public Dimension(int leangth ,int breadth)
        {
            System.Console.WriteLine("Constructin gthe obejct from the struct");
            Length = leangth;
            Breadth = breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Dimension dimension2;
            dimension2.Length = 21;
            dimension2.Breadth = 100;

            System.Console.WriteLine(dimension2.Breadth);
            Console.WriteLine(dimension2.Length);

            System.ValueType atr ;

            Dimension dimension1 = new Dimension();
            int vaa = dimension1.Length;
            Console.WriteLine("PRINTGINT SOMEVALUS FOR SHOWING ON THE SCREEN");
            Console.ReadKey();
        }
    }
}
