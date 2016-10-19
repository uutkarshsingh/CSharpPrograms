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
    class Program
    {
        static void Main(string[] args)
        {


			List<int> listOfInts = new List<int>();

			listOfInts.Add(12);
			listOfInts.Add(321);
			listOfInts.Add(432);

			IEnumerator<int> enumerator = listOfInts.GetEnumerator();

			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);
			Console.WriteLine(enumerator.MoveNext());
			Console.WriteLine(enumerator.Current);

			List<Person> listOfPerson = new List<Person>();

			listOfPerson.Add(new Person() { FirstName = "Utkarsh", LastName = "Rathor" }) ;
			listOfPerson.Add(new Person() { FirstName = "Vivek", LastName = "Sharma" });
			listOfPerson.Add(new Person() { FirstName = "Ranil", LastName = "VikramSinghe" });



			foreach ( Person person in listOfPerson )
			{ 
				Console.WriteLine(person.FirstName + " " +person.LastName);
			}

				Person[] personArray = new Person[2];

			Console.WriteLine(personArray);

			personArray[0] = new Person() { FirstName = "Utkarsh", LastName = "Rathor" };
			personArray[1] = new Person() { FirstName = "Pragati", LastName = "Rathor" };




			Console.WriteLine(personArray[0]);
			Console.WriteLine(personArray[1]);

			Person personExample1 = new Person()
			{
				FirstName = "Utkarsh",
				LastName = "Rathor"
			};
			int a = 10, b = 111;
			Console.WriteLine(a + "  " +b);
			personExample1.Swap(ref a, ref b);
			Console.WriteLine(a + " " + b);


			var dm = new DocumentManager<Document>();
			dm.AddDocument(new Document() { Title = "ABC",Content="new content"});
			dm.AddDocument(new Document() { Title = "PQR", Content = "Once upon a time" });
			dm.AddDocument(new Document() { Title="SHERLOCK HOLMES" ,Content ="Sir Aurthus doyle"});
			dm.DisplayAllDocuments();

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
