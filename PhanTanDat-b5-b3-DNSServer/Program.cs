using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTanDat_b5_b3_DNSServer
{
    class Program
    {
        private static dnsnamed named;
        static void Main(string[] args)
        {
            named = new dnsnamed();
            while (!false)
            {
                named.startListening();
            }
        }
    }
}
