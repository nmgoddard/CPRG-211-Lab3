using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
	abstract class Animal
	{
		private string name;
		public string Name { get; set; }
		private string color;
		public string Color { get; set; }
		private int age;
		public int Age { get; set; }

		public abstract void Eat();
	}

	class Dog: Animal 
	{
		public Dog() { }
		public Dog(string name, string color, int age) 
		{
			Name = name;
			Color = color;
			Age = age;
		}
		public override void Eat() 
		{
			Console.WriteLine("Dogs eat meat.");
		}
	}
	class Cat : Animal 
	{
		public Cat() { }
		public Cat(string name, string color, int age) 
		{
			Name = name;
			Color = color;
			Age = age;
		}
		public override void Eat()
		{
			Console.WriteLine("Cats eat mice.");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"-- Abstract --\n");
			Console.Write("Please enter dog name: ");
			string dogName = Console.ReadLine();
			Console.Write("Please enter dog color: ");
			string dogColor = Console.ReadLine().ToLower();
			Console.Write("Please enter dog age: ");
			int dogAge = Convert.ToInt32(Console.ReadLine());

			Dog dog = new Dog(dogName, dogColor, dogAge);

			Console.WriteLine($"The dogs name is {dog.Name}, it is {dog.Color}, and its age is {dog.Age}");
			dog.Eat();

			Console.Write("Please enter cat name: ");
			string catName = Console.ReadLine();
			Console.Write("Please enter cat color: ");
			string catColor = Console.ReadLine().ToLower();
			Console.Write("Please enter cat age: ");
			int catAge = Convert.ToInt32(Console.ReadLine());

			Cat cat = new Cat(catName, catColor, catAge);

			Console.WriteLine($"The cats name is {cat.Name}, it is {cat.Color}, and its age is {cat.Age}");
			cat.Eat();

			Console.ReadLine();
		}
	}
}
