using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_4_1
{
	class Programm
	{
		static double res(double x)
		{
			if (x <= 0.5) throw new Exception();
			else return x / (Math.Sqrt(2 * x - 1));
		}

		static void Main(string[] agrs)
		{
			try
			{
				Console.Write("Введите A: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите B: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите H: ");
				double h = Convert.ToDouble(Console.ReadLine());

				for (double i = a; i <= b; i += h)
				{
					try
					{
						Console.WriteLine("f({0}) = {1:f4}", i, res(i));
					}
					catch
					{
						Console.WriteLine("f({0}) = error", i);
					}
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Введите корректные значения");
			}
			catch
			{
				Console.WriteLine("Неизвестная ошибка");
			}


		}
	}
}