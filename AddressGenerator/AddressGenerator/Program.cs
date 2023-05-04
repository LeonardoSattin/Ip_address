using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nbit;
            AddressGenerator IpAddress;

            Console.WriteLine("Inserire un numero di bit:");
            Nbit = Console.ReadLine();

            IpAddress = new AddressGenerator(Nbit);

            Console.WriteLine($"IPv4 address : {IpAddress.generateIPv4()}");
            Console.WriteLine($"IPv4 subnet mask: {IpAddress.generateSubnet()}");
        }
    }
}
