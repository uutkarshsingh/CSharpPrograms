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

		public Dimension(int leangth, int breadth)
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
	public class DocumentManager<TDocument> where TDocument : IDocument
	{
		private readonly Queue<TDocument> documentQueue = new Queue<TDocument>();

		public void AddDocument(TDocument doc)
		{
			documentQueue.Enqueue(doc);
		}

		public bool IsDocumentPresent
		{
			get { return documentQueue.Count > 0; }
		}

		public void DisplayAllDocuments()
		{
			foreach (TDocument doc in documentQueue)
			{ 
				Console.WriteLine(((IDocument)doc).Title);
			}
		}
	}
	public interface IDocument
	{
		string Title { get; set; }
		string Content { get; set; }
	}

	public class Document : IDocument
	{
		public string Title { get; set; }
		public string Content { get; set; }

		public Document()
		{ 
		
		}

		public Document(string title, string content)
		{
			this.Title = title;
			this.Content = content;
		}
	}

	public class ListOfPerson : List<Person>
	{
		List<Person> listOfPerson = new List<Person>();

		public IEnumerator<Person> GetEnumerator()
		{

			for (int count = 0; count < listOfPerson.Count; count++)
			{
				yield return listOfPerson[count];
			}
		}
		
	}


	public class House
	{
		public string Name { get;  set;}
		public string Address { get;  set;}

		public override string ToString()
		{
			return string.Format("[House: Name={0}, Address={1}]", Name, Address);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			List<House> ListOfHouses = new List<House>();

			ListOfHouses.Add(new House() { Name = "White House", Address = " Capitol hill, Washington DC,California" } );
			ListOfHouses.Add(new House() { Name = "Prime Minister's Residence" ,Address = "10 , Downing Street"});

			for (int count = 0; count < ListOfHouses.Count; count++)
			{ 
				Console.WriteLine(ListOfHouses[count]);
			}

			Console.ReadLine();
        }
    }
}
