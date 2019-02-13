using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInstances
{
    class Fjerbold : IRedskab
    {
        public string Placering { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Fjerbold(string placering, string navn, double pris)
        {
            Placering = placering;
            Navn = navn;
            Pris = pris;
        }
    }
}
