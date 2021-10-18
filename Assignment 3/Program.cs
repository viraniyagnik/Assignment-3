using System;

using A3.Birds;
using A3.Eggs;
namespace A3
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Bird bird;
				//To take user input based on their choice
				Console.Write("Press C for chicken or O for Ostrich: ");
				char key = Char.ToUpper(Console.ReadKey().KeyChar);
				//To call metrhod based on user choice 
				switch (key)
				{
					case 'C':
						bird = new Chicken();
						break;
					case 'O':
						bird = new Ostrich();
						break;
					default:
						return;
				}

				//Choice for how many eggs user want
				Console.Write("\nHow many eggs should it lay? ");
				if (!int.TryParse(Console.ReadLine(), out int numEggs)) { return; }
				Egg[] eggs = bird.LayEggs(numEggs);
				DisplayEggs(eggs);
			}
		}

		//To display the egg
		static void DisplayEggs(Egg[] eggs)
		{
			foreach (var egg in eggs)
			{
				Console.WriteLine(egg);
			}
		}
	}
}
