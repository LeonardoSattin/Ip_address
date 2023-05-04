using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    internal interface IAddress
    {
        string generateIPv4();//metodo che genera l'indirizzo ip
        string generateSubnet();//metodo che genera la subnet mask
    }
}
