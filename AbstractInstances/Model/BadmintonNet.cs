using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInstances
{
    class BadmintonNet : IRedskab
    {
        public string Placering { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public BadmintonNet(string placering, string navn, double pris)
        {
            Placering = placering;
            Navn = navn;
            Pris = pris;
        }
    }
}
