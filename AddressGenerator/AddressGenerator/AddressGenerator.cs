using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    internal class AddressGenerator : IAddress
    {
        string address = "192.168.0.0";//indirizzo address predefinito
        string numero_bit;
        public AddressGenerator(string numero_bit) 
        {
            this.numero_bit = numero_bit;
        }

        private string IPv4()//creo il mio indirizzo IPv4, che lo considero come array
        {
            string [] IPv4 = new string[3];//sarà strutturato così: [address][/][numero_bit]
            IPv4[0] = address;
            IPv4[1] = "/";
            IPv4[2] = numero_bit;

            return IPv4[0] + IPv4[1] + IPv4[2];
        }
        public string generateIPv4()
        {
            return IPv4();
        }

        public string generateSubnet()//metodo che ritorna la subnet mask dell'indirizzo ip in base al numero di bit 
        {
            string sbmask;
            if(numero_bit == "16")//se il numero di bit è uguale ai valori tra 16 e 32, ritorno le seguenti subnet mask
            {
                return sbmask = "255.255.0.0";
            }
            else if(numero_bit == "17")
            {
                return sbmask = "255.255.128.0";
            }
            else if(numero_bit == "19")
            {
                return sbmask = "255.255.192.0";
            }
            else if(numero_bit == "20")
            {
                return sbmask = "255.255.224.0";
            }
            else if(numero_bit == "21")
            {
                return sbmask = "255.255.240.0";
            }
            else if(numero_bit == "22")
            {
                return sbmask = "255.255.248.0";
            }
            else if(numero_bit == "23")
            {
                return sbmask = "255.255.252.0";
            }
            else if (numero_bit == "24")
            {
                return sbmask = "255.255.255.0";
            }
            else if (numero_bit == "25")
            {
                return sbmask = "255.255.255.128";
            }
            else if (numero_bit == "26")
            {
                return sbmask = "255.255.255.192";
            }
            else if (numero_bit == "27")
            {
                return sbmask = "255.255.255.224";
            }
            else if (numero_bit == "28")
            {
                return sbmask = "255.255.255.240";
            }
            else if (numero_bit == "29")
            {
                return sbmask = "255.255.255.248";
            }
            else if (numero_bit == "30")
            {
                return sbmask = "255.255.255.252";
            }
            else if (numero_bit == "31")
            {
                return sbmask = "255.255.255.254";
            }
            else if (numero_bit == "32")
            {
                return sbmask = "255.255.255.255";
            }
            else
            {
                Console.WriteLine("Subnet mask non disponibile");
            }

        }
    }
}
