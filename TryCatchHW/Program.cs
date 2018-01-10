using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchHW
{
	class Program
	{
		static void Main(string[] args)
		{
			byte?[] mass = new byte?[20];
			FillMass(mass);
			ShowMass(mass);
			Console.ReadKey();
		}

		private static void ShowMass(byte?[] mass)
		{
			foreach (var item in mass)
			{
				Console.WriteLine(item);
			}
		}

		public static void FillMass(byte?[] mass)
		{
			Random rand = new Random();

			for (int i = 0; i < mass.Length; i++)
			{
				while (!mass[i].HasValue)
				{
					try
					{
						mass[rand.Next(-5, 30)] = Convert.ToByte(rand.Next(-50, 300));
					}
					catch (IndexOutOfRangeException ex)
					{
						Console.WriteLine(ex.Message);
						continue;
					}
					catch (OverflowException ex)
					{
						Console.WriteLine(ex.Message);
						continue;
					}
				}
			}
		}
	}
}


