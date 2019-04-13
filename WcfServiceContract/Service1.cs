using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class mojKalkulator : IKalkulator
	{
		public double Dodaj(double d1, double d2)
		{
			double result = d1 + d2;
			Console.WriteLine("Dodawanie {0} i {1}, otrzymany wynik to: {3}.", d1, d2, result);
			return result;
		}

		public double Odejmij(double d1, double d2)
		{
			double result = d1 - d2;
			Console.WriteLine("Odejmowanie {0} i {1}, otrzymany wynik to: {3}.", d1, d2, result);
			return result;
		}

		public double Pomnoz(double d1, double d2)
		{
			double result = d1 * d2;
			Console.WriteLine("Mnozenie {0} i {1}, otrzymany wynik to: {2}.", d1, d2, result);
			return result;
		}
	}
}
