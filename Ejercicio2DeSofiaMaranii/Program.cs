using System;

namespace ejercicio2desofiamarani
{
	class program
	{

		static void Main(string[] args)
		{
			double ax2;
			double bx2;
			double cx;
			double dy;
			double e;
			Console.Write("Ingrese el valor de Ax2: ");
			ax2 = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor de Bx2: ");
			bx2 = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor de Cx: ");
			cx = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor de Dy: ");
			dy = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor de E: ");
			e = Double.Parse(Console.ReadLine());
			if (ax2 != 0 && bx2 == 0)
			{
				Console.WriteLine("Es una parabola");
			}
			if (ax2 == 0 && bx2 != 0)
			{
				Console.WriteLine("Es una parabola");
			}
			if (ax2 != 0 && bx2 != 0 && ax2 == bx2)
			{
				Console.WriteLine("Es una circunferencia");
			}
			if (ax2 > 0 && bx2 > 0)
			{
				if (ax2 != bx2)
				{
					Console.WriteLine("Es una elipse");
				}
			}
			if (ax2 < 0 && bx2 < 0)
			{
				if (bx2 != ax2)
				{
					Console.WriteLine("Es una elipse");
				}
			}
			if (ax2 != 0 && bx2 != 0)
			{
				if (ax2 < 0 && bx2 > 0)
				{
					if (ax2 != bx2)
					{
						Console.WriteLine("Es una hiperbola");
					}
				}
			}
			if (ax2 != 0 && bx2 != 0)
			{
				if (ax2 > 0 && bx2 < 0)
				{
					if (ax2 != bx2)
					{
						Console.WriteLine("Es una hiperbola");
					}
				}
			}
		}

	}

}

