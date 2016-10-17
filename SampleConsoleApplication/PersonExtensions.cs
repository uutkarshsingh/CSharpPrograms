using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApplication
{
     public static class PersonExtensions
    {
        public static void printNameofPerson(this Person person)
        {
            Console.WriteLine("Printing the name of the person ");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}
