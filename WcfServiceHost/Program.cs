using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceContract;

namespace WcfServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			Uri baseAddress = new Uri("http://localhost:10016/service");
			ServiceHost mojHost = new ServiceHost(typeof(mojKalkulator), baseAddress);

			try
			{
				WSHttpBinding mojBinding = new WSHttpBinding();
				mojHost.AddServiceEndpoint(typeof(IKalkulator), mojBinding, "endpoint1");
				ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
				smb.HttpGetEnabled = true;
				mojHost.Description.Behaviors.Add(smb);
				mojHost.Open();
				Console.WriteLine("Serwis jest uruchomiony.");
				Console.WriteLine("Nacisnij ENTER aby zakonczyc.");
				Console.WriteLine();
				Console.ReadLine();
				mojHost.Close();
			}
			catch (CommunicationException ce)
			{
				Console.WriteLine("Wystapil wyjatek: {}", ce.Message);
				mojHost.Abort();
			}
		}
	}
}
