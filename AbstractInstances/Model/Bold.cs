using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInstances
{
    abstract class Bold : IRedskab
    {
        public int Diameter { get; set; }

        public abstract void Pump();
        public abstract void Hop();

        public abstract string Placering { get; set; }
        public abstract string Navn { get; set; }
        public abstract double Pris { get; set; }

        protected Bold(int diameter, string placering, string navn, double pris)
        {
            Diameter = diameter;
            Placering = placering;
            Navn = navn;
            Pris = pris;
        }
    }
}
