using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceClient.ServiceReference1;

namespace WcfServiceClient
{
	class Program
	{
		static void Main(string[] args)
		{
				KalkulatorClient mojKlient = new KalkulatorClient();

				double result = mojKlient.Dodaj(3, 5);
				Console.WriteLine("Dodawanie 2 i 3, wynik: {0}", result);

				result = mojKlient.Odejmij(12, 4);
				Console.WriteLine("Odejmowanie 12 i 4, wynik: {0}", result);

				result = mojKlient.Pomnoz(5, 7);
				Console.WriteLine("Mnozenie 5 i 7, wynik: {0}", result);

				mojKlient.Close();
		}
	}
}
