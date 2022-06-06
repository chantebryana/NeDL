using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			Bird falcon = new Bird ();
			Bird eagle = new Bird("Bald Eagle", 15, 15, 15);

			Console.WriteLine(falcon);
			Console.WriteLine(eagle);

			Mammal mouse = new Mammal();
			Mammal cat = new Mammal("Puma", 40, "black", 25);

			Console.WriteLine(mouse);
			Console.WriteLine(cat);

			Insect ant = new Insect();
			Insect spider = new Insect("Wolf Spider", 1, false, 28);

			Console.WriteLine(ant);
			Console.WriteLine(spider);
    } //end main
  } //end class
} //end namespace