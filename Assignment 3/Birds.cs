using System;

using A3.Eggs;
namespace A3.Birds
{
	abstract class Bird
	{
		public static Random Rand = new Random(1);

		//To run when Bord.LayEggs not called
		public  virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}

		//protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color)
        //{
		//	double eggsize = Math.Round(Rand.NextDouble() * (maxSize - minSize) + minSize, 1);
		//	Egg egg = new Egg(eggsize, color);
		//	BrokenEgg B_egg = new BrokenEgg(eggsize, color);
		//	Random rnd = new Random();
		//	int result = rnd.Next(1, 100);
		//	if (result <= 25)
		//	{
		//		Console.WriteLine(B_egg);
		//	}
		//	else
		//	{
		//		Console.WriteLine(egg);
		//	}
		//}
	}

	class Chicken : Bird
	{

		// To override LayEggs for Chicken
		public override Egg[] LayEggs(int numEggs)
        {
			
			for (int i = 0; i < numEggs; ++i)
            {
				double eggsize = Math.Round(Rand.NextDouble() * (4 - 2) + 2, 1);
				//for egg
				Egg egg = new Egg(eggsize, Eggs.Egg.Colors.brown);

				//for broken egg
				BrokenEgg B_egg = new BrokenEgg(eggsize, Eggs.BrokenEgg.Colors.brown);

				// 25% of chances of broken egg
				Random rnd = new Random();
				int result = rnd.Next(1, 100);
				if (result <= 25)
                {
					Console.WriteLine(B_egg);
				}
                else
                {
					Console.WriteLine(egg);
				}
								
			}
			return new Egg[0];
		}
	}

	class Ostrich : Bird 
	{
		// To override LayEggs for Ostrich
		public override Egg[] LayEggs(int numEggs)
		{
			
			for (int i = 0; i < numEggs; ++i)
			{
				double eggsize = Math.Round(Rand.NextDouble() * (15 - 10) + 10, 1);

				// For egg
				Egg egg = new Egg(eggsize, Eggs.Egg.Colors.speckled);

				//For broken egg
				BrokenEgg B_egg = new BrokenEgg(eggsize, Eggs.BrokenEgg.Colors.speckled);

				//45% chances of broken egg 
				Random rnd = new Random();
				int result = rnd.Next(1, 100);
				if (result <= 45)
				{
					Console.WriteLine(B_egg);
				}
				else
				{
					Console.WriteLine(egg);
				}
			}
			return new Egg[0];
		}
	}
}
