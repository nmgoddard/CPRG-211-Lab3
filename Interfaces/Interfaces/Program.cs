using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	interface IAnimal
	{
		string Name { get; set; }
		string Color { get; set; }
		int Height { get; set; }
		int Age { get; set; }
		void Eat();
		string Cry();
	}

	class Dog : IAnimal
	{
		private string name;
		public string Name { get; set; }
		private string color;
		public string Color { get; set; }
		private int height;
		public int Height { get; set; }
		private int age;
		public int Age { get; set; }
		public Dog() { }
		public Dog(string name) 
		{
			Name = name;
		}

		public void Eat() 
		{
			Console.WriteLine("Dogs eat meat.");
		}

		public string Cry() 
		{
			Console.WriteLine("Woof!");
			return "Woof!";
		}
	}

	class Cat: IAnimal 
	{
		private string name;
		public string Name { get; set; }
		private string color;
		public string Color { get; set; }
		private int height;
		public int Height { get; set; }
		private int age;
		public int Age { get; set; }
		public Cat() { }
		public Cat(string name)
		{
			Name = name;
		}

		public void Eat()
		{
			Console.WriteLine("Cats eat mice.");
		}

		public string Cry()
		{
			Console.WriteLine("Meow!");
			return "Meow!";
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-- Interfaces --\n");

			Console.Write("Please enter a dog name: ");
			string dogName = Console.ReadLine();
			Dog dog = new Dog(dogName);
			Console.Write("Please give the dog a color: ");
			dog.Color = Console.ReadLine().ToLower();
			Console.Write("Please give the dog a height (in cm): ");
			dog.Height = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please give the dog an age: ");
			dog.Age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"The dogs name is {dog.Name}, it is {dog.Color}, it is {dog.Height} cm tall, and its age is {dog.Age}");
			dog.Eat();
			dog.Cry();

			Console.Write("Please enter a cat name: ");
			string catName = Console.ReadLine();
			Cat cat = new Cat(catName);
			Console.Write("Please give the cat a color: ");
			cat.Color = Console.ReadLine().ToLower();
			Console.Write("Please give the cat a height (in cm): ");
			cat.Height = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please give the cat an age: ");
			cat.Age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"The cats name is {cat.Name}, it is {cat.Color}, it is {cat.Height} cm tall, and its age is {cat.Age}");
			cat.Eat();
			cat.Cry();

			List<IAnimal> animals = new List<IAnimal>();
			animals.Add(cat);
			animals.Add(dog);
			animals.Add(new Cat("Mittens"));
			animals.Add(new Cat("Socks"));
			animals.Add(new Dog("Buster"));
			animals.Add(new Cat("Elizabeth"));
			animals.Add(new Dog("Buddy"));
			animals.Add(new Cat("Missy"));
			animals.Add(new Dog("Princess"));
			animals.Add(new Dog("Chuck"));

			foreach (var animal in animals)
			{
				Console.WriteLine(animal.Name);
			}

			Console.ReadLine();

		}
	}
}
