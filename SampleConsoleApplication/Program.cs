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


    class StaticClass
    {
        static StaticClass()
        {
            Console.WriteLine("calling the contructor FOR STATICCLASS");
        }

        public static void customMethod()
        {
            Console.WriteLine("CALLING THE CUSTOM METHOD"); 
        }
        public override int GetHashCode()
        {

            Console.WriteLine("PRINTG THE FIRST HASHCODE");
            Console.WriteLine(base.GetHashCode());
            Console.WriteLine("THE HASCODE IS GEIVEN ABOVE");
            return 123456;
        }

        public override string ToString()
        {
            Console.WriteLine("CALLINF THE STRING METHOD TO THE CLASS");

            return "THE STATIC CLASS WHICH GIVES THE CONTROL ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personExample = new Person()
            {
                FirstName = "Utkarsh",
                LastName = "Rathor"
            };

            personExample.printNameofPerson();

            StaticClass.customMethod();

            StaticClass staticClass = new StaticClass();

            Console.WriteLine(staticClass);

            Console.WriteLine(staticClass.GetHashCode());

            Console.ReadLine();
        }
    }
}
