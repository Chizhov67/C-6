namespace ConsoleAppTask41
{
	internal class Program
	{
		static void enterArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("Введите число № " + (i + 1) + " : ");
				while(!int.TryParse(Console.ReadLine(), out array[i]))
				{
					Console.Write("\nНеверный ввод, введите число № " + (i + 1) + ": ");
				}
					
			}
		}

		static int greaterZero(int [] array)
		{
			int count = 0;
			foreach(int element in array)
			{
				if (element > 0)
				{
					count++;
				}
			}

			return count;
		}

		static void Main(string[] args)
		{
			int M;

			Console.Write("Введите количество чисел которые вы хотите ввести: ");

			while(!int.TryParse(Console.ReadLine(), out M))
			{
				Console.Write("\nНеверный ввод, введите число: ");
			}

			int[] array = new int[M];
			enterArray(array);
			Console.WriteLine("\n\nЧисел больше нуля: " + greaterZero(array));

			Console.ReadLine();
		}
	}
}

