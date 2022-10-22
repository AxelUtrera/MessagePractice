using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MessageServiceServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service.MessageService)))
            {
                host.Open();
                Console.WriteLine("Servidor listo...");
                Console.Read();
            }
        }
    }
}
