namespace ConsoleAppTask43
{
	internal class Program
	{
		static double[] intersectionOfPoint(double b1, double k1, double b2, double k2)
		{
			double[] intersection = new double[2];
			intersection[0] = -(b1 - b2) / (k1 - k2);
			intersection[1] = k1 * intersection[0] + b1;

			return intersection;
		}

		static void Main(string[] args)
		{
			double k1, k2, b1, b2;

			Console.Write("Введите b1: ");
			while(!double.TryParse(Console.ReadLine(), out b1))
			{
				Console.WriteLine("\nНеверный ввод, введите число b1!");
			}

			Console.Write("Введите k1: ");
			while(!double.TryParse(Console.ReadLine(), out k1))
			{
				Console.WriteLine("\nНеверный ввод, введите число k1!");
			}
			
			Console.Write("Введите b2: ");
			while(!double.TryParse(Console.ReadLine(), out b2))
			{
				Console.WriteLine("\nНеверный ввод, введите число b2!");
			}
			
			Console.Write("Введите k2: ");
			while(!double.TryParse(Console.ReadLine(), out k2))
			{
				Console.WriteLine("\nНеверный ввод, введите число k2!");
			}

			double [] intersection = intersectionOfPoint(b1,k1,b2,k2);

			Console.WriteLine("Пересечение находится в точках(" + intersection[0] + ";" + intersection[1] + ")");

			Console.ReadLine();
		}
	}
}

