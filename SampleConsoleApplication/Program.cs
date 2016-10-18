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


    public class LinkNode<T>
    {
        public T value; 

        public LinkNode<T> next { get; set; }

        public LinkNode(T valueMember)
        {
            Console.WriteLine("CREATING A NEW NODE");
            value = valueMember;
        }
    }


    public class LinkedList<T>
    {
        LinkNode<T> Start { get; set; }
        LinkNode<T> Last { get; set; }
        public LinkedList()
        {
            Start = Last = null;            
        }
        public void Add(T value)
        {
            if (Start == null && Last == null)
            {
                Start = new LinkNode<T>(value);
                Last = Start;
                Last.next = null;
            }
            else
            {
                Last.next = new LinkNode<T>(value);
                Last = Last.next;
            }    
        }

        public void Display()
        {
            if (Start == null && Last == null)
            {
                Console.WriteLine("The liknedLIst is empty");
            }

            LinkNode<T> traversingNode = Start;
            while (traversingNode != null)
            {
                Console.WriteLine(traversingNode.value);
                traversingNode = traversingNode.next;

            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("utkarsh");
            list.Add("Pragati");
            list.Add("Ramesh");

            list.Add("utkarsh");
            list.Add("Pragati");
            list.Add("Ramesh");
            
            list.Display();

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
